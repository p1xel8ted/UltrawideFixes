// Decompiled with JetBrains decompiler
// Type: JetBrains.Annotations.UsedImplicitlyAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace JetBrains.Annotations;

public sealed class UsedImplicitlyAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__UseKindFlags_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__TargetFlags_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0;

  static UsedImplicitlyAttribute()
  {
    Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", nameof (UsedImplicitlyAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr);
    UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<UseKindFlags>k__BackingField");
    UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, "<TargetFlags>k__BackingField");
    UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663623);
    UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr, 100663624);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414970, XrefRangeEnd = 414971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UsedImplicitlyAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 414971, XrefRangeEnd = 414972, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UsedImplicitlyAttribute(
    ImplicitUseKindFlags useKindFlags,
    ImplicitUseTargetFlags targetFlags)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UsedImplicitlyAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &useKindFlags;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &targetFlags;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UsedImplicitlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_ImplicitUseKindFlags_ImplicitUseTargetFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ImplicitUseKindFlags _UseKindFlags_k__BackingField
  {
    get
    {
      return *(ImplicitUseKindFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField));
    }
    [param: In] set
    {
      *(ImplicitUseKindFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__UseKindFlags_k__BackingField)) = value;
    }
  }

  public unsafe ImplicitUseTargetFlags _TargetFlags_k__BackingField
  {
    get
    {
      return *(ImplicitUseTargetFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField));
    }
    [param: In] set
    {
      *(ImplicitUseTargetFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UsedImplicitlyAttribute.NativeFieldInfoPtr__TargetFlags_k__BackingField)) = value;
    }
  }

  public ImplicitUseKindFlags UseKindFlags => this._UseKindFlags_k__BackingField;

  public ImplicitUseTargetFlags TargetFlags => this._TargetFlags_k__BackingField;
}
