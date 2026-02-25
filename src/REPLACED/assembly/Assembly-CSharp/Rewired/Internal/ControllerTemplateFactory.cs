// Decompiled with JetBrains decompiler
// Type: Rewired.Internal.ControllerTemplateFactory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Rewired.Internal;

public static class ControllerTemplateFactory : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateTypes;
  private static readonly System.IntPtr NativeFieldInfoPtr__defaultTemplateInterfaceTypes;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0;

  static ControllerTemplateFactory()
  {
    Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Internal", nameof (ControllerTemplateFactory));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr);
    ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, nameof (_defaultTemplateTypes));
    ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, nameof (_defaultTemplateInterfaceTypes));
    ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668296);
    ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668297);
    ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControllerTemplateFactory>.NativeClassPtr, 100668298);
  }

  public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> templateTypes
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66809, XrefRangeEnd = 66813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
    }
  }

  public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> templateInterfaceTypes
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66813, XrefRangeEnd = 66817, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_get_templateInterfaceTypes_Public_Static_get_Il2CppReferenceArray_1_Type_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 66847, RefRangeEnd = 66848, XrefRangeStart = 66817, XrefRangeEnd = 66847, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe IControllerTemplate Create(Il2CppSystem.Guid typeGuid, Il2CppSystem.Object payload)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &typeGuid;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) payload);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ControllerTemplateFactory.NativeMethodInfoPtr_Create_Public_Static_IControllerTemplate_Guid_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IControllerTemplate) null : Il2CppObjectPool.Get<IControllerTemplate>(num3);
  }

  public ControllerTemplateFactory(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateTypes
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppReferenceArray<Il2CppSystem.Type> _defaultTemplateInterfaceTypes
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Type>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Type>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ControllerTemplateFactory.NativeFieldInfoPtr__defaultTemplateInterfaceTypes, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
