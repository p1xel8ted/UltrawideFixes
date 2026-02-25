// Decompiled with JetBrains decompiler
// Type: UnityEngine.Scripting.APIUpdating.MovedFromAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Scripting.APIUpdating;

public class MovedFromAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_data;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static MovedFromAttribute()
  {
    Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Scripting.APIUpdating", nameof (MovedFromAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr);
    MovedFromAttribute.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, nameof (data));
    MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100669203);
    MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr, 100669204);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478647, XrefRangeEnd = 478648, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MovedFromAttribute(
    bool autoUpdateAPI,
    string sourceNamespace = null,
    string sourceAssembly = null,
    string sourceClassName = null)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &autoUpdateAPI;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceNamespace);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceAssembly);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(sourceClassName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478648, XrefRangeEnd = 478649, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MovedFromAttribute(string sourceNamespace)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MovedFromAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(sourceNamespace)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MovedFromAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public MovedFromAttributeData data
  {
    get
    {
      System.IntPtr num = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data);
      return new MovedFromAttributeData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, num));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MovedFromAttribute.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MovedFromAttributeData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public bool AffectsAPIUpdater => throw new System.NotSupportedException("Method unstripping failed");

  public bool IsInDifferentAssembly => throw new System.NotSupportedException("Method unstripping failed");
}
