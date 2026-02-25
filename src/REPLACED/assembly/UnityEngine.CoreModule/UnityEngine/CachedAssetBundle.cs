// Decompiled with JetBrains decompiler
// Type: UnityEngine.CachedAssetBundle
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class CachedAssetBundle : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Name;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Hash;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_hash_Public_get_Hash128_0;

  static CachedAssetBundle()
  {
    Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (CachedAssetBundle));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr);
    CachedAssetBundle.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, nameof (m_Name));
    CachedAssetBundle.NativeFieldInfoPtr_m_Hash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, nameof (m_Hash));
    CachedAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663905);
    CachedAssetBundle.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663906);
    CachedAssetBundle.NativeMethodInfoPtr_get_hash_Public_get_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr, 100663907);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 417503, RefRangeEnd = 417506, XrefRangeStart = 417503, XrefRangeEnd = 417503, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CachedAssetBundle(string name, Hash128 hash)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hash;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr__ctor_Public_Void_String_Hash128_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string name
  {
    [CallerCount(192 /*0xC0*/), CachedScanResults(RefRangeStart = 308003, RefRangeEnd = 308195, XrefRangeStart = 308003, XrefRangeEnd = 308195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    set => this.m_Name = value;
  }

  public unsafe Hash128 hash
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 417506, RefRangeEnd = 417508, XrefRangeStart = 417506, XrefRangeEnd = 417506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CachedAssetBundle.NativeMethodInfoPtr_get_hash_Public_get_Hash128_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Hash128*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Hash = value;
  }

  public CachedAssetBundle(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CachedAssetBundle()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedAssetBundle>.NativeClassPtr))
  {
  }

  public unsafe string m_Name
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Name)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Hash128 m_Hash
  {
    get
    {
      return *(Hash128*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Hash));
    }
    [param: In] set
    {
      *(Hash128*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CachedAssetBundle.NativeFieldInfoPtr_m_Hash)) = value;
    }
  }
}
