using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
using UnityEngine;

namespace PugMod
{
	public class ImporterWindow : EditorWindow
	{
		private const string WINDOW_TITLE = "Mod SDK Installer";
		private const string SDK_ZIP_PATH = "Assets/ModSDK/EditorAssemblies.zip";
		private const string METAFILE_ZIP_PATH = "Assets/ModSDK/Data/MetaFiles.zip";

		private ImporterSettings _settings;
		private Editor _editor = null;

		private Vector2 _scrollPosition;

		//[MenuItem("PugMod/Installer")]
		public static void ShowWindow()
		{
			GetWindow<ImporterWindow>(WINDOW_TITLE);
		}
		
		private void OnEnable()
		{
			_settings = ImporterSettings.Instance;
		}

		private void OnGUI()
		{
			if (_settings == null)
			{
				return;
			}

			_scrollPosition = GUILayout.BeginScrollView(_scrollPosition);

			// Expose settings properties in a user-friendly way
			Editor.CreateCachedEditor(_settings, null, ref _editor);
			
			EditorGUI.BeginChangeCheck();
			
			_editor.OnInspectorGUI();

			if (EditorGUI.EndChangeCheck())
			{
				EditorUtility.SetDirty(_settings);
				AssetDatabase.SaveAssetIfDirty(_settings);
			}

			if (GUILayout.Button("Update SDK"))
			{
				var gamePath = EditorUtility.OpenFolderPanel("Select Game Directory", "", "");
				UpdateFromGamePath(_settings, gamePath, out var addedAssemblies);
			}
			
			GUILayout.EndScrollView();
		}

