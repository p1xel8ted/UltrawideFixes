// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.AttachmentIndexArray
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct AttachmentIndexArray
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Emtpy;
  private static readonly System.IntPtr NativeFieldInfoPtr_a0;
  private static readonly System.IntPtr NativeFieldInfoPtr_a1;
  private static readonly System.IntPtr NativeFieldInfoPtr_a2;
  private static readonly System.IntPtr NativeFieldInfoPtr_a3;
  private static readonly System.IntPtr NativeFieldInfoPtr_a4;
  private static readonly System.IntPtr NativeFieldInfoPtr_a5;
  private static readonly System.IntPtr NativeFieldInfoPtr_a6;
  private static readonly System.IntPtr NativeFieldInfoPtr_a7;
  private static readonly System.IntPtr NativeFieldInfoPtr_activeAttachments;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;
  [FieldOffset(0)]
  public int a0;
  [FieldOffset(4)]
  public int a1;
  [FieldOffset(8)]
  public int a2;
  [FieldOffset(12)]
  public int a3;
  [FieldOffset(16 /*0x10*/)]
  public int a4;
  [FieldOffset(20)]
  public int a5;
  [FieldOffset(24)]
  public int a6;
  [FieldOffset(28)]
  public int a7;
  [FieldOffset(32 /*0x20*/)]
  public int activeAttachments;
  public const int MaxAttachments = 8;

  static AttachmentIndexArray()
  {
    Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (AttachmentIndexArray));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr);
    AttachmentIndexArray.NativeFieldInfoPtr_Emtpy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (Emtpy));
    AttachmentIndexArray.NativeFieldInfoPtr_a0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a0));
    AttachmentIndexArray.NativeFieldInfoPtr_a1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a1));
    AttachmentIndexArray.NativeFieldInfoPtr_a2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a2));
    AttachmentIndexArray.NativeFieldInfoPtr_a3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a3));
    AttachmentIndexArray.NativeFieldInfoPtr_a4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a4));
    AttachmentIndexArray.NativeFieldInfoPtr_a5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a5));
    AttachmentIndexArray.NativeFieldInfoPtr_a6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a6));
    AttachmentIndexArray.NativeFieldInfoPtr_a7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (a7));
    AttachmentIndexArray.NativeFieldInfoPtr_activeAttachments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, nameof (activeAttachments));
    AttachmentIndexArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100670326);
    AttachmentIndexArray.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100670327);
    AttachmentIndexArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100670328);
    AttachmentIndexArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, 100670329);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487290, RefRangeEnd = 487292, XrefRangeStart = 487290, XrefRangeEnd = 487290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AttachmentIndexArray(int numAttachments)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &numAttachments
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AttachmentIndexArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int this[int index]
  {
    [CallerCount(6), CachedScanResults(RefRangeStart = 487292, RefRangeEnd = 487298, XrefRangeStart = 487292, XrefRangeEnd = 487292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &index
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttachmentIndexArray.NativeMethodInfoPtr_get_Item_Public_get_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 487298, RefRangeEnd = 487302, XrefRangeStart = 487298, XrefRangeEnd = 487298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &index;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AttachmentIndexArray.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int Length
  {
    [CallerCount(27), CachedScanResults(RefRangeStart = 327365, RefRangeEnd = 327392, XrefRangeStart = 327365, XrefRangeEnd = 327392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AttachmentIndexArray.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentIndexArray>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe AttachmentIndexArray Emtpy
  {
    get
    {
      AttachmentIndexArray emtpy;
      IL2CPP.il2cpp_field_static_get_value(AttachmentIndexArray.NativeFieldInfoPtr_Emtpy, (void*) &emtpy);
      return emtpy;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(AttachmentIndexArray.NativeFieldInfoPtr_Emtpy, (void*) &value);
    }
  }
}
