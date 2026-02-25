// Decompiled with JetBrains decompiler
// Type: UnityEngine.BlendShapeBufferRange
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[Serializable]
[StructLayout(LayoutKind.Explicit)]
public struct BlendShapeBufferRange
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_StartIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_EndIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0;
  [FieldOffset(0)]
  public uint m_StartIndex;
  [FieldOffset(4)]
  public uint m_EndIndex;

  static BlendShapeBufferRange()
  {
    Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BlendShapeBufferRange));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr);
    BlendShapeBufferRange.NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, nameof (m_StartIndex));
    BlendShapeBufferRange.NativeFieldInfoPtr_m_EndIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, nameof (m_EndIndex));
    BlendShapeBufferRange.NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, 100666523);
    BlendShapeBufferRange.NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, 100666524);
  }

  public unsafe uint startIndex
  {
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlendShapeBufferRange.NativeMethodInfoPtr_set_startIndex_Internal_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_StartIndex;
  }

  public unsafe uint endIndex
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BlendShapeBufferRange.NativeMethodInfoPtr_set_endIndex_Internal_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_EndIndex;
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlendShapeBufferRange>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
