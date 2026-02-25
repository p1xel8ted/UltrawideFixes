// Decompiled with JetBrains decompiler
// Type: UnityEngine.WaitForSecondsRealtime
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class WaitForSecondsRealtime(IntPtr pointer) : CustomYieldInstruction(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__waitTime_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_m_WaitUntilTime;
  private static readonly IntPtr NativeMethodInfoPtr_get_waitTime_Public_get_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Virtual_Void_0;

  static WaitForSecondsRealtime()
  {
    Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (WaitForSecondsRealtime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr);
    WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, "<waitTime>k__BackingField");
    WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, nameof (m_WaitUntilTime));
    WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100668443);
    WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100668444);
    WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100668445);
    WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100668446);
    WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr, 100668447);
  }

  public unsafe float waitTime
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_get_waitTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(1), CachedScanResults(RefRangeStart = 136972, RefRangeEnd = 136973, XrefRangeStart = 136972, XrefRangeEnd = 136973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr_set_waitTime_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public override unsafe bool keepWaiting
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464474, XrefRangeEnd = 464478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaitForSecondsRealtime.NativeMethodInfoPtr_get_keepWaiting_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 464479, RefRangeEnd = 464487, XrefRangeStart = 464478, XrefRangeEnd = 464479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe WaitForSecondsRealtime(float time)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitForSecondsRealtime>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &time
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(WaitForSecondsRealtime.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public override unsafe void Reset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WaitForSecondsRealtime.NativeMethodInfoPtr_Reset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float _waitTime_k__BackingField
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr__waitTime_k__BackingField)) = value;
    }
  }

  public unsafe float m_WaitUntilTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WaitForSecondsRealtime.NativeFieldInfoPtr_m_WaitUntilTime)) = value;
    }
  }
}
