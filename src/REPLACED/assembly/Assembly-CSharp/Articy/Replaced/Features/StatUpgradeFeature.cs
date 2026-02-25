// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.StatUpgradeFeature
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Features;

[Serializable]
public class StatUpgradeFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mStatType;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_StatType_Public_get_StatType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_StatType_Public_set_Void_StatType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static StatUpgradeFeature()
  {
    Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (StatUpgradeFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr);
    StatUpgradeFeature.NativeFieldInfoPtr_mStatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, nameof (mStatType));
    StatUpgradeFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, nameof (mOwnerId));
    StatUpgradeFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    StatUpgradeFeature.NativeMethodInfoPtr_get_StatType_Public_get_StatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678983);
    StatUpgradeFeature.NativeMethodInfoPtr_set_StatType_Public_set_Void_StatType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678984);
    StatUpgradeFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678985);
    StatUpgradeFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678986);
    StatUpgradeFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678987);
    StatUpgradeFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678988);
    StatUpgradeFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678989);
    StatUpgradeFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678990);
    StatUpgradeFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678991);
    StatUpgradeFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678992);
    StatUpgradeFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr, 100678993);
  }

  public unsafe StatType StatType
  {
    [CallerCount(12), CachedScanResults(RefRangeStart = 64562, RefRangeEnd = 64574, XrefRangeStart = 64562, XrefRangeEnd = 64574, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_get_StatType_Public_get_StatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(StatType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 139934, RefRangeEnd = 139939, XrefRangeStart = 139922, XrefRangeEnd = 139934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_set_StatType_Public_set_Void_StatType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OwnerId
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 16194, RefRangeEnd = 16222, XrefRangeStart = 16194, XrefRangeEnd = 16222, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 66968, RefRangeEnd = 66976, XrefRangeStart = 66968, XrefRangeEnd = 66976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OwnerInstanceId
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 81031, RefRangeEnd = 81032, XrefRangeStart = 81031, XrefRangeEnd = 81032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139939, XrefRangeEnd = 139942, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139942, XrefRangeEnd = 139949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139949, XrefRangeEnd = 139956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139956, XrefRangeEnd = 139961, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe StatUpgradeFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StatUpgradeFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(StatUpgradeFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe StatType mStatType
  {
    get
    {
      return *(StatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mStatType));
    }
    [param: In] set
    {
      *(StatType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mStatType)) = value;
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(StatUpgradeFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
