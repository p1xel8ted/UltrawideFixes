// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CharacterCutsceneMoveController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Character;

public class CharacterCutsceneMoveController(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_walkController;
  private static readonly System.IntPtr NativeFieldInfoPtr_rotationController;
  private static readonly System.IntPtr NativeFieldInfoPtr_active;
  private static readonly System.IntPtr NativeFieldInfoPtr_currentMove;
  private static readonly System.IntPtr NativeFieldInfoPtr_arrivalCallback;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToPoint_Public_Void_ICutsceneMove_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CharacterCutsceneMoveController()
  {
    Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CharacterCutsceneMoveController));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr);
    CharacterCutsceneMoveController.NativeFieldInfoPtr_walkController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, nameof (walkController));
    CharacterCutsceneMoveController.NativeFieldInfoPtr_rotationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, nameof (rotationController));
    CharacterCutsceneMoveController.NativeFieldInfoPtr_active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, nameof (active));
    CharacterCutsceneMoveController.NativeFieldInfoPtr_currentMove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, nameof (currentMove));
    CharacterCutsceneMoveController.NativeFieldInfoPtr_arrivalCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, nameof (arrivalCallback));
    CharacterCutsceneMoveController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, 100674955);
    CharacterCutsceneMoveController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, 100674956);
    CharacterCutsceneMoveController.NativeMethodInfoPtr_MoveToPoint_Public_Void_ICutsceneMove_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, 100674957);
    CharacterCutsceneMoveController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr, 100674958);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114376, XrefRangeEnd = 114382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCutsceneMoveController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114382, XrefRangeEnd = 114386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void FixedUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCutsceneMoveController.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 114386, RefRangeEnd = 114388, XrefRangeStart = 114386, XrefRangeEnd = 114386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToPoint(ICutsceneMove cutsceneMove, Il2CppSystem.Action arrivalCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cutsceneMove);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arrivalCallback);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCutsceneMoveController.NativeMethodInfoPtr_MoveToPoint_Public_Void_ICutsceneMove_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CharacterCutsceneMoveController()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCutsceneMoveController>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CharacterCutsceneMoveController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe CharacterWalkController walkController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_walkController));
      return num == System.IntPtr.Zero ? (CharacterWalkController) null : Il2CppObjectPool.Get<CharacterWalkController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_walkController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterRotationController rotationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_rotationController));
      return num == System.IntPtr.Zero ? (CharacterRotationController) null : Il2CppObjectPool.Get<CharacterRotationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_rotationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool active
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_active));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_active)) = value;
    }
  }

  public unsafe ICutsceneMove currentMove
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_currentMove));
      return num == System.IntPtr.Zero ? (ICutsceneMove) null : Il2CppObjectPool.Get<ICutsceneMove>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_currentMove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Action arrivalCallback
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_arrivalCallback));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Action) null : Il2CppObjectPool.Get<Il2CppSystem.Action>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterCutsceneMoveController.NativeFieldInfoPtr_arrivalCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