		/// <summary>
		/// Updates the dlls by snatching them from the game files.
		/// </summary>
		/// <param name="gamePath">Path to game install folder</param>
		public static void UpdateFromGamePath(ImporterSettings settings, string gamePath, out List<string> addedAssemblies)
		{
			addedAssemblies = new List<string>();
			
			if (string.IsNullOrEmpty(gamePath))
			{
				return;
			}
		
			var dirInfo = new DirectoryInfo(gamePath);
			if (!dirInfo.Exists)
			{
				Debug.LogError($"{dirInfo.FullName} doesn't exist");
				return;
			}

			if (!File.Exists(Path.Combine(dirInfo.FullName, $"{ImporterSettings.GAME_NAME}.exe")))
			{
				EditorUtility.DisplayDialog("Not found", "Couldn't find game executable in chosen directory", "Ok");
				Debug.Log($"failed to found game executable at {dirInfo.FullName}, skipping import");
				return;
			}

			var destDirInfo = new DirectoryInfo(settings.gameAssemblyPath);
			if (!destDirInfo.Exists)
			{
				destDirInfo.Create();
			}

			var assemblyDestPaths = new List<string>();
			var assemblyDir = new DirectoryInfo(Path.Combine(gamePath, $"{ImporterSettings.GAME_NAME}_Data", "Managed"));

			var includeRegex = settings.includeGameAssemblies.Select(x => new Regex(x)).ToList();
			var excludeRegex = settings.excludeGameAssemblies.Select(x => new Regex(x)).ToList();
		
			try
			{
				AssetDatabase.StartAssetEditing();

				var assembliesFromSDK = new HashSet<string>();

				if (File.Exists(SDK_ZIP_PATH))
				{
					// Install some non-editor assemblies where we just need the version compiled with UNITY_EDITOR
					// instead of the one pulled from the game files.
					var zip = ZipFile.OpenRead(SDK_ZIP_PATH);
					foreach (var zipFile in zip.Entries)
					{
						if (zipFile.Name.EndsWith(".Editor.dll"))
						{
							continue;
						}
							
						var destPath = Path.Combine(settings.gameAssemblyPath, zipFile.Name);
						zipFile.ExtractToFile(destPath, true);
						assembliesFromSDK.Add(zipFile.Name);
					}
				}

				var metaFileLookup = new Dictionary<string, ZipArchiveEntry>();
				
				if (File.Exists(METAFILE_ZIP_PATH))
				{
					// Install some non-editor assemblies where we just need the version compiled with UNITY_EDITOR
					// instead of the one pulled from the game files.
					var zip = ZipFile.OpenRead(METAFILE_ZIP_PATH);
					foreach (var zipFile in zip.Entries)
					{
						metaFileLookup.Add(zipFile.Name.Substring(0, zipFile.Name.Length - ".meta".Length), zipFile);
					}
				}
		
				foreach (var assembly in assemblyDir.EnumerateFiles("*.dll"))
				{
					Match includeMatch = null;
					Match excludeMatch = null;

					if (assembliesFromSDK.Contains(assembly.Name))
					{
						// We already installed this from SDK, which probably means we need the editor version or things will break in editor
						continue;
					}
					
					foreach (var regex in includeRegex)
					{
						if (regex.IsMatch(assembly.Name))
						{
							includeMatch = regex.Match(assembly.Name);
							break;
						}
					}
					
					foreach (var regex in excludeRegex)
					{
						if (regex.IsMatch(assembly.Name))
						{
							excludeMatch = regex.Match(assembly.Name);
							break;
						}
					}
					
					bool include = settings.includeAllAssemblies;

					if (includeMatch != null && excludeMatch != null)
					{
						// both matches, take closest
						if (includeMatch.Length > excludeMatch.Length)
						{
							include = true;
						}
						else
						{
							include = false;
						}
					}
					else if (includeMatch != null)
					{
						include = true;
					}
					else if (excludeMatch != null)
					{
						include = false;
					}
					
					if (!include)
					{
						Debug.Log($"Skipping {assembly}");
						continue;
					}

					var sourcePath = assembly.FullName;
					var destPath = Path.Combine(destDirInfo.FullName, assembly.Name);
					File.Copy(sourcePath, destPath, true);
					Debug.Log($"Loaded {assembly} from game files");

					if (metaFileLookup.ContainsKey(assembly.Name))
					{
						var metaFilePath = destPath + ".meta";
						if (!File.Exists(metaFilePath))
						{
							metaFileLookup[assembly.Name].ExtractToFile(metaFilePath);
						}
					}
			
					assemblyDestPaths.Add(destPath);
					addedAssemblies.Add(Path.GetFileNameWithoutExtension(assembly.Name));
				}

				if (File.Exists(SDK_ZIP_PATH))
				{
					var zip = ZipFile.OpenRead(SDK_ZIP_PATH);
					foreach (var zipFile in zip.Entries)
					{
						if (!zipFile.Name.EndsWith(".Editor.dll"))
						{
							continue;
						}

						// Special case where this isn't pulled by default and name doesn't match editor dll
						if (zipFile.Name.EndsWith("PugText.Editor.dll"))
						{
							if (!addedAssemblies.Contains("Pug.Other"))
							{
								continue;
							}
						}
						
						// Install everything for now, might want to filter no game files later, but needs smarter check
						//var matchingAssemblyIndex = addedAssemblies.FindIndex(x => zipFile.Name.StartsWith(x));
						//if (matchingAssemblyIndex != -1)
						{
							if (!Directory.Exists(settings.sdkAssemblyPath))
							{
								Directory.CreateDirectory(settings.sdkAssemblyPath);
							}
							
							// Found matching editor assembly, install this
							zipFile.ExtractToFile(Path.Combine(settings.sdkAssemblyPath, zipFile.Name), true);
						}
					}
				}
			}
			finally
			{
				AssetDatabase.StopAssetEditing();	
			}
			
			AssetDatabase.Refresh(ImportAssetOptions.ForceSynchronousImport);
		}
	}
	
#if PUG_MOD_SDK
	/// <summary>
	/// Unity is really weird about us wanting to disable "Auto reference" since that breaks because of namespace collisions.
	/// Trying to set this immediately when adding failed because PluginImporter will be null, even with slight delay.
	/// Has to use reflection to access hidden members because for some reason Unity wanted those to be internal and there is absolutely no other way to do this.
	/// Changing the .meta file directly doesn't work either, it caches it locally so would have to change that while editor is not running I think.
	/// </summary>
	public class GameAssemblyPostprocessor : AssetPostprocessor
	{
		private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
		{
			bool importedDll = false;
			foreach (string asset in importedAssets)
			{
				if (!asset.EndsWith(".dll"))
				{
					continue;
				}

				importedDll = true;
				break;
			}

			if (!importedDll)
			{
				// Early out to skip StartAssetEditing which interfers a lot in trying to modify assets in editor
				// If you change a value in prefab and call StartAssetEditing it is deselected...
				return;
			}
			
			try
			{
				AssetDatabase.StartAssetEditing();
				var importerSettings = ImporterSettings.Instance;
				if (importerSettings == null)
				{
					return;
				}

				var gameAssemblyDirectoryInfo = new DirectoryInfo(importerSettings.gameAssemblyPath);
				var sdkAssemblyDirectoryInfo = new DirectoryInfo(importerSettings.sdkAssemblyPath);

				foreach (string asset in importedAssets)
				{
					if (!asset.EndsWith(".dll"))
					{
						continue;
					}

					var fileInfo = new FileInfo(asset);

					if (fileInfo.FullName.StartsWith(gameAssemblyDirectoryInfo.FullName) ||
					    fileInfo.FullName.StartsWith(sdkAssemblyDirectoryInfo.FullName))
					{
						SetAutoReference(asset);
					}
				}
			}
			finally
			{
				AssetDatabase.StopAssetEditing();
			}
		}

		private static void SetAutoReference(string dllPath)
		{
			var importer = AssetImporter.GetAtPath(dllPath) as PluginImporter;
			if (importer == null)
			{
				Debug.LogError($"couldn't get importer for {dllPath}");
				return;
			}
			
			bool anyChange = false;
			
			PropertyInfo isExplicitlyReferencedProperty = typeof(PluginImporter).GetProperty(
				"IsExplicitlyReferenced", BindingFlags.NonPublic | BindingFlags.Instance);

			if (isExplicitlyReferencedProperty != null)
			{
				var currentValue = isExplicitlyReferencedProperty.GetValue(importer, null);
				if (currentValue is false)
				{
					isExplicitlyReferencedProperty.SetValue(importer, true, null);
					anyChange = true;
				}
			}
			else
			{
				Debug.LogError("Failed to get IsExplicitlyReferenced property.");
			}
			
			PropertyInfo validateReferencesProperty = typeof(PluginImporter).GetProperty(
				"ValidateReferences", BindingFlags.NonPublic | BindingFlags.Instance);

			if (validateReferencesProperty != null)
			{
				var currentValue = validateReferencesProperty.GetValue(importer, null);
				if (currentValue is true)
				{
					validateReferencesProperty.SetValue(importer, false, null);
					anyChange = true;
				}
			}
			else
			{
				Debug.LogError("Failed to get ValidateReferences property.");
			}

			if (anyChange)
			{
				Debug.Log($"set auto reference and/or !validate references on {dllPath}");
				importer.SaveAndReimport();
			}
		}
	}
#endif
}