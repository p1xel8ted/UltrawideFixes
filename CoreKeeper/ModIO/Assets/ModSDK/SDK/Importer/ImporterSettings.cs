using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace PugMod
{
	public class ImporterSettings : ScriptableObject
	{
		private static ImporterSettings _instance;
	
		public static ImporterSettings Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = AssetDatabase.LoadAssetAtPath<ImporterSettings>(SETTINGS_PATH);
					if (_instance == null)
					{
						_instance = CreateInstance<ImporterSettings>();
						var settingsFileInfo = new FileInfo(SETTINGS_PATH);
						if (settingsFileInfo.Directory is { Exists: false })
						{
							settingsFileInfo.Directory.Create();
						}
						AssetDatabase.CreateAsset(_instance, SETTINGS_PATH);
					}
					_instance.Initialize();
				}

				return _instance;
			}
		}

		public const string GAME_NAME = "CoreKeeper";
		
		private const int CURRENT_VERSION = 2;
		private const string SETTINGS_PATH = "Assets/ModSDK/ModSDKSettings.asset";

		public bool includeAllAssemblies = true;
		public List<string> includeGameAssemblies = new List<string>();
		public List<string> excludeGameAssemblies = new List<string>();
		
		public string sdkAssemblyPath  = $"Assets/Plugins/{GAME_NAME}ModSDK/";
		public string gameAssemblyPath = $"Assets/Plugins/{GAME_NAME}/";
	
		[HideInInspector]
		public int initializedToVersion = 0;

		private void Initialize()
		{
			if (initializedToVersion >= CURRENT_VERSION)
			{
				return;
			}

			if (initializedToVersion < 1)
			{
				includeGameAssemblies.Add("NaughtyAttributes.Core.dll");
				includeGameAssemblies.Add("DomainReloadHelper.Runtime.dll");
				includeGameAssemblies.Add("Pug.Base.dll");
				includeGameAssemblies.Add("Pug.ECS.Authoring.dll");
				includeGameAssemblies.Add("Pug.ECS.Components.dll");
				includeGameAssemblies.Add("Pug.ECS.ConditionExtensions.dll");
				includeGameAssemblies.Add("Pug.UnityExtensions.dll");
				includeGameAssemblies.Add("PugMod.SDK.Runtime.dll");
				includeGameAssemblies.Add("PugProperties.dll");

				excludeGameAssemblies.Add(@"mscorlib.dll");
				excludeGameAssemblies.Add(@"netstandard.dll");
				excludeGameAssemblies.Add(@"mcs.dll");
				excludeGameAssemblies.Add(@"^System.");
				excludeGameAssemblies.Add(@"^Mono.");
				excludeGameAssemblies.Add(@"^Unity");
				excludeGameAssemblies.Add(@"^Microsoft.");
				// Remove TraceManager and keep this?
				//excludeGameAssemblies.Add(@"^io.sentry.");
				//excludeGameAssemblies.Add(@"^Sentry.");
				excludeGameAssemblies.Add(@"CgSDK.dll");
				excludeGameAssemblies.Add(@"^Trivial.");
				excludeGameAssemblies.Add(@"^RoslynCSharp.");
				// Only one to use Roslyn and shouldn't ever be needed
				excludeGameAssemblies.Add(@"^PugMod.Loader");
				excludeGameAssemblies.Add(@"Assembly-CSharp.dll");
				// Included as source
				excludeGameAssemblies.Add("PugMod.SDK.dll");
				// Harmony included in SDK
				excludeGameAssemblies.Add("0Harmony.dll");
				excludeGameAssemblies.Add(@"^MonoMod.");
				// Necessary mod.io dll is included in SDK
				excludeGameAssemblies.Add(@"^modio.");

				// Included in SDK for now
				excludeGameAssemblies.Add("SpriteInstancing.dll");
			}

			if (initializedToVersion < 2)
			{
				includeGameAssemblies.Add("Microsoft.Bcl.AsyncInterfaces.dll");
				includeGameAssemblies.Add("System.Buffers.dll");
				includeGameAssemblies.Add("System.Memory.dll");
				includeGameAssemblies.Add("System.Numerics.Vectors.dll");
				includeGameAssemblies.Add("System.Text.Encodings.dll");
				includeGameAssemblies.Add("System.Text.Json.dll");
				includeGameAssemblies.Add("System.Runtime.CompilerServices.Unsafe.dll");
			}

			initializedToVersion = CURRENT_VERSION;
		
			EditorUtility.SetDirty(this);
			AssetDatabase.SaveAssets();
		}
	}
}
