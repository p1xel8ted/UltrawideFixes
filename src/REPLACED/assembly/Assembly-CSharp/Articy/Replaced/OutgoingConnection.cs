// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.OutgoingConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class OutgoingConnection(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mLabel;
  private static readonly System.IntPtr NativeFieldInfoPtr_mColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTargetPin;
  private static readonly System.IntPtr NativeFieldInfoPtr_mTarget;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Label_Public_get_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Label_Public_set_Void_ArticyString_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_TargetPin_Public_Virtual_Final_New_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_TargetPin_Public_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Target_Public_Virtual_Final_New_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Target_Public_Virtual_Final_New_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OutgoingConnection()
  {
    Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (OutgoingConnection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr);
    OutgoingConnection.NativeFieldInfoPtr_mLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, nameof (mLabel));
    OutgoingConnection.NativeFieldInfoPtr_mColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, nameof (mColor));
    OutgoingConnection.NativeFieldInfoPtr_mTargetPin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, nameof (mTargetPin));
    OutgoingConnection.NativeFieldInfoPtr_mTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, nameof (mTarget));
    OutgoingConnection.NativeMethodInfoPtr_get_Label_Public_get_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678436);
    OutgoingConnection.NativeMethodInfoPtr_set_Label_Public_set_Void_ArticyString_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678437);
    OutgoingConnection.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678438);
    OutgoingConnection.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678439);
    OutgoingConnection.NativeMethodInfoPtr_get_TargetPin_Public_Virtual_Final_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678440);
    OutgoingConnection.NativeMethodInfoPtr_set_TargetPin_Public_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678441);
    OutgoingConnection.NativeMethodInfoPtr_get_Target_Public_Virtual_Final_New_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678442);
    OutgoingConnection.NativeMethodInfoPtr_set_Target_Public_Virtual_Final_New_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678443);
    OutgoingConnection.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678444);
    OutgoingConnection.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678445);
    OutgoingConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr, 100678446);
  }

  public unsafe ArticyString Label
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 136200, RefRangeEnd = 136213, XrefRangeStart = 136200, XrefRangeEnd = 136213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_get_Label_Public_get_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyString) null : Il2CppObjectPool.Get<ArticyString>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_set_Label_Public_set_Void_ArticyString_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe Color Color
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_get_Color_Public_Virtual_Final_New_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_set_Color_Public_Virtual_Final_New_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ulong TargetPin
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_get_TargetPin_Public_Virtual_Final_New_get_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_set_TargetPin_Public_set_Void_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyObject Target
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_get_Target_Public_Virtual_Final_New_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_set_Target_Public_Virtual_Final_New_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 137086, RefRangeEnd = 137087, XrefRangeStart = 137075, XrefRangeEnd = 137086, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_CloneProperties_Private_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 137100, RefRangeEnd = 137102, XrefRangeStart = 137087, XrefRangeEnd = 137100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr_CloneObject_Public_Virtual_Final_New_Object_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137102, XrefRangeEnd = 137111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OutgoingConnection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutgoingConnection>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OutgoingConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyString mLabel
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mLabel));
      return num == System.IntPtr.Zero ? (ArticyValueArticyString) null : Il2CppObjectPool.Get<ArticyValueArticyString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mLabel), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Color mColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mColor)) = value;
    }
  }

  public unsafe ulong mTargetPin
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mTargetPin));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mTargetPin)) = value;
    }
  }

  public unsafe ArticyValueArticyObject mTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mTarget));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OutgoingConnection.NativeFieldInfoPtr_mTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
