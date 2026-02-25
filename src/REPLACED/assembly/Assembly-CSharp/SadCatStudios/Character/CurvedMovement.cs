// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Character.CurvedMovement
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

public sealed class CurvedMovement : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_timer;
  private static readonly System.IntPtr NativeFieldInfoPtr_duration;
  private static readonly System.IntPtr NativeFieldInfoPtr_startPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_targetPoint;
  private static readonly System.IntPtr NativeFieldInfoPtr_motionCurve;
  private static readonly System.IntPtr NativeFieldInfoPtr_animationController;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GuidReference_Vector3_Vector3_Single_AnimationCurve_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0;

  static CurvedMovement()
  {
    Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Character", nameof (CurvedMovement));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr);
    CurvedMovement.NativeFieldInfoPtr_timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (timer));
    CurvedMovement.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (duration));
    CurvedMovement.NativeFieldInfoPtr_startPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (startPoint));
    CurvedMovement.NativeFieldInfoPtr_targetPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (targetPoint));
    CurvedMovement.NativeFieldInfoPtr_motionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (motionCurve));
    CurvedMovement.NativeFieldInfoPtr_animationController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, nameof (animationController));
    CurvedMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_Vector3_Vector3_Single_AnimationCurve_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, 100674964);
    CurvedMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, 100674965);
    CurvedMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr, 100674966);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 114408, RefRangeEnd = 114409, XrefRangeStart = 114405, XrefRangeEnd = 114408, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CurvedMovement(
    GuidReference actor,
    Vector3 startPoint,
    Vector3 targetPoint,
    float duration,
    AnimationCurve motionCurve)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) actor);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &startPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &targetPoint;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) motionCurve);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedMovement.NativeMethodInfoPtr__ctor_Public_Void_GuidReference_Vector3_Vector3_Single_AnimationCurve_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114409, XrefRangeEnd = 114411, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool IsAtPoint()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CurvedMovement.NativeMethodInfoPtr_IsAtPoint_Public_Virtual_Final_New_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 114411, XrefRangeEnd = 114416, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Move()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CurvedMovement.NativeMethodInfoPtr_Move_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public CurvedMovement(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public CurvedMovement()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CurvedMovement>.NativeClassPtr))
  {
  }

  public unsafe float timer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_timer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_timer)) = value;
    }
  }

  public unsafe float duration
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_duration));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_duration)) = value;
    }
  }

  public unsafe Vector3 startPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_startPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_startPoint)) = value;
    }
  }

  public unsafe Vector3 targetPoint
  {
    get
    {
      return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_targetPoint));
    }
    [param: In] set
    {
      *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_targetPoint)) = value;
    }
  }

  public unsafe AnimationCurve motionCurve
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_motionCurve));
      return num == System.IntPtr.Zero ? (AnimationCurve) null : Il2CppObjectPool.Get<AnimationCurve>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_motionCurve), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe CharacterAnimationController animationController
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_animationController));
      return num == System.IntPtr.Zero ? (CharacterAnimationController) null : Il2CppObjectPool.Get<CharacterAnimationController>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CurvedMovement.NativeFieldInfoPtr_animationController), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
