using System;
using UnityEditor;
using System.IO;
using PugMod;
using UnityEditor.Build.Pipeline;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PugMod
{
	public static class ModBuilder
	{
		private static readonly List<BuildConfig> Configs = new()
		{
			new BuildConfig
			{
				Name = "Windows",
				BuildTarget = BuildTarget.StandaloneWindows64,
				BuildTargetGroup = BuildTargetGroup.Standalone,
			},
			new BuildConfig
			{
				Name = "Linux",
				BuildTarget = BuildTarget.StandaloneLinux64,
				BuildTargetGroup = BuildTargetGroup.Standalone,
			},
		};

		public static void BuildMod(ModBuilderSettings settings, string exportPath, Action<bool> callback, bool installInSubDirectory = true)
		{
			var modName = settings.metadata.name;
			var modDirectory = settings.modPath;

			var installDirectory = installInSubDirectory ? Path.Combine(exportPath, modName) : exportPath;
			var installDirectoryInfo = new DirectoryInfo(installDirectory);

			List<string> assetPaths = null;
			List<string> originalAssetPaths = null;
			
			try
			{
				AssetDatabase.DisallowAutoRefresh();

				// Remove old files
				if (installInSubDirectory && Directory.Exists(installDirectory))
				{
					Directory.Delete(installDirectory, true);
				}

				if (installInSubDirectory)
				{
					Directory.CreateDirectory(installDirectory);
				}

				var assetGuids = AssetDatabase.FindAssets("t:Object", new[] { modDirectory });
				assetPaths = assetGuids.Select(AssetDatabase.GUIDToAssetPath).Where(x => !Directory.Exists(x)).ToList();

				originalAssetPaths = new List<string>(assetPaths);
				List<string> manifest = new();

				PreProcess(settings, installDirectory, assetPaths);

				BuildConf(modDirectory, installDirectory, assetPaths, manifest);
				BuildLocalization(modDirectory, installDirectory, assetPaths, manifest);

				BuildScripts(modDirectory, modName, installDirectory, assetPaths, manifest);
				BuildLibraries(modDirectory, installDirectory, assetPaths, manifest);

				if (!BuildAssets(modDirectory, modName, installDirectory, Configs, assetPaths, manifest))
				{
					callback?.Invoke(false);
					return;
				}

				// Create mod manifest
				var modManifest = settings.metadata;
				modManifest.files.Clear();

				foreach (var outputFile in manifest)
				{
					FileInfo fileInfo = new FileInfo(outputFile);
					// Use relative path to mod folder in manifest
					var path = fileInfo.FullName.Substring(installDirectoryInfo.FullName.Length + 1).Replace('\\', '/');
					modManifest.files.Add(new ModFile { path = path });
				}

				// Write mod manifest to disk
				string json = JsonUtility.ToJson(modManifest, true);
				File.WriteAllText(Path.Combine(installDirectory, Constants.MOD_MANIFEST_FILE), json);

				Debug.Log($"Successfully built mod at {installDirectory}");
				callback?.Invoke(true);
			}
			catch (Exception e)
			{
				Debug.LogException(e);
				callback?.Invoke(false);
			}
			finally
			{
				if (assetPaths != null && originalAssetPaths != null)
				{
					// Remove temporary files created in project during install
					foreach (var asset in assetPaths.Except(originalAssetPaths))
					{
						File.Delete(asset);
					}
				}
				AssetDatabase.AllowAutoRefresh();
			}
		}
		
		private static void PreProcess(ModBuilderSettings modBuilderSettings, string installDirectory, List<string> assetPaths)
		{
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				try
				{
					foreach (var type in assembly.GetTypes())
					{
						if (type.IsClass && !type.IsAbstract && typeof(IPugModBuilderProcessor).IsAssignableFrom(type))
						{
							var processor = Activator.CreateInstance(type) as IPugModBuilderProcessor;
							processor.Execute(modBuilderSettings, installDirectory, assetPaths);
						}
					}
				}
				catch (ReflectionTypeLoadException)
				{
					//Debug.Log($"{assembly.FullName} got load exception");
				}
			}
		}

		private static void BuildConf(string modDirectory, string outputPath, List<string> assetPaths, List<string> manifest)
		{
			var modConfDirectoryInfo = new DirectoryInfo(Path.Combine(modDirectory, "Conf"));
			
			for (int i = assetPaths.Count - 1; i >= 0; --i)
			{
				var asset = assetPaths[i];
				if (!asset.EndsWith(".json"))
				{
					continue;
				}

				var assetFileInfo = new FileInfo(asset);
				if (!assetFileInfo.FullName.StartsWith(modConfDirectoryInfo.FullName))
				{
					continue;
				}

				IncludeAssetDirectly(asset, modDirectory, outputPath, manifest);
				assetPaths.RemoveAt(i);
			}
		}

		private static void BuildLocalization(string modDirectory, string outputPath, List<string> assetPaths, List<string> manifest)
		{
			var modLocalizationDirectoryInfo = new DirectoryInfo(Path.Combine(modDirectory, "Localization"));
			
			for (int i = assetPaths.Count - 1; i >= 0; --i)
			{
				var asset = assetPaths[i];
				if (!asset.EndsWith(".csv"))
				{
					continue;
				}

				var assetFileInfo = new FileInfo(asset);
				if (!assetFileInfo.FullName.StartsWith(modLocalizationDirectoryInfo.FullName))
				{
					continue;
				}

				IncludeAssetDirectly(asset, modDirectory, outputPath, manifest);
				assetPaths.RemoveAt(i);
			}
		}

		private static void BuildScripts(string modDirectory, string modName, string outputPath, List<string> assetPaths, List<string> manifest)
		{
			DirectoryInfo directoryInfo = new(modDirectory);
			List<string> scriptPaths = new();
			List<string> relativeDestPaths = new();
			
			for (int i = assetPaths.Count - 1; i >= 0; --i)
			{
				var asset = assetPaths[i];
				if (IsInEditorFolder(asset, modDirectory))
				{
					continue;
				}
				
				if (!asset.EndsWith(".cs"))
				{
					continue;
				}

				FileInfo assetFileInfo = new(asset);
					
				scriptPaths.Add(asset);
				relativeDestPaths.Add(assetFileInfo.FullName.Substring(directoryInfo.FullName.Length + 1));
				assetPaths.RemoveAt(i);
			}
			
			foreach (var asset in scriptPaths)
			{
				AssetDatabase.ImportAsset(asset, ImportAssetOptions.ForceUpdate | ImportAssetOptions.ForceSynchronousImport);
			}

			var generatedCodeDirectories = new string[]
			{
				Path.Combine(Application.dataPath, "..", "Temp", "GeneratedCode"),
				Path.Combine(Application.dataPath, "..", "Temp", "NetCodeGenerated")
			};

			foreach (var dir in generatedCodeDirectories)
			{
				string generatedCodeModDir = Path.Combine(dir, modName);
				if (Directory.Exists(generatedCodeModDir))
				{
					var tempFiles = Directory.GetFiles(generatedCodeModDir, "*", SearchOption.AllDirectories);
					foreach (var tempFile in tempFiles)
					{
						Debug.Log($"Adding generated file {tempFile}");
						scriptPaths.Add(tempFile);
						relativeDestPaths.Add(Path.Combine("Generated", new FileInfo(tempFile).Name));
					}
				}
			}
				
			const string scriptsFolder = "Scripts";
			if (scriptPaths.Count > 0 && !Directory.Exists(Path.Combine(outputPath, scriptsFolder)))
			{
				Directory.CreateDirectory(Path.Combine(outputPath, scriptsFolder));
			}
			
			for (int i = 0; i < scriptPaths.Count; ++i)
			{
				var fileInfo = new FileInfo(scriptPaths[i]);
				var destFileInfo = new FileInfo(Path.Combine(outputPath, scriptsFolder, relativeDestPaths[i]));
				if (!destFileInfo.Directory.Exists)
				{
					destFileInfo.Directory.Create();
				}
				File.Copy(fileInfo.FullName, destFileInfo.FullName, true);
				manifest.Add(destFileInfo.FullName);
			}
			
#if false
			const string generatedFolder = "Generated";
			if (tempScriptPaths.Count > 0 && !Directory.Exists(Path.Combine(installDirectory, scriptsFolder, generatedFolder)))
			{
				Directory.CreateDirectory(Path.Combine(installDirectory, scriptsFolder, generatedFolder));
			}
			
			foreach (var script in tempScriptPaths)
			{
				var fileInfo = new FileInfo(script);
				var destPath = Path.Combine(installDirectory, scriptsFolder, generatedFolder, fileInfo.Name);
				File.Copy(fileInfo.FullName, destPath, true);
				allModFiles.Add(destPath);
			}
#endif
		}

		private static void BuildLibraries(string modDirectory, string outputPath, List<string> assetPaths, List<string> manifest)
		{
			List<string> dllPaths = new();
			
			for (int i = assetPaths.Count - 1; i >= 0; --i)
			{
				var asset = assetPaths[i];
				if (IsInEditorFolder(asset, modDirectory))
				{
					continue;
				}

				if (!asset.EndsWith(".dll"))
				{
					continue;
				}
					
				dllPaths.Add(asset);
				assetPaths.RemoveAt(i);
			}
			

			const string librariesFolder = "Libraries";
			if (dllPaths.Count > 0 && !Directory.Exists(Path.Combine(outputPath, librariesFolder)))
			{
				Directory.CreateDirectory(Path.Combine(outputPath, librariesFolder));
			}

			foreach (var dll in dllPaths)
			{
				var fileInfo = new FileInfo(dll);
				var destPath = Path.Combine(outputPath, librariesFolder, fileInfo.Name);
				File.Copy(fileInfo.FullName, destPath, true);
				manifest.Add(destPath);
			}
		}

		private static bool BuildAssets(string modDirectory, string modName, string outputPath, List<BuildConfig> buildConfigs, List<string> assetPaths, List<string> manifest)
		{
			List<string> assetsToIncludeInBundle = new();

			for (int i = assetPaths.Count - 1; i >= 0; --i)
			{
				var asset = assetPaths[i];
				if (IsInEditorFolder(asset, modDirectory))
				{
					continue;
				}

				assetsToIncludeInBundle.Add(asset);
				assetPaths.RemoveAt(i);
			}

			foreach (var buildConfig in buildConfigs)
			{
				var bundleBuilds = new List<AssetBundleBuild>();

				if (assetsToIncludeInBundle.Count != 0)
				{
					AssetBundleBuild build = new AssetBundleBuild
					{
						assetBundleName = $"{modName}_{buildConfig.Name}.assetbundle",
						assetNames = assetsToIncludeInBundle.ToArray(),
					};

					bundleBuilds.Add(build);
				}

				if (bundleBuilds.Count != 0)
				{
					// Define the build parameters
					var buildParams = new BundleBuildParameters(buildConfig.BuildTarget, buildConfig.BuildTargetGroup,
						Path.Combine(outputPath, "Bundles"));

					// Define the build content
					var buildContent = new BundleBuildContent(bundleBuilds);

					// Build the asset bundles
					var result = ContentPipeline.BuildAssetBundles(buildParams, buildContent, out var outputBundles);

					if (result != ReturnCode.Success)
					{
						Debug.LogError("Mod assetbundle build failed: " + result);
						return false;
					}

					var bundleBuildLogFile = Path.Combine(buildParams.OutputFolder, "buildlogtep.json");
					File.Delete(bundleBuildLogFile);

					foreach (var outputBundle in outputBundles.BundleInfos)
					{
						manifest.Add(outputBundle.Value.FileName);
					}
				}
			}

			return true;
		}

		private static void IncludeAssetDirectly(string assetPath, string modDirectory, string installDirectory, List<string> manifest)
		{
			var assetFileInfo = new FileInfo(assetPath);
			var modDirectoryInfo = new DirectoryInfo(modDirectory);
			var relativePath = assetFileInfo.FullName.Substring(modDirectoryInfo.FullName.Length + 1);
			var destPath = Path.Combine(installDirectory, relativePath);
			var destPathInfo = new FileInfo(destPath);
			if (!destPathInfo.Directory.Exists)
			{
				destPathInfo.Directory.Create();
			}
			File.Copy(assetFileInfo.FullName, destPathInfo.FullName, true);
			manifest.Add(destPath);
		}

		private static bool IsInEditorFolder(string scriptPath, string modDirectory)
		{
			var fileInfo = new FileInfo(scriptPath);
			var modDirectoryInfo = new DirectoryInfo(modDirectory);

			var parentDirectory = fileInfo.Directory;
			while (parentDirectory != null && !parentDirectory.FullName.Equals(modDirectoryInfo.FullName))
			{
				if (parentDirectory.Name.Equals("Editor"))
				{
					return true;
				}
				parentDirectory = parentDirectory.Parent;
			}

			return false;
		}

		private struct BuildConfig
		{
			public string Name;
			public BuildTarget BuildTarget;
			public BuildTargetGroup BuildTargetGroup;
		}
	}

	public interface IPugModBuilderProcessor
	{
		public void Execute(ModBuilderSettings settings, string installDirectory, List<string> assetPaths);
	}
}
