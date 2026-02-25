// Decompiled with JetBrains decompiler
// Type: Rewired.Demos.CustomPlatform.MyPlatformControllerExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Rewired.ControllerExtensions;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Demos.CustomPlatform;

public sealed class MyPlatformControllerExtension(System.IntPtr pointer) : CustomControllerExtension(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_MyPlatformControllerExtension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ShallowCopy_Public_Virtual_Extension_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0;

  static MyPlatformControllerExtension()
  {
    Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Demos.CustomPlatform", nameof (MyPlatformControllerExtension));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr);
    MyPlatformControllerExtension.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670512);
    MyPlatformControllerExtension.NativeMethodInfoPtr__ctor_Private_Void_MyPlatformControllerExtension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670513);
    MyPlatformControllerExtension.NativeMethodInfoPtr_ShallowCopy_Public_Virtual_Extension_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670514);
    MyPlatformControllerExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670515);
    MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670516);
    MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670517);
    MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670518);
    MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670519);
    MyPlatformControllerExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670520);
    MyPlatformControllerExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, 100670521);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 85584, RefRangeEnd = 85585, XrefRangeStart = 85579, XrefRangeEnd = 85584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformControllerExtension(MyPlatformInputSource.Joystick sourceJoystick)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceJoystick)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85585, XrefRangeEnd = 85586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MyPlatformControllerExtension(MyPlatformControllerExtension other)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr__ctor_Private_Void_MyPlatformControllerExtension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85586, XrefRangeEnd = 85590, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Controller.Extension ShallowCopy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_ShallowCopy_Public_Virtual_Extension_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Controller.Extension) null : Il2CppObjectPool.Get<Controller.Extension>(num3);
  }

  public virtual unsafe int vibrationMotorCount
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_get_vibrationMotorCount_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85590, XrefRangeEnd = 85609, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetVibration(int motorIndex, float motorLevel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85609, XrefRangeEnd = 85631, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetVibration(int motorIndex, float motorLevel, float duration)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &duration;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85631, XrefRangeEnd = 85655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &motorIndex;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &motorLevel;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &stopOtherMotors;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85655, XrefRangeEnd = 85661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_SetVibration_Public_Virtual_Final_New_Void_Int32_Single_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85661, XrefRangeEnd = 85664, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe float GetVibration(int motorIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &motorIndex
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_GetVibration_Public_Virtual_Final_New_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85664, XrefRangeEnd = 85676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void StopVibration()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.NativeMethodInfoPtr_StopVibration_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public class Source(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_sourceJoystick;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Joystick_0;

    static Source()
    {
      Il2CppClassPointerStore<MyPlatformControllerExtension.Source>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MyPlatformControllerExtension>.NativeClassPtr, nameof (Source));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MyPlatformControllerExtension.Source>.NativeClassPtr);
      MyPlatformControllerExtension.Source.NativeFieldInfoPtr_sourceJoystick = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MyPlatformControllerExtension.Source>.NativeClassPtr, nameof (sourceJoystick));
      MyPlatformControllerExtension.Source.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MyPlatformControllerExtension.Source>.NativeClassPtr, 100670522);
    }

    [CallerCount(125)]
    [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Source(MyPlatformInputSource.Joystick sourceJoystick)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MyPlatformControllerExtension.Source>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceJoystick)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MyPlatformControllerExtension.Source.NativeMethodInfoPtr__ctor_Public_Void_Joystick_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe MyPlatformInputSource.Joystick sourceJoystick
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformControllerExtension.Source.NativeFieldInfoPtr_sourceJoystick));
        return num == System.IntPtr.Zero ? (MyPlatformInputSource.Joystick) null : Il2CppObjectPool.Get<MyPlatformInputSource.Joystick>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MyPlatformControllerExtension.Source.NativeFieldInfoPtr_sourceJoystick), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
