// Decompiled with JetBrains decompiler
// Type: UnityEngine.DefaultExecutionOrder
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class DefaultExecutionOrder(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Order;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_order_Public_get_Int32_0;

  static DefaultExecutionOrder()
  {
    Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (DefaultExecutionOrder));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr);
    DefaultExecutionOrder.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, nameof (m_Order));
    DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100667870);
    DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100667871);
  }

  [CallerCount(27)]
  [CachedScanResults(RefRangeStart = 255094, RefRangeEnd = 255121, XrefRangeStart = 255094, XrefRangeEnd = 255121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DefaultExecutionOrder(int order)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &order
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int order
  {
    [CallerCount(54), CachedScanResults(RefRangeStart = 327675, RefRangeEnd = 327729, XrefRangeStart = 327675, XrefRangeEnd = 327729, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int m_Order
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order)) = value;
    }
  }
}
