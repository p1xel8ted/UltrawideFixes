using System;
using System.Collections.Generic;
using UnityEngine;

namespace PugMod
{
	public static class Constants
	{
		public const string MOD_MANIFEST_FILE = "ModManifest.json";
	}

	[Serializable]
	public struct ModMetadata
	{
		public string guid;
		public string name;
		public bool skipSafetyChecks;
		public bool accessesExtraAssemblies;
		public bool disableHarmonyPatching;
		public ModExistsOn requiredOn;
		public List<ModFile> files;
		public List<Dependency> dependencies;

		[Flags]
		public enum ModExistsOn
		{
			None, Client = 1, Server = 2, ClientAndServer = 3,
		}

		[Serializable]
		public struct Dependency
		{
			public string modName;
			public bool required;
		}
	}

	[Serializable]
	public struct ModFile
	{
		public string path;
	}
}