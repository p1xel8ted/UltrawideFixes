// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.DifficultyManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation;

public class DifficultyManager(System.IntPtr pointer) : LocalSingletonBehaviour<DifficultyManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_CurrentDifficulty;
  private static readonly System.IntPtr NativeFieldInfoPtr_BaseDifficulty;
  private static readonly System.IntPtr NativeFieldInfoPtr_difficultyLevels;
  private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreLoad;
  private static readonly System.IntPtr NativeFieldInfoPtr_knownDifficulties;
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static DifficultyManager()
  {
    Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (DifficultyManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr);
    DifficultyManager.NativeFieldInfoPtr_CurrentDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, nameof (CurrentDifficulty));
    DifficultyManager.NativeFieldInfoPtr_BaseDifficulty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, nameof (BaseDifficulty));
    DifficultyManager.NativeFieldInfoPtr_difficultyLevels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, nameof (difficultyLevels));
    DifficultyManager.NativeFieldInfoPtr_IgnoreLoad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, nameof (IgnoreLoad));
    DifficultyManager.NativeFieldInfoPtr_knownDifficulties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, nameof (knownDifficulties));
    DifficultyManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100671101);
    DifficultyManager.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100671102);
    DifficultyManager.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100671103);
    DifficultyManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr, 100671104);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91001, XrefRangeEnd = 91005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DifficultyManager.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DifficultyManager.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91005, XrefRangeEnd = 91016, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DifficultyManager.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91016, XrefRangeEnd = 91025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DifficultyManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DifficultyManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DifficultyManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe DifficultyLevel CurrentDifficulty
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_CurrentDifficulty));
      return num == System.IntPtr.Zero ? (DifficultyLevel) null : Il2CppObjectPool.Get<DifficultyLevel>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_CurrentDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe DifficultyLevel BaseDifficulty
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_BaseDifficulty));
      return num == System.IntPtr.Zero ? (DifficultyLevel) null : Il2CppObjectPool.Get<DifficultyLevel>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_BaseDifficulty), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<DifficultyLevel> difficultyLevels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_difficultyLevels));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<DifficultyLevel>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<DifficultyLevel>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_difficultyLevels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool IgnoreLoad
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_IgnoreLoad));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_IgnoreLoad)) = value;
    }
  }

  public unsafe Dictionary<string, DifficultyLevel> knownDifficulties
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_knownDifficulties));
      return num == System.IntPtr.Zero ? (Dictionary<string, DifficultyLevel>) null : Il2CppObjectPool.Get<Dictionary<string, DifficultyLevel>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DifficultyManager.NativeFieldInfoPtr_knownDifficulties), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
