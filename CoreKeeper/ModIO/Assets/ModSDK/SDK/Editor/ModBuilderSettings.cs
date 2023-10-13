using System;
using System.Collections.Generic;
using PugMod;
using UnityEngine;

public class ModBuilderSettings : ScriptableObject
{
	public ModMetadata metadata = new ModMetadata
	{
		guid = Guid.NewGuid().ToString("N"),
		name = "MyMod",
	};
	
	public string modPath = "Assets/Mod";
}