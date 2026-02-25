// Decompiled with JetBrains decompiler
// Type: SadCatStudios.PlayerInput.RewiredInputDebug
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using SadCatStudios.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.PlayerInput;

public class RewiredInputDebug(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_textMesh;
  private static readonly IntPtr NativeFieldInfoPtr_inputActionValues;
  private static readonly IntPtr NativeFieldInfoPtr_stringBuilder;
  private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RewiredInputDebug()
  {
    Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.PlayerInput", nameof (RewiredInputDebug));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr);
    RewiredInputDebug.NativeFieldInfoPtr_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr, nameof (textMesh));
    RewiredInputDebug.NativeFieldInfoPtr_inputActionValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr, nameof (inputActionValues));
    RewiredInputDebug.NativeFieldInfoPtr_stringBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr, nameof (stringBuilder));
    RewiredInputDebug.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr, 100671089);
    RewiredInputDebug.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr, 100671090);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90942, XrefRangeEnd = 90959, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Start()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredInputDebug.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90959, XrefRangeEnd = 90980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewiredInputDebug()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredInputDebug>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredInputDebug.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UIGlyphText textMesh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_textMesh));
      return num == IntPtr.Zero ? (UIGlyphText) null : Il2CppObjectPool.Get<UIGlyphText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_textMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppStructArray<InputAction> inputActionValues
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_inputActionValues));
      return num == IntPtr.Zero ? (Il2CppStructArray<InputAction>) null : Il2CppObjectPool.Get<Il2CppStructArray<InputAction>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_inputActionValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder stringBuilder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_stringBuilder));
      return num == IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RewiredInputDebug.NativeFieldInfoPtr_stringBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
