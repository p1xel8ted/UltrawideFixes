// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.AttackWeight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.AI;

[Serializable]
public class AttackWeight(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_weight;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldown;
  private static readonly System.IntPtr NativeFieldInfoPtr_mute;
  private static readonly System.IntPtr NativeFieldInfoPtr_cooldownTimer;
  private static readonly System.IntPtr NativeFieldInfoPtr_weightMultiplier;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Weight_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Cooldown_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Mute_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StartCooldown_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UpdateCooldown_Public_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HalfWeight_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResetWeight_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AttackWeight()
  {
    Il2CppClassPointerStore<AttackWeight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (AttackWeight));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr);
    AttackWeight.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, nameof (weight));
    AttackWeight.NativeFieldInfoPtr_cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, nameof (cooldown));
    AttackWeight.NativeFieldInfoPtr_mute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, nameof (mute));
    AttackWeight.NativeFieldInfoPtr_cooldownTimer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, nameof (cooldownTimer));
    AttackWeight.NativeFieldInfoPtr_weightMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, nameof (weightMultiplier));
    AttackWeight.NativeMethodInfoPtr_get_Weight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677854);
    AttackWeight.NativeMethodInfoPtr_get_Cooldown_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677855);
    AttackWeight.NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677856);
    AttackWeight.NativeMethodInfoPtr_get_Mute_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677857);
    AttackWeight.NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677858);
    AttackWeight.NativeMethodInfoPtr_StartCooldown_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677859);
    AttackWeight.NativeMethodInfoPtr_UpdateCooldown_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677860);
    AttackWeight.NativeMethodInfoPtr_HalfWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677861);
    AttackWeight.NativeMethodInfoPtr_ResetWeight_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677862);
    AttackWeight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr, 100677863);
  }

  public unsafe float Weight
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_get_Weight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe float Cooldown
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_get_Cooldown_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool Mute
  {
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_set_Mute_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 64585, RefRangeEnd = 64591, XrefRangeStart = 64585, XrefRangeEnd = 64591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_get_Mute_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsReady
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 132231, RefRangeEnd = 132232, XrefRangeStart = 132231, XrefRangeEnd = 132231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_get_IsReady_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe void StartCooldown()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_StartCooldown_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void UpdateCooldown(float deltaTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &deltaTime
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_UpdateCooldown_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void HalfWeight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_HalfWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public unsafe void ResetWeight()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr_ResetWeight_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132232, XrefRangeEnd = 132233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttackWeight()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttackWeight>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttackWeight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int weight
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_weight));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_weight)) = value;
    }
  }

  public unsafe float cooldown
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_cooldown));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_cooldown)) = value;
    }
  }

  public unsafe bool mute
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_mute));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_mute)) = value;
    }
  }

  public unsafe float cooldownTimer
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_cooldownTimer));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_cooldownTimer)) = value;
    }
  }

  public unsafe float weightMultiplier
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_weightMultiplier));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AttackWeight.NativeFieldInfoPtr_weightMultiplier)) = value;
    }
  }
}
