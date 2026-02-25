// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.RendererList
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct RendererList
{
  private static readonly System.IntPtr NativeFieldInfoPtr_context;
  private static readonly System.IntPtr NativeFieldInfoPtr_index;
  private static readonly System.IntPtr NativeFieldInfoPtr_frame;
  private static readonly System.IntPtr NativeFieldInfoPtr_type;
  private static readonly System.IntPtr NativeFieldInfoPtr_contextID;
  private static readonly System.IntPtr NativeFieldInfoPtr_nullRendererList;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0;
  [FieldOffset(0)]
  public System.UIntPtr context;
  [FieldOffset(8)]
  public uint index;
  [FieldOffset(12)]
  public uint frame;
  [FieldOffset(16 /*0x10*/)]
  public uint type;
  [FieldOffset(20)]
  public uint contextID;

  static RendererList()
  {
    Il2CppClassPointerStore<RendererList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (RendererList));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererList>.NativeClassPtr);
    RendererList.NativeFieldInfoPtr_context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (context));
    RendererList.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (index));
    RendererList.NativeFieldInfoPtr_frame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (frame));
    RendererList.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (type));
    RendererList.NativeFieldInfoPtr_contextID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (contextID));
    RendererList.NativeFieldInfoPtr_nullRendererList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererList>.NativeClassPtr, nameof (nullRendererList));
    RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100670402);
    RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererList>.NativeClassPtr, 100670403);
  }

  public unsafe bool isValid
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487668, RefRangeEnd = 487670, XrefRangeStart = 487666, XrefRangeEnd = 487668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr_get_isValid_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public unsafe RendererList(System.UIntPtr ctx, uint indx)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &ctx;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &indx;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RendererList.NativeMethodInfoPtr__ctor_Internal_Void_UIntPtr_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RendererList>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe RendererList nullRendererList
  {
    get
    {
      RendererList nullRendererList;
      IL2CPP.il2cpp_field_static_get_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*) &nullRendererList);
      return nullRendererList;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(RendererList.NativeFieldInfoPtr_nullRendererList, (void*) &value);
    }
  }
}
