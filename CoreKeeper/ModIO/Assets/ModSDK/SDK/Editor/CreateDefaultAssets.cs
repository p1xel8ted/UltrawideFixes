using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace PugMod
{
	public static class AssetInitializer
	{
		public static IEnumerable<(string, string)> JsonFilesToExport = new ExportEnumerable();

		private static List<AssetSetup> _assetSetups;

		static AssetInitializer()
		{
			_assetSetups = new List<AssetSetup>
			{
				new(
					"ConditionsTable",
					"Assets/Resources/ConditionsTable.asset",
					"Assets/Resources/ConditionsTable.asset",
					"Assets/ModSDK/Data/ConditionsTable.json"
				),
				new(
					"SpriteInstancing.SpriteAssetManifest",
					"Assets/Scripts/Rendering/SpriteInstancing/Resources/SpriteAssetManifest.asset",
					"Assets/Resources/SpriteAssetManifest.asset",
					"Assets/ModSDK/Data/SpriteAssetManifest.json"
				),
				//new(
				//	"PugRP.PugRenderPipelineAsset",
				//	"Assets/PugRP/PugRP.asset",
				//	"Assets/Settings/PugRP.asset",
				//	"Assets/ModSDK/Data/PugRP.json"
				//),
				// Add more setups here
			};
		}

#if PUG_MOD_SDK
		[InitializeOnLoadMethod]
#endif
		private static void Init()
		{
			foreach (var setup in _assetSetups)
			{
				ProcessAssetSetup(setup);
			}
		}

		private static void ProcessAssetSetup(AssetSetup setup)
		{
			if (!HasType(setup.TypeName, out Type type))
			{
				return;
			}

			if (AssetDatabase.LoadAssetAtPath<Object>(setup.AssetPathInSDK) != null)
			{
				return;
			}

			var serializedDataAsset = AssetDatabase.LoadAssetAtPath<TextAsset>(setup.DataPath);
			if (serializedDataAsset == null)
			{
				Debug.Log($"{setup.DataPath} not found");
				return;
			}

			ScriptableObject scriptableObject = ScriptableObject.CreateInstance(type);
			string jsonData = serializedDataAsset.text;
			JsonUtility.FromJsonOverwrite(jsonData, scriptableObject);

			var fileInfo = new FileInfo(setup.AssetPathInSDK);
			if (fileInfo.Directory is { Exists: false })
			{
				fileInfo.Directory.Create();
			}
			AssetDatabase.CreateAsset(scriptableObject, setup.AssetPathInSDK);

			Debug.Log($"Created {setup.AssetPathInSDK}");
		}

		private static bool HasType(string typeName, out Type type)
		{
			foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
			{
				type = assembly.GetType(typeName);
				if (type != null)
				{
					return true;
				}
			}

			type = null;
			return false;
		}

		private static string GetJson(AssetSetup setup)
		{
			var asset = AssetDatabase.LoadAssetAtPath<Object>(setup.AssetPath);
			if (asset == null)
			{
				Debug.LogError($"no asset at {setup.AssetPath}");
				return null;
			}

			return JsonUtility.ToJson(asset, true);
		}

		private class AssetSetup
		{
			public string TypeName { get; }
			public string AssetPath { get; }
			public string AssetPathInSDK { get; }
			public string DataPath { get; }

			public AssetSetup(string typeName, string assetPath, string assetPathInSDK, string dataPath)
			{
				TypeName = typeName;
				AssetPath = assetPath;
				AssetPathInSDK = assetPathInSDK;
				DataPath = dataPath;
			}
		}
		
		private class ExportEnumerable : IEnumerable<(string, string)>
		{
			public IEnumerator<(string, string)> GetEnumerator() => new ExportEnumerator(_assetSetups);
			IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
		}
		
		private class ExportEnumerator : IEnumerator<(string, string)>
		{
			private List<AssetSetup> _assetSetups;
			private int _index = -1; // Start at -1 so the first call to MoveNext() points to the first item
    
			public ExportEnumerator(List<AssetSetup> assetSetups)
			{
				_assetSetups = assetSetups ?? throw new ArgumentNullException(nameof(assetSetups));
			}

			public bool MoveNext()
			{
				_index++;
				return _index < _assetSetups.Count;
			}

			public void Reset()
			{
				_index = -1;
			}

			public (string, string) Current
			{
				get
				{
					if (_index < 0 || _index >= _assetSetups.Count)
						throw new InvalidOperationException();

					return (_assetSetups[_index].DataPath, GetJson(_assetSetups[_index]));
				}
			}

			object IEnumerator.Current => Current;

			public void Dispose()
			{
				_assetSetups = null;
			}
		}
	}
}