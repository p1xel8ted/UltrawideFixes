// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Features.PromtFeature
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
public class PromtFeature(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mDescriptionText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mCounterText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mSmallText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerId;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwnerInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DescriptionText_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_CounterText_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_CounterText_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SmallText_Public_get_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_SmallText_Public_set_Void_ArticyMultiLanguageString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PromtFeature()
  {
    Il2CppClassPointerStore<PromtFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Features", nameof (PromtFeature));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr);
    PromtFeature.NativeFieldInfoPtr_mDescriptionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, nameof (mDescriptionText));
    PromtFeature.NativeFieldInfoPtr_mCounterText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, nameof (mCounterText));
    PromtFeature.NativeFieldInfoPtr_mSmallText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, nameof (mSmallText));
    PromtFeature.NativeFieldInfoPtr_mOwnerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, nameof (mOwnerId));
    PromtFeature.NativeFieldInfoPtr_mOwnerInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, nameof (mOwnerInstanceId));
    PromtFeature.NativeMethodInfoPtr_get_DescriptionText_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678940);
    PromtFeature.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678941);
    PromtFeature.NativeMethodInfoPtr_get_CounterText_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678942);
    PromtFeature.NativeMethodInfoPtr_set_CounterText_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678943);
    PromtFeature.NativeMethodInfoPtr_get_SmallText_Public_get_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678944);
    PromtFeature.NativeMethodInfoPtr_set_SmallText_Public_set_Void_ArticyMultiLanguageString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678945);
    PromtFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678946);
    PromtFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678947);
    PromtFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678948);
    PromtFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678949);
    PromtFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678950);
    PromtFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678951);
    PromtFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678952);
    PromtFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678953);
    PromtFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr, 100678954);
  }

  public unsafe ArticyMultiLanguageString DescriptionText
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 136200, RefRangeEnd = 136213, XrefRangeStart = 136200, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_get_DescriptionText_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_set_DescriptionText_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString CounterText
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 138599, RefRangeEnd = 138608, XrefRangeStart = 138599, XrefRangeEnd = 138608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_get_CounterText_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_set_CounterText_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ArticyMultiLanguageString SmallText
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 138696, RefRangeEnd = 138701, XrefRangeStart = 138696, XrefRangeEnd = 138701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_get_SmallText_Public_get_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyMultiLanguageString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_set_SmallText_Public_set_Void_ArticyMultiLanguageString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ulong OwnerId
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_get_OwnerId_Public_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 65551 /*0x01000F*/, RefRangeEnd = 65553, XrefRangeStart = 65551 /*0x01000F*/, XrefRangeEnd = 65553, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_set_OwnerId_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe uint OwnerInstanceId
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 16661, RefRangeEnd = 16662, XrefRangeStart = 16661, XrefRangeEnd = 16662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_get_OwnerInstanceId_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 73046, RefRangeEnd = 73047, XrefRangeStart = 73046, XrefRangeEnd = 73047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_set_OwnerInstanceId_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139722, RefRangeEnd = 139723, XrefRangeStart = 139706, XrefRangeEnd = 139722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139738, RefRangeEnd = 139739, XrefRangeStart = 139723, XrefRangeEnd = 139738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139754, RefRangeEnd = 139755, XrefRangeStart = 139739, XrefRangeEnd = 139754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void setProp(string aProperty, Il2CppSystem.Object aValue)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aProperty);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aValue);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_setProp_Public_Virtual_Final_New_Void_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 139765, RefRangeEnd = 139766, XrefRangeStart = 139755, XrefRangeEnd = 139765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe ScriptDataProxy getProp(string aProperty)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(aProperty)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr_getProp_Public_Virtual_Final_New_ScriptDataProxy_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 139766, XrefRangeEnd = 139777, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PromtFeature()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PromtFeature>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PromtFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyMultiLanguageString mDescriptionText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mDescriptionText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mDescriptionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mCounterText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mCounterText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mCounterText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyMultiLanguageString mSmallText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mSmallText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyMultiLanguageString) null : Il2CppObjectPool.Get<ArticyValueArticyMultiLanguageString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mSmallText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ulong mOwnerId
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mOwnerId));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mOwnerId)) = value;
    }
  }

  public unsafe uint mOwnerInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mOwnerInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PromtFeature.NativeFieldInfoPtr_mOwnerInstanceId)) = value;
    }
  }
}
