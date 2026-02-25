// Decompiled with JetBrains decompiler
// Type: UnityEngine.ScalableBufferManager
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine;

public static class ScalableBufferManager : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0;

  static ScalableBufferManager()
  {
    Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ScalableBufferManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr);
    ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664755);
    ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664756);
    ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScalableBufferManager>.NativeClassPtr, 100664757);
  }

  public static unsafe float widthScaleFactor
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 423660, RefRangeEnd = 423665, XrefRangeStart = 423658, XrefRangeEnd = 423660, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_widthScaleFactor_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe float heightScaleFactor
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 423667, RefRangeEnd = 423672, XrefRangeStart = 423665, XrefRangeEnd = 423667, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_get_heightScaleFactor_Public_Static_get_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423672, XrefRangeEnd = 423674, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ResizeBuffers(float widthScale, float heightScale)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &widthScale;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &heightScale;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScalableBufferManager.NativeMethodInfoPtr_ResizeBuffers_Public_Static_Void_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ScalableBufferManager(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
