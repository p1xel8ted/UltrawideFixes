// Decompiled with JetBrains decompiler
// Type: Rewired.FlightPedalsTemplate
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired;

public sealed class FlightPedalsTemplate(System.IntPtr pointer) : ControllerTemplate(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_typeGuid;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_leftPedal;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_rightPedal;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementId_slide;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;

  static FlightPedalsTemplate()
  {
    Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired", nameof (FlightPedalsTemplate));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr);
    FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (typeGuid));
    FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_leftPedal));
    FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_rightPedal));
    FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, nameof (elementId_slide));
    FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100668019);
    FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100668020);
    FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100668021);
    FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr, 100668022);
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002EleftPedal
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64383, XrefRangeEnd = 64386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_leftPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002ErightPedal
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64386, XrefRangeEnd = 64389, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_rightPedal_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  public virtual unsafe IControllerTemplateAxis Rewired\u002EIFlightPedalsTemplate\u002Eslide
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 64389, XrefRangeEnd = 64397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr_Rewired_IFlightPedalsTemplate_get_slide_Private_Virtual_Final_New_get_IControllerTemplateAxis_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (IControllerTemplateAxis) null : Il2CppObjectPool.Get<IControllerTemplateAxis>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FlightPedalsTemplate(Il2CppSystem.Object payload)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlightPedalsTemplate>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FlightPedalsTemplate.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Il2CppSystem.Guid typeGuid
  {
    get
    {
      Il2CppSystem.Guid typeGuid;
      IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*) &typeGuid);
      return typeGuid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_typeGuid, (void*) &value);
    }
  }

  public static unsafe int elementId_leftPedal
  {
    get
    {
      int elementIdLeftPedal;
      IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &elementIdLeftPedal);
      return elementIdLeftPedal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_leftPedal, (void*) &value);
    }
  }

  public static unsafe int elementId_rightPedal
  {
    get
    {
      int elementIdRightPedal;
      IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &elementIdRightPedal);
      return elementIdRightPedal;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_rightPedal, (void*) &value);
    }
  }

  public static unsafe int elementId_slide
  {
    get
    {
      int elementIdSlide;
      IL2CPP.il2cpp_field_static_get_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*) &elementIdSlide);
      return elementIdSlide;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(FlightPedalsTemplate.NativeFieldInfoPtr_elementId_slide, (void*) &value);
    }
  }
}
