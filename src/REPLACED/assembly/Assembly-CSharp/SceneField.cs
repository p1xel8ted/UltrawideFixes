// Decompiled with JetBrains decompiler
// Type: SceneField
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
[Serializable]
public class SceneField(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SceneAsset;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SceneName;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SceneName_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_SceneField_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static SceneField()
  {
    Il2CppClassPointerStore<SceneField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (SceneField));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneField>.NativeClassPtr);
    SceneField.NativeFieldInfoPtr_m_SceneAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneField>.NativeClassPtr, nameof (m_SceneAsset));
    SceneField.NativeFieldInfoPtr_m_SceneName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneField>.NativeClassPtr, nameof (m_SceneName));
    SceneField.NativeMethodInfoPtr_get_SceneName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneField>.NativeClassPtr, 100663726);
    SceneField.NativeMethodInfoPtr_op_Implicit_Public_Static_String_SceneField_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneField>.NativeClassPtr, 100663727);
    SceneField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneField>.NativeClassPtr, 100663728 /*0x060001B0*/);
  }

  public unsafe string SceneName
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneField.NativeMethodInfoPtr_get_SceneName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  [CallerCount(47)]
  [CachedScanResults(RefRangeStart = 22365, RefRangeEnd = 22412, XrefRangeStart = 22365, XrefRangeEnd = 22365, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator string(SceneField sceneField)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneField)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneField.NativeMethodInfoPtr_op_Implicit_Public_Static_String_SceneField_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22412, XrefRangeEnd = 22415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneField()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneField>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UnityEngine.Object m_SceneAsset
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneField.NativeFieldInfoPtr_m_SceneAsset));
      return num == System.IntPtr.Zero ? (UnityEngine.Object) null : Il2CppObjectPool.Get<UnityEngine.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneField.NativeFieldInfoPtr_m_SceneAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe string m_SceneName
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneField.NativeFieldInfoPtr_m_SceneName)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneField.NativeFieldInfoPtr_m_SceneName), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
