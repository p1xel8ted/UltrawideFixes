using System.Collections.Generic;
using System.IO;
using SpriteInstancing;
using UnityEditor;
using UnityEngine;
using UnityEngine.Scripting;

public class SpriteInstancingModBuilder : PugMod.IPugModBuilderProcessor
{
	[Preserve]
	public void Execute(ModBuilderSettings modBuilderSettings, string installDirectory, List<string> assetPaths)
	{
		List<SpriteAssetBase> spriteAssets = new();
		List<Texture2D> gradientMaps = new();
		List<TransformAnimation> transformAnimations = new();

		foreach (var path in assetPaths)
		{
			var asset = AssetDatabase.LoadAssetAtPath<Object>(path);

			if (asset is SpriteAssetBase spriteAssetBase)
			{
				spriteAssets.Add(spriteAssetBase);
				continue;
			}

			if (asset is Texture2D texture2D && path.StartsWith("gm_"))
			{
				gradientMaps.Add(texture2D);
				continue;
			}

			if (asset is TransformAnimation transformAnimation)
			{
				transformAnimations.Add(transformAnimation);
			}
		}

		if (spriteAssets.Count + gradientMaps.Count + transformAnimations.Count == 0)
		{
			return;
		}

		var manifestPath = Path.Combine(modBuilderSettings.modPath, "SpriteAssetManifest.asset");
		SpriteAssetManifest manifest = AssetDatabase.LoadAssetAtPath<SpriteAssetManifest>(manifestPath);
		if (manifest == null)
		{
			manifest = ScriptableObject.CreateInstance<SpriteAssetManifest>();
			AssetDatabase.CreateAsset(manifest, manifestPath);
		}

		manifest.spriteAssets = spriteAssets;
		manifest.gradientMaps = gradientMaps;
		manifest.transformAnimations = transformAnimations;
		
		EditorUtility.SetDirty(manifest);
		AssetDatabase.SaveAssetIfDirty(manifest);
	}
}
