// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Combat.CharacterGrabRaycaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using GameVariables;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Character;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Combat;

public class CharacterGrabRaycaster(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_scanOrigin;
  private static readonly System.IntPtr NativeFieldInfoPtr_scanDistance;
  private static readonly System.IntPtr NativeFieldInfoPtr_layerMask;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Raycast_Private_Boolean_Vector3_Vector3_Action_1_GrabCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_Action_1_GrabCastResult_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterGrabRaycaster()
  {
    Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Combat", nameof (CharacterGrabRaycaster));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr);
    CharacterGrabRaycaster.NativeFieldInfoPtr_scanOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, nameof (scanOrigin));
    CharacterGrabRaycaster.NativeFieldInfoPtr_scanDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, nameof (scanDistance));
    CharacterGrabRaycaster.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, nameof (layerMask));
    CharacterGrabRaycaster.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, nameof (rotationController));
    CharacterGrabRaycaster.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, 100677166);
    CharacterGrabRaycaster.NativeMethodInfoPtr_Raycast_Private_Boolean_Vector3_Vector3_Action_1_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, 100677167);
    CharacterGrabRaycaster.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_Action_1_GrabCastResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, 100677168);
    CharacterGrabRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr, 100677169);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128477, XrefRangeEnd = 128480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabRaycaster.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 128501, RefRangeEnd = 128502, XrefRangeStart = 128480, XrefRangeEnd = 128501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Raycast(Vector3 origin, Vector3 dir, Il2CppSystem.Action<GrabCastResult> counterCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &origin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dir;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) counterCallback);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CharacterGrabRaycaster.NativeMethodInfoPtr_Raycast_Private_Boolean_Vector3_Vector3_Action_1_GrabCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128502, XrefRangeEnd = 128509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void CastGrab(Il2CppSystem.Action<GrabCastResult> grabCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) grabCallback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabRaycaster.NativeMethodInfoPtr_CastGrab_Public_Virtual_Final_New_Void_Action_1_GrabCastResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128509, XrefRangeEnd = 128510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterGrabRaycaster()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterGrabRaycaster>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterGrabRaycaster.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Vector3 scanOrigin
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_scanOrigin));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_scanOrigin)) = value;
    }
  }

  public unsafe FloatReference scanDistance
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_scanDistance));
      return num == System.IntPtr.Zero ? (FloatReference) null : Il2CppObjectPool.Get<FloatReference>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_scanDistance), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe LayerMask layerMask
  {
    get
    {
      return *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_layerMask));
    }
    [param: In] set
    {
      *(LayerMask*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_layerMask)) = value;
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterGrabRaycaster.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
