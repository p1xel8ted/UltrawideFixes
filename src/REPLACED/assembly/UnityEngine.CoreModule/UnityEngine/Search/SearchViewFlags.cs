// Decompiled with JetBrains decompiler
// Type: UnityEngine.Search.SearchViewFlags
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

#nullable disable
namespace UnityEngine.Search;

public enum SearchViewFlags
{
  None = 0,
  Debug = 16, // 0x00000010
  NoIndexing = 32, // 0x00000020
  Packages = 256, // 0x00000100
  OpenLeftSidePanel = 2048, // 0x00000800
  OpenInspectorPreview = 4096, // 0x00001000
  Centered = 8192, // 0x00002000
  HideSearchBar = 16384, // 0x00004000
  CompactView = 32768, // 0x00008000
  ListView = 65536, // 0x00010000
  GridView = 131072, // 0x00020000
  TableView = 262144, // 0x00040000
  EnableSearchQuery = 524288, // 0x00080000
  DisableInspectorPreview = 1048576, // 0x00100000
  DisableSavedSearchQuery = 2097152, // 0x00200000
  OpenInBuilderMode = 4194304, // 0x00400000
  OpenInTextMode = 8388608, // 0x00800000
  DisableBuilderModeToggle = 16777216, // 0x01000000
  Borderless = 33554432, // 0x02000000
  ContextSwitchPreservedMask = 33560576, // 0x02001800
  DisableQueryHelpers = 67108864, // 0x04000000
  DisableNoResultTips = 134217728, // 0x08000000
  IgnoreSavedSearches = 268435456, // 0x10000000
  ObjectPicker = 536870912, // 0x20000000
  ObjectPickerAdvancedUI = 1073741824, // 0x40000000
}
