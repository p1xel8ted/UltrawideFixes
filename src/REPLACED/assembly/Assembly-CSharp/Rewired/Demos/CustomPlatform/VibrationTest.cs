// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.VibrationTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public class VibrationTest(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_playerId;
  private static readonly IntPtr NativeFieldInfoPtr_vibrationIncrement;
  private static readonly IntPtr NativeFieldInfoPtr_motors;
  private static readonly IntPtr NativeFieldInfoPtr_action_motors;
  private static readonly IntPtr NativeFieldInfoPtr_action_stop;
  private static readonly IntPtr NativeMethodInfoPtr_get_player_Private_get_Player_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_StopVibration_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetVibration_Private_Void_Int32_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static VibrationTest()
  {
    Il2CppClassPointerStore<VibrationTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (VibrationTest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr);
    VibrationTest.NativeFieldInfoPtr_playerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, nameof (playerId));
    VibrationTest.NativeFieldInfoPtr_vibrationIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, nameof (vibrationIncrement));
    VibrationTest.NativeFieldInfoPtr_motors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, nameof (motors));
    VibrationTest.NativeFieldInfoPtr_action_motors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, nameof (action_motors));
    VibrationTest.NativeFieldInfoPtr_action_stop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, nameof (action_stop));
    VibrationTest.NativeMethodInfoPtr_get_player_Private_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, 100670576);
    VibrationTest.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, 100670577);
    VibrationTest.NativeMethodInfoPtr_StopVibration_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, 100670578);
    VibrationTest.NativeMethodInfoPtr_SetVibration_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, 100670579);
    VibrationTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr, 100670580);
  }

  public unsafe Player player
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 86209, RefRangeEnd = 86210, XrefRangeStart = 86203, XrefRangeEnd = 86209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(VibrationTest.NativeMethodInfoPtr_get_player_Private_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Player) null : Il2CppObjectPool.Get<Player>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86210, XrefRangeEnd = 86249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VibrationTest.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86249, XrefRangeEnd = 86257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void StopVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VibrationTest.NativeMethodInfoPtr_StopVibration_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 86265, RefRangeEnd = 86267, XrefRangeStart = 86257, XrefRangeEnd = 86265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVibration(int motorIndex, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &motorIndex;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &value;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VibrationTest.NativeMethodInfoPtr_SetVibration_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 86267, XrefRangeEnd = 86271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe VibrationTest()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VibrationTest>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(VibrationTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int playerId
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_playerId));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_playerId)) = value;
    }
  }

  public unsafe float vibrationIncrement
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_vibrationIncrement));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_vibrationIncrement)) = value;
    }
  }

  public unsafe Il2CppStructArray<float> motors
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_motors));
      return num == IntPtr.Zero ? (Il2CppStructArray<float>) null : Il2CppObjectPool.Get<Il2CppStructArray<float>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VibrationTest.NativeFieldInfoPtr_motors), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStringArray action_motors
  {
    get
    {
      IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(VibrationTest.NativeFieldInfoPtr_action_motors, (void*) &num1);
      IntPtr num2 = num1;
      return num2 == IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VibrationTest.NativeFieldInfoPtr_action_motors, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe string action_stop
  {
    get
    {
      IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(VibrationTest.NativeFieldInfoPtr_action_stop, (void*) &num);
      return IL2CPP.Il2CppStringToManaged(num);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(VibrationTest.NativeFieldInfoPtr_action_stop, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
