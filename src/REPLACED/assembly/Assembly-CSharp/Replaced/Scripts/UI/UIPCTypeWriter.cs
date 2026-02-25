// Decompiled with JetBrains decompiler
// Type: Replaced.Scripts.UI.UIPCTypeWriter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Replaced.Scripts.UI;

public class UIPCTypeWriter(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_delayBetweenLines;
  private static readonly IntPtr NativeFieldInfoPtr_textMesh;
  private static readonly IntPtr NativeFieldInfoPtr_skipAfterLines;
  private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Print_Public_Boolean_byref_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetText_Public_Void_String_0;
  private static readonly IntPtr NativeMethodInfoPtr_Skip_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIPCTypeWriter()
  {
    Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Replaced.Scripts.UI", nameof (UIPCTypeWriter));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr);
    UIPCTypeWriter.NativeFieldInfoPtr_delayBetweenLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, nameof (delayBetweenLines));
    UIPCTypeWriter.NativeFieldInfoPtr_textMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, nameof (textMesh));
    UIPCTypeWriter.NativeFieldInfoPtr_skipAfterLines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, nameof (skipAfterLines));
    UIPCTypeWriter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, 100670719);
    UIPCTypeWriter.NativeMethodInfoPtr_Print_Public_Boolean_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, 100670720 /*0x06001D00*/);
    UIPCTypeWriter.NativeMethodInfoPtr_SetText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, 100670721);
    UIPCTypeWriter.NativeMethodInfoPtr_Skip_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, 100670722);
    UIPCTypeWriter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr, 100670723);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87778, XrefRangeEnd = 87781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPCTypeWriter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87797, RefRangeEnd = 87798, XrefRangeStart = 87781, XrefRangeEnd = 87797, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Print(ref float time)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) ref time
    };
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIPCTypeWriter.NativeMethodInfoPtr_Print_Public_Boolean_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87798, XrefRangeEnd = 87800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetText(string textContent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(textContent)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPCTypeWriter.NativeMethodInfoPtr_SetText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 87803, RefRangeEnd = 87804, XrefRangeStart = 87800, XrefRangeEnd = 87803, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Skip()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPCTypeWriter.NativeMethodInfoPtr_Skip_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87804, XrefRangeEnd = 87805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIPCTypeWriter()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIPCTypeWriter>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIPCTypeWriter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float delayBetweenLines
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_delayBetweenLines));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_delayBetweenLines)) = value;
    }
  }

  public unsafe TextMeshProUGUI textMesh
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_textMesh));
      return num == IntPtr.Zero ? (TextMeshProUGUI) null : Il2CppObjectPool.Get<TextMeshProUGUI>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_textMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int skipAfterLines
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_skipAfterLines));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIPCTypeWriter.NativeFieldInfoPtr_skipAfterLines)) = value;
    }
  }
}
