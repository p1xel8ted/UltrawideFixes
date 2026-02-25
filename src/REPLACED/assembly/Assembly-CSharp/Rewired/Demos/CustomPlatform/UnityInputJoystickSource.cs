// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.UnityInputJoystickSource
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Collections.ObjectModel;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public class UnityInputJoystickSource(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_joystickCheckInterval;
  private static readonly System.IntPtr NativeFieldInfoPtr_systemIdCounter;
  private static readonly System.IntPtr NativeFieldInfoPtr__unityJoysticks;
  private static readonly System.IntPtr NativeFieldInfoPtr__nextJoystickCheckTime;
  private static readonly System.IntPtr NativeFieldInfoPtr__joysticks;
  private static readonly System.IntPtr NativeFieldInfoPtr__joysticks_readOnly;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CheckForJoystickChanges_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DidJoysticksChange_Private_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RefreshJoysticks_Private_Void_0;

  static UnityInputJoystickSource()
  {
    Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (UnityInputJoystickSource));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr);
    UnityInputJoystickSource.NativeFieldInfoPtr_joystickCheckInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (joystickCheckInterval));
    UnityInputJoystickSource.NativeFieldInfoPtr_systemIdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (systemIdCounter));
    UnityInputJoystickSource.NativeFieldInfoPtr__unityJoysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (_unityJoysticks));
    UnityInputJoystickSource.NativeFieldInfoPtr__nextJoystickCheckTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (_nextJoystickCheckTime));
    UnityInputJoystickSource.NativeFieldInfoPtr__joysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (_joysticks));
    UnityInputJoystickSource.NativeFieldInfoPtr__joysticks_readOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (_joysticks_readOnly));
    UnityInputJoystickSource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670559);
    UnityInputJoystickSource.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670560);
    UnityInputJoystickSource.NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670561);
    UnityInputJoystickSource.NativeMethodInfoPtr_CheckForJoystickChanges_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670562);
    UnityInputJoystickSource.NativeMethodInfoPtr_DidJoysticksChange_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670563);
    UnityInputJoystickSource.NativeMethodInfoPtr_RefreshJoysticks_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, 100670564);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86109, XrefRangeEnd = 86126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityInputJoystickSource()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86126, XrefRangeEnd = 86135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 64591, RefRangeEnd = 64595, XrefRangeStart = 64591, XrefRangeEnd = 64595, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IList<UnityInputJoystickSource.Joystick> GetJoysticks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr_GetJoysticks_Public_IList_1_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IList<UnityInputJoystickSource.Joystick>) null : Il2CppObjectPool.Get<IList<UnityInputJoystickSource.Joystick>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CheckForJoystickChanges()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr_CheckForJoystickChanges_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86135, XrefRangeEnd = 86138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool DidJoysticksChange()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr_DidJoysticksChange_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 86197, RefRangeEnd = 86203, XrefRangeStart = 86138, XrefRangeEnd = 86197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void RefreshJoysticks()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.NativeMethodInfoPtr_RefreshJoysticks_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe float joystickCheckInterval
  {
    get
    {
      float joystickCheckInterval;
      IL2CPP.il2cpp_field_static_get_value(UnityInputJoystickSource.NativeFieldInfoPtr_joystickCheckInterval, (void*) &joystickCheckInterval);
      return joystickCheckInterval;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityInputJoystickSource.NativeFieldInfoPtr_joystickCheckInterval, (void*) &value);
    }
  }

  public static unsafe int systemIdCounter
  {
    get
    {
      int systemIdCounter;
      IL2CPP.il2cpp_field_static_get_value(UnityInputJoystickSource.NativeFieldInfoPtr_systemIdCounter, (void*) &systemIdCounter);
      return systemIdCounter;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UnityInputJoystickSource.NativeFieldInfoPtr_systemIdCounter, (void*) &value);
    }
  }

  public unsafe Il2CppStringArray _unityJoysticks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__unityJoysticks));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__unityJoysticks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe double _nextJoystickCheckTime
  {
    get
    {
      return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__nextJoystickCheckTime));
    }
    [param: In] set
    {
      *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__nextJoystickCheckTime)) = value;
    }
  }

  public unsafe List<UnityInputJoystickSource.Joystick> _joysticks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__joysticks));
      return num == System.IntPtr.Zero ? (List<UnityInputJoystickSource.Joystick>) null : Il2CppObjectPool.Get<List<UnityInputJoystickSource.Joystick>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__joysticks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ReadOnlyCollection<UnityInputJoystickSource.Joystick> _joysticks_readOnly
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__joysticks_readOnly));
      return num == System.IntPtr.Zero ? (ReadOnlyCollection<UnityInputJoystickSource.Joystick>) null : Il2CppObjectPool.Get<ReadOnlyCollection<UnityInputJoystickSource.Joystick>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.NativeFieldInfoPtr__joysticks_readOnly), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public class Joystick(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_maxJoysticks;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxAxes;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxButtons;
    private static readonly System.IntPtr NativeFieldInfoPtr_systemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_deviceName;
    private static readonly System.IntPtr NativeFieldInfoPtr_deviceInstanceGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_axisCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonCount;
    private static readonly System.IntPtr NativeFieldInfoPtr_identifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_buttonValues;
    private static readonly System.IntPtr NativeFieldInfoPtr_axisValues;
    private static readonly System.IntPtr NativeFieldInfoPtr_unityIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr__vibrationMotorCount_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int64_String_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonValue_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAxisValue_Public_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_vibrationMotorCount_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

    static Joystick()
    {
      Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnityInputJoystickSource>.NativeClassPtr, nameof (Joystick));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr);
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxJoysticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (maxJoysticks));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxAxes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (maxAxes));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxButtons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (maxButtons));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_systemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (systemId));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (deviceName));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceInstanceGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (deviceInstanceGuid));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (axisCount));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (buttonCount));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (identifier));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (buttonValues));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (axisValues));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_unityIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, nameof (unityIndex));
      UnityInputJoystickSource.Joystick.NativeFieldInfoPtr__vibrationMotorCount_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, "<vibrationMotorCount>k__BackingField");
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_Int64_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670565);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetButtonValue_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670566);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetAxisValue_Public_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670567);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670568);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_set_vibrationMotorCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670569);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670570);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670571);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670572);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670573);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670574);
      UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr, 100670575);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 86011, RefRangeEnd = 86013, XrefRangeStart = 86004, XrefRangeEnd = 86011, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Joystick(long systemId, string deviceName, int axisCount, int buttonCount)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityInputJoystickSource.Joystick>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &systemId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(deviceName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &axisCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &buttonCount;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr__ctor_Public_Void_Int64_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86013, XrefRangeEnd = 86014, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool GetButtonValue(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetButtonValue_Public_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86014, XrefRangeEnd = 86022, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetAxisValue(int index)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetAxisValue_Public_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public virtual unsafe int vibrationMotorCount
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 74758, RefRangeEnd = 74763, XrefRangeStart = 74758, XrefRangeEnd = 74763, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr num1;
        System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
        Il2CppException.RaiseExceptionIfNecessary(num1);
        return *(int*) IL2CPP.il2cpp_object_unbox(num2);
      }
      [CallerCount(0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1]
        {
          (System.IntPtr) &value
        };
        System.IntPtr num;
        IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_set_vibrationMotorCount_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
        Il2CppException.RaiseExceptionIfNecessary(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86022, XrefRangeEnd = 86038, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &motorIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86038, XrefRangeEnd = 86057, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel, float duration)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &motorIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86057, XrefRangeEnd = 86078, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &motorIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOtherMotors;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86078, XrefRangeEnd = 86102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void SetVibration(
      int motorIndex,
      float motorLevel,
      float duration,
      bool stopOtherMotors)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &motorIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOtherMotors;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe float GetVibration(int motorIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &motorIndex
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86102, XrefRangeEnd = 86109, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void StopVibration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UnityInputJoystickSource.Joystick.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe int maxJoysticks
    {
      get
      {
        int maxJoysticks;
        IL2CPP.il2cpp_field_static_get_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxJoysticks, (void*) &maxJoysticks);
        return maxJoysticks;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxJoysticks, (void*) &value);
      }
    }

    public static unsafe int maxAxes
    {
      get
      {
        int maxAxes;
        IL2CPP.il2cpp_field_static_get_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxAxes, (void*) &maxAxes);
        return maxAxes;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxAxes, (void*) &value);
      }
    }

    public static unsafe int maxButtons
    {
      get
      {
        int maxButtons;
        IL2CPP.il2cpp_field_static_get_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxButtons, (void*) &maxButtons);
        return maxButtons;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_maxButtons, (void*) &value);
      }
    }

    public unsafe long systemId
    {
      get
      {
        return *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_systemId));
      }
      [param: In] set
      {
        *(long*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_systemId)) = value;
      }
    }

    public unsafe string deviceName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.Guid deviceInstanceGuid
    {
      get
      {
        return *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceInstanceGuid));
      }
      [param: In] set
      {
        *(Il2CppSystem.Guid*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_deviceInstanceGuid)) = value;
      }
    }

    public unsafe int axisCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisCount)) = value;
      }
    }

    public unsafe int buttonCount
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonCount));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonCount)) = value;
      }
    }

    public unsafe MyPlatformControllerIdentifier identifier
    {
      get
      {
        return *(MyPlatformControllerIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_identifier));
      }
      [param: In] set
      {
        *(MyPlatformControllerIdentifier*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_identifier)) = value;
      }
    }

    public unsafe Il2CppStructArray<bool> buttonValues
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonValues));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<bool>) null : Il2CppObjectPool.Get<Il2CppStructArray<bool>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_buttonValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<float> axisValues
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisValues));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_axisValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int unityIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_unityIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr_unityIndex)) = value;
      }
    }

    public unsafe int _vibrationMotorCount_k__BackingField
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr__vibrationMotorCount_k__BackingField));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnityInputJoystickSource.Joystick.NativeFieldInfoPtr__vibrationMotorCount_k__BackingField)) = value;
      }
    }
  }
}
