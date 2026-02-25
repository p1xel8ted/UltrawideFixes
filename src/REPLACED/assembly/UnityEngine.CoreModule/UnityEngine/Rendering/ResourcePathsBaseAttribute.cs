// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ResourcePathsBaseAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace UnityEngine.Rendering;

public class ResourcePathsBaseAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0;

  static ResourcePathsBaseAttribute()
  {
    Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ResourcePathsBaseAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr);
    ResourcePathsBaseAttribute.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr, 100669706);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ResourcePathsBaseAttribute(
    Il2CppStringArray paths,
    bool isField,
    SearchType location)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourcePathsBaseAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) paths);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &isField;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &location;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ResourcePathsBaseAttribute.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_Boolean_SearchType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public SearchType location
  {
    get
    {
      Debug.LogWarning((Il2CppSystem.Object) "ResourcePathsBaseAttribute.location cannot be reliable at runtime as data is not stored.");
      return SearchType.ProjectPath;
    }
  }

  public Il2CppStringArray paths
  {
    get
    {
      Debug.LogWarning((Il2CppSystem.Object) "ResourcePathsBaseAttribute.paths cannot be reliable at runtime as data is not stored.");
      return (Il2CppStringArray) null;
    }
  }

  public bool isField
  {
    get
    {
      Debug.LogWarning((Il2CppSystem.Object) "ResourcePathsBaseAttribute.isField cannot be reliable at runtime as data is not stored.");
      return false;
    }
  }
}
