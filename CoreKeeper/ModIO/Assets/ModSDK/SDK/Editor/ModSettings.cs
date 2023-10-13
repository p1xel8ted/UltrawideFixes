using ModIO;
using UnityEngine;

namespace PugMod.ModIO
{
	public class ModSettings : ScriptableObject
	{
		public long modId;
		public ModBuilderSettings modSettings;
		public Texture2D logo;
		public string summary;
	}
}