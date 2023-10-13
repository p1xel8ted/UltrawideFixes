using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace PugMod
{
	public class ModBuilderWindow : EditorWindow
	{
		private const string WINDOW_TITLE = "Mod Builder";
		private const string SETTINGS_PATH_KEY = "PugMod/BuilderWindow/ExporterSettingsPath";
		private const string INSTALL_DIRECTORY_KEY = "PugMod/BuilderWindow/InstallPath";
		private const string MOD_TEMPLATE_NAME = "Assets/ModSDK/ModTemplate.zip";
		private const string NEW_MOD_PATH = "Assets";
		private const string NEW_MOD_NAME_HINT = "New Mod Name";

		private ModBuilderSettings _settings;
		private Editor _editor = null;

		private string _newModName = NEW_MOD_NAME_HINT;
		private string _message;
		private bool _verified = false;
		
		private bool IsRunningBuild => false; // Might want later for async, coroutine didn't work well

		//[MenuItem("PugMod/Build Mod")]
		public static void ShowWindow()
		{
			GetWindow<ModBuilderWindow>(WINDOW_TITLE);
		}
		
		private void OnEnable()
		{
			string settingsPath = EditorPrefs.GetString(SETTINGS_PATH_KEY, "");
			if (!string.IsNullOrEmpty(settingsPath))
			{
				_settings = AssetDatabase.LoadAssetAtPath<ModBuilderSettings>(settingsPath);
			}
		}

		public static ModBuilderSettings CreateNewMod(string modName)
		{
			AssetDatabase.StartAssetEditing();

			try
			{
				var settings = CreateInstance<ModBuilderSettings>();

				var importerSettings = ImporterSettings.Instance;

				var newModDirectory = Path.Combine(NEW_MOD_PATH, modName);

				var modTemplatePath = MOD_TEMPLATE_NAME;

				settings.metadata.name = modName;
				// If we have include all assemblies set, then we will probably need this
				settings.metadata.accessesExtraAssemblies = importerSettings.includeAllAssemblies;

				settings.modPath = newModDirectory;

				Directory.CreateDirectory(newModDirectory);

				// Extract everything in mod template zip to new mod directory
				if (File.Exists(modTemplatePath))
				{
					ZipFile.ExtractToDirectory(modTemplatePath, newModDirectory);
				}

				var modSettingsPath = Path.Combine(NEW_MOD_PATH, modName + ".asset");
				AssetDatabase.CreateAsset(settings, modSettingsPath);

				var assemblyReferences = new List<string>();

				assemblyReferences.Add("Unity.Burst");
				assemblyReferences.Add("Unity.Collections");
				assemblyReferences.Add("Unity.Entities");
				assemblyReferences.Add("Unity.Entities.Hybrid");
				assemblyReferences.Add("Unity.Jobs");
				assemblyReferences.Add("Unity.Mathematics");
				assemblyReferences.Add("Unity.NetCode");
				assemblyReferences.Add("Unity.NetCode.Physics");
				assemblyReferences.Add("Unity.Networking.Transport");
				assemblyReferences.Add("Unity.Physics");
				assemblyReferences.Add("Unity.Physics.Hybrid");
				assemblyReferences.Add("Unity.Properties");
				assemblyReferences.Add("Unity.Transforms");
				assemblyReferences.Add("PugMod.SDK");

				// Find all .dll files from game in Plugins folder to add as references to assembly definition
				var dllFiles = Directory.Exists(importerSettings.gameAssemblyPath) ? Directory.GetFiles(importerSettings.gameAssemblyPath, "*.dll", SearchOption.AllDirectories).Select(x => new FileInfo(x)) : Array.Empty<FileInfo>();

				var assemblyDefPath = Path.Combine(newModDirectory, $"{modName}.asmdef");
				var assemblyDefinition = new AssemblyDefinitionCreator.AssemblyDefinition
				{
					name = modName,
					references = assemblyReferences.ToArray(),
					// Both empty should be all
					includePlatforms = new string[]
					{
					},
					excludePlatforms = new string[]
					{
					},
					allowUnsafeCode = false,
					overrideReferences = true,
					precompiledReferences = dllFiles.Select(x => x.Name).ToArray(),
					autoReferenced = false,
					defineConstraints = new string[]
					{
					},
					versionDefines = new AssemblyDefinitionCreator.VersionDefine[]
					{
					},
					useGUIDs = false,
				};

				if (!AssemblyDefinitionCreator.WriteAssemblyDefinition(assemblyDefPath, assemblyDefinition))
				{
					Debug.LogError($"Failed to write asmdef at {assemblyDefPath}");
				}

				return settings;
			}
			catch (Exception e)
			{
				Debug.LogException(e);
				return null;
			}
			finally
			{
				AssetDatabase.StopAssetEditing();
				AssetDatabase.Refresh();
			}
		}

		private bool ModExists(string modName)
		{
			if (File.Exists(Path.Combine(NEW_MOD_PATH, modName + ".asset")) || Directory.Exists(Path.Combine(NEW_MOD_PATH, modName)))
			{
				return true;
			}

			return false;
		}

		private void OnGUI()
		{
			var oldSettings = _settings;
			
			GUILayout.Label(WINDOW_TITLE, EditorStyles.boldLabel);

			EditorGUI.BeginChangeCheck();
			_settings = (ModBuilderSettings)EditorGUILayout.ObjectField("Build Settings", _settings, typeof(ModBuilderSettings), false);
			if (EditorGUI.EndChangeCheck())
			{
				string path = AssetDatabase.GetAssetPath(_settings);
				EditorPrefs.SetString(SETTINGS_PATH_KEY, path);
			}

			if (_settings == null)
			{
				// Text field for entering name of new mod. Enter text and then press create mod button to create a new mod.
				_newModName = GUILayout.TextField(_newModName, 25);
				if (GUILayout.Button("Create New Mod"))
				{
					if (string.IsNullOrEmpty(_newModName) || _newModName.Equals(NEW_MOD_NAME_HINT))
					{
						EditorUtility.DisplayDialog("No name", "Please enter a name for the new mod.", "OK");
					}
					else if (ModExists(_newModName))
					{
						EditorUtility.DisplayDialog("Mod already exists", "A mod with that name already exists.", "OK");
					}
					else
					{
						_settings = CreateNewMod(_newModName);
					}
				}
			}
			else
			{
				// Expose settings properties in a user-friendly way
				Editor.CreateCachedEditor(_settings, null, ref _editor);
				_editor.OnInspectorGUI();
				
				_verified = true;
#if false
				var buttonStyle = new GUIStyle(GUI.skin.button);
				// Set red if error, green if verified
				buttonStyle.normal.textColor = _verified ? Color.green : Color.white;
				
				if (GUILayout.Button("Verify Files", buttonStyle))
				{
					VerifyMod();
				}
#endif

				if (_verified)
				{
					if (GUILayout.Button(IsRunningBuild ? "Cancel" : "Build Mod"))
					{
						if (IsRunningBuild)
						{
							_message = "Mod build cancelled.";
						}
						else
						{
							string installPath = "";
							if (EditorPrefs.HasKey(INSTALL_DIRECTORY_KEY))
							{
								installPath = EditorPrefs.GetString(INSTALL_DIRECTORY_KEY);
							}
							installPath = EditorUtility.OpenFolderPanel("Select Install Directory", installPath, "");
							if (Directory.Exists(installPath))
							{
								_message = "Mod build started...";
								EditorPrefs.SetString(INSTALL_DIRECTORY_KEY, installPath);
								ModBuilder.BuildMod(_settings, installPath, success =>
								{
									_message = success ? "Mod built successfully." : "Mod build failed.";
								});
							}
						}
					}
				}
				
				if (!string.IsNullOrEmpty(_message))
				{
					GUILayout.TextArea(_message);
				}
			}

			if (_settings != oldSettings)
			{
				if (_settings == null)
				{
					EditorPrefs.DeleteKey(SETTINGS_PATH_KEY);
				}
				else
				{
					EditorPrefs.SetString(SETTINGS_PATH_KEY, AssetDatabase.GetAssetPath(_settings));
				}
			}
		}
	}
}
