// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CheatsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CheatsManager(IntPtr pointer) : LocalSingletonBehaviour<CheatsManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_player;
  private static readonly IntPtr NativeFieldInfoPtr_toggleableGameObject;
  private static readonly IntPtr NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Vector2_0;
  private static readonly IntPtr NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CheatsManager()
  {
    Il2CppClassPointerStore<CheatsManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CheatsManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr);
    CheatsManager.NativeFieldInfoPtr_player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr, nameof (player));
    CheatsManager.NativeFieldInfoPtr_toggleableGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr, nameof (toggleableGameObject));
    CheatsManager.NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr, 100677816);
    CheatsManager.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr, 100677817);
    CheatsManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr, 100677818);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131669, XrefRangeEnd = 131673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ShowPrompt(string text, Vector2 offset)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &offset;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CheatsManager.NativeMethodInfoPtr_ShowPrompt_Public_Void_String_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131673, XrefRangeEnd = 131676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Vector3 PlayerPosition()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CheatsManager.NativeMethodInfoPtr_PlayerPosition_Public_Virtual_Final_New_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131676, XrefRangeEnd = 131679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CheatsManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CheatsManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CheatsManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe GuidReference player
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheatsManager.NativeFieldInfoPtr_player));
      return num == IntPtr.Zero ? (GuidReference) null : Il2CppObjectPool.Get<GuidReference>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CheatsManager.NativeFieldInfoPtr_player), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject toggleableGameObject
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CheatsManager.NativeFieldInfoPtr_toggleableGameObject));
      return num == IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CheatsManager.NativeFieldInfoPtr_toggleableGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
