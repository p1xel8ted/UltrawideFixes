// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Rendering.SceneFrameManager
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Rendering;

public sealed class SceneFrameManager(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_kTaaJitterSampleCount;
  private static readonly System.IntPtr NativeFieldInfoPtr__sceneFrames;
  private static readonly System.IntPtr NativeFieldInfoPtr__currFrameIdx;
  private static readonly System.IntPtr NativeFieldInfoPtr__taaJitterSampleIndex;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSceneFrame_Public_SceneFrame_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTaaJitterSampleIndex_Public_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_MoveToNextFrame_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

  static SceneFrameManager()
  {
    Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "SadCatStudios.Rendering", nameof (SceneFrameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr);
    SceneFrameManager.NativeFieldInfoPtr_kTaaJitterSampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, nameof (kTaaJitterSampleCount));
    SceneFrameManager.NativeFieldInfoPtr__sceneFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, nameof (_sceneFrames));
    SceneFrameManager.NativeFieldInfoPtr__currFrameIdx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, nameof (_currFrameIdx));
    SceneFrameManager.NativeFieldInfoPtr__taaJitterSampleIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, nameof (_taaJitterSampleIndex));
    SceneFrameManager.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, 100663566 /*0x0600010E*/);
    SceneFrameManager.NativeMethodInfoPtr_GetSceneFrame_Public_SceneFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, 100663567 /*0x0600010F*/);
    SceneFrameManager.NativeMethodInfoPtr_GetTaaJitterSampleIndex_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, 100663568 /*0x06000110*/);
    SceneFrameManager.NativeMethodInfoPtr_MoveToNextFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, 100663569);
    SceneFrameManager.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr, 100663570);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926248, RefRangeEnd = 926249, XrefRangeStart = 926240, XrefRangeEnd = 926248, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneFrameManager(int frameCount)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SceneFrameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &frameCount
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrameManager.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 926249, RefRangeEnd = 926251, XrefRangeStart = 926249, XrefRangeEnd = 926249, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe SceneFrame GetSceneFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrameManager.NativeMethodInfoPtr_GetSceneFrame_Public_SceneFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (SceneFrame) null : Il2CppObjectPool.Get<SceneFrame>(num3);
  }

  [CallerCount(0)]
  public unsafe int GetTaaJitterSampleIndex()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SceneFrameManager.NativeMethodInfoPtr_GetTaaJitterSampleIndex_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926251, RefRangeEnd = 926252, XrefRangeStart = 926251, XrefRangeEnd = 926251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void MoveToNextFrame()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrameManager.NativeMethodInfoPtr_MoveToNextFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 926290, RefRangeEnd = 926291, XrefRangeStart = 926252, XrefRangeEnd = 926290, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Release()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SceneFrameManager.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int kTaaJitterSampleCount
  {
    get
    {
      int jitterSampleCount;
      IL2CPP.il2cpp_field_static_get_value(SceneFrameManager.NativeFieldInfoPtr_kTaaJitterSampleCount, (void*) &jitterSampleCount);
      return jitterSampleCount;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(SceneFrameManager.NativeFieldInfoPtr_kTaaJitterSampleCount, (void*) &value);
    }
  }

  public unsafe Il2CppReferenceArray<SceneFrame> _sceneFrames
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__sceneFrames));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SceneFrame>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SceneFrame>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__sceneFrames), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _currFrameIdx
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__currFrameIdx));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__currFrameIdx)) = value;
    }
  }

  public unsafe int _taaJitterSampleIndex
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__taaJitterSampleIndex));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SceneFrameManager.NativeFieldInfoPtr__taaJitterSampleIndex)) = value;
    }
  }
}
