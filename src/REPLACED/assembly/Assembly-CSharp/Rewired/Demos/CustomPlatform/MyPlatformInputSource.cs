// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformInputSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Rewired.Platforms.Custom;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public sealed class MyPlatformInputSource(IntPtr pointer) : CustomPlatformInputSource(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__joystickInputSource;
  private static readonly IntPtr NativeFieldInfoPtr__initialized;
  private static readonly IntPtr NativeFieldInfoPtr__disposed;
  private static readonly IntPtr NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CustomPlatformConfigVars_0;
  private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_MonitorDeviceChanges_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainsJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0;
  private static readonly IntPtr NativeMethodInfoPtr_ContainsSystemJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0;

  static MyPlatformInputSource()
  {
    Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformInputSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr);
    MyPlatformInputSource.NativeFieldInfoPtr__joystickInputSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, nameof (_joystickInputSource));
    MyPlatformInputSource.NativeFieldInfoPtr__initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, nameof (_initialized));
    MyPlatformInputSource.NativeFieldInfoPtr__disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, nameof (_disposed));
    MyPlatformInputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670534);
    MyPlatformInputSource.NativeMethodInfoPtr__ctor_Public_Void_CustomPlatformConfigVars_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670535);
    MyPlatformInputSource.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670536);
    MyPlatformInputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670537);
    MyPlatformInputSource.NativeMethodInfoPtr_MonitorDeviceChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670538);
    MyPlatformInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670539);
    MyPlatformInputSource.NativeMethodInfoPtr_ContainsJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670540);
    MyPlatformInputSource.NativeMethodInfoPtr_ContainsSystemJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, 100670541);
  }

  public override unsafe bool isReady
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_get_isReady_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85819, XrefRangeEnd = 85853, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformInputSource(CustomPlatformConfigVars configVars)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) configVars)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr__ctor_Public_Void_CustomPlatformConfigVars_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85853, XrefRangeEnd = 85855, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnInitialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85855, XrefRangeEnd = 85867, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_Update_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 85912, RefRangeEnd = 85914, XrefRangeStart = 85867, XrefRangeEnd = 85912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MonitorDeviceChanges()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_MonitorDeviceChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85914, XrefRangeEnd = 85915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Dispose(bool disposing)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &disposing
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85915, XrefRangeEnd = 85924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ContainsJoystickBySystemId(
    IList<CustomInputSource.Joystick> joysticks,
    long systemId)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) joysticks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &systemId;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_ContainsJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85924, XrefRangeEnd = 85931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool ContainsSystemJoystickBySystemId(
    IList<UnityInputJoystickSource.Joystick> systemJoysticks,
    long systemId)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemJoysticks);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &systemId;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.NativeMethodInfoPtr_ContainsSystemJoystickBySystemId_Private_Static_Boolean_IList_1_Joystick_Int64_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe UnityInputJoystickSource _joystickInputSource
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__joystickInputSource));
      return num == IntPtr.Zero ? (UnityInputJoystickSource) null : Il2CppObjectPool.Get<UnityInputJoystickSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__joystickInputSource), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _initialized
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__initialized));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__initialized)) = value;
    }
  }

  public unsafe bool _disposed
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__disposed));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.NativeFieldInfoPtr__disposed)) = value;
    }
  }

  public new sealed class Joystick(IntPtr pointer) : CustomPlatformInputSource.Joystick(pointer)
  {
    private static readonly IntPtr NativeFieldInfoPtr__sourceJoystick;
    private static readonly IntPtr NativeMethodInfoPtr_get_sourceJoystick_Public_get_Joystick_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;
    private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

    static Joystick()
    {
      Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MyPlatformInputSource>.NativeClassPtr, nameof (Joystick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr);
      MyPlatformInputSource.Joystick.NativeFieldInfoPtr__sourceJoystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, nameof (_sourceJoystick));
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_get_sourceJoystick_Public_get_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670542);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670543);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670544);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670545);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670546);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670547);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670548);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670549);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670550);
      MyPlatformInputSource.Joystick.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr, 100670551);
    }

    public unsafe UnityInputJoystickSource.Joystick sourceJoystick
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr num1;
        IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_get_sourceJoystick_Public_get_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        IntPtr num3 = num2;
        return num3 == IntPtr.Zero ? (UnityInputJoystickSource.Joystick) null : Il2CppObjectPool.Get<UnityInputJoystickSource.Joystick>(num3);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 85714, RefRangeEnd = 85715, XrefRangeStart = 85710, XrefRangeEnd = 85714, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Joystick(UnityInputJoystickSource.Joystick sourceJoystick)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformInputSource.Joystick>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceJoystick)
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85715, XrefRangeEnd = 85730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_Update_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public virtual unsafe int vibrationMotorCount
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr num1;
        IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85730, XrefRangeEnd = 85746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &motorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &motorLevel;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85746, XrefRangeEnd = 85765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel, float duration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &motorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &motorLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &duration;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85765, XrefRangeEnd = 85786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &motorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &motorLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &stopOtherMotors;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 85810, RefRangeEnd = 85811, XrefRangeStart = 85786, XrefRangeEnd = 85810, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(
      int motorIndex,
      float motorLevel,
      float duration,
      bool stopOtherMotors)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[4];
      numPtr[0] = (IntPtr) &motorIndex;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &motorLevel;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &duration;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &stopOtherMotors;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe float GetVibration(int motorIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &motorIndex
      };
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85811, XrefRangeEnd = 85819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void StopVibration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformInputSource.Joystick.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe UnityInputJoystickSource.Joystick _sourceJoystick
    {
      get
      {
        IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.Joystick.NativeFieldInfoPtr__sourceJoystick));
        return num == IntPtr.Zero ? (UnityInputJoystickSource.Joystick) null : Il2CppObjectPool.Get<UnityInputJoystickSource.Joystick>(num);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformInputSource.Joystick.NativeFieldInfoPtr__sourceJoystick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
