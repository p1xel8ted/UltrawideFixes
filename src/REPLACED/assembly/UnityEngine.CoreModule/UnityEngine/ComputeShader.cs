// Decompiled with JetBrains decompiler
// Type: UnityEngine.ComputeShader
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class ComputeShader(System.IntPtr pointer) : Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_FindKernel_Public_Int32_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0;
  private static readonly ComputeShader.HasKernel_InjectedDelegate HasKernel_InjectedDelegateField;
  private static readonly ComputeShader.SetFloat_InjectedDelegate SetFloat_InjectedDelegateField;
  private static readonly ComputeShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField;
  private static readonly ComputeShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField;
  private static readonly ComputeShader.SetFloatArray_InjectedDelegate SetFloatArray_InjectedDelegateField;
  private static readonly ComputeShader.SetIntArray_InjectedDelegate SetIntArray_InjectedDelegateField;
  private static readonly ComputeShader.SetVectorArray_InjectedDelegate SetVectorArray_InjectedDelegateField;
  private static readonly ComputeShader.SetMatrixArray_InjectedDelegate SetMatrixArray_InjectedDelegateField;
  private static readonly ComputeShader.SetTexture_InjectedDelegate SetTexture_InjectedDelegateField;
  private static readonly ComputeShader.SetRenderTexture_InjectedDelegate SetRenderTexture_InjectedDelegateField;
  private static readonly ComputeShader.SetTextureFromGlobal_InjectedDelegate SetTextureFromGlobal_InjectedDelegateField;
  private static readonly ComputeShader.Internal_SetBuffer_InjectedDelegate Internal_SetBuffer_InjectedDelegateField;
  private static readonly ComputeShader.Internal_SetGraphicsBuffer_InjectedDelegate Internal_SetGraphicsBuffer_InjectedDelegateField;
  private static readonly ComputeShader.Internal_SetRayTracingAccelerationStructure_InjectedDelegate Internal_SetRayTracingAccelerationStructure_InjectedDelegateField;
  private static readonly ComputeShader.SetConstantGraphicsBuffer_InjectedDelegate SetConstantGraphicsBuffer_InjectedDelegateField;
  private static readonly ComputeShader.GetKernelThreadGroupSizes_InjectedDelegate GetKernelThreadGroupSizes_InjectedDelegateField;
  private static readonly ComputeShader.Dispatch_InjectedDelegate Dispatch_InjectedDelegateField;
  private static readonly ComputeShader.Internal_DispatchIndirect_InjectedDelegate Internal_DispatchIndirect_InjectedDelegateField;
  private static readonly ComputeShader.Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField;
  private static readonly ComputeShader.IsKeywordEnabled_InjectedDelegate IsKeywordEnabled_InjectedDelegateField;
  private static readonly ComputeShader.EnableLocalKeyword_InjectedDelegate EnableLocalKeyword_InjectedDelegateField;
  private static readonly ComputeShader.DisableLocalKeyword_InjectedDelegate DisableLocalKeyword_InjectedDelegateField;
  private static readonly ComputeShader.SetLocalKeyword_InjectedDelegate SetLocalKeyword_InjectedDelegateField;
  private static readonly ComputeShader.IsLocalKeywordEnabled_InjectedDelegate IsLocalKeywordEnabled_InjectedDelegateField;
  private static readonly ComputeShader.IsSupported_InjectedDelegate IsSupported_InjectedDelegateField;
  private static readonly ComputeShader.GetShaderKeywords_InjectedDelegate GetShaderKeywords_InjectedDelegateField;
  private static readonly ComputeShader.GetEnabledKeywords_InjectedDelegate GetEnabledKeywords_InjectedDelegateField;
  private static readonly ComputeShader.SetEnabledKeywords_InjectedDelegate SetEnabledKeywords_InjectedDelegateField;

  static ComputeShader()
  {
    Il2CppClassPointerStore<ComputeShader>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ComputeShader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr);
    ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668496);
    ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668497);
    ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668498);
    ComputeShader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668499);
    ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668500);
    ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668501);
    ComputeShader.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668502);
    ComputeShader.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668503);
    ComputeShader.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668504);
    ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668505);
    ComputeShader.NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668506);
    ComputeShader.NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668507);
    ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668508);
    ComputeShader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668509);
    ComputeShader.NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668510);
    ComputeShader.NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668511);
    ComputeShader.NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr, 100668512);
    ComputeShader.HasKernel_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.HasKernel_InjectedDelegate>("UnityEngine.ComputeShader::HasKernel_Injected");
    ComputeShader.SetFloat_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloat_InjectedDelegate>("UnityEngine.ComputeShader::SetFloat_Injected");
    ComputeShader.SetVector_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVector_InjectedDelegate>("UnityEngine.ComputeShader::SetVector_Injected");
    ComputeShader.SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrix_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrix_Injected");
    ComputeShader.SetFloatArray_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetFloatArray_InjectedDelegate>("UnityEngine.ComputeShader::SetFloatArray_Injected");
    ComputeShader.SetIntArray_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetIntArray_InjectedDelegate>("UnityEngine.ComputeShader::SetIntArray_Injected");
    ComputeShader.SetVectorArray_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetVectorArray_InjectedDelegate>("UnityEngine.ComputeShader::SetVectorArray_Injected");
    ComputeShader.SetMatrixArray_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetMatrixArray_InjectedDelegate>("UnityEngine.ComputeShader::SetMatrixArray_Injected");
    ComputeShader.SetTexture_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTexture_InjectedDelegate>("UnityEngine.ComputeShader::SetTexture_Injected");
    ComputeShader.SetRenderTexture_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetRenderTexture_InjectedDelegate>("UnityEngine.ComputeShader::SetRenderTexture_Injected");
    ComputeShader.SetTextureFromGlobal_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetTextureFromGlobal_InjectedDelegate>("UnityEngine.ComputeShader::SetTextureFromGlobal_Injected");
    ComputeShader.Internal_SetBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetBuffer_InjectedDelegate>("UnityEngine.ComputeShader::Internal_SetBuffer_Injected");
    ComputeShader.Internal_SetGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetGraphicsBuffer_InjectedDelegate>("UnityEngine.ComputeShader::Internal_SetGraphicsBuffer_Injected");
    ComputeShader.Internal_SetRayTracingAccelerationStructure_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_SetRayTracingAccelerationStructure_InjectedDelegate>("UnityEngine.ComputeShader::Internal_SetRayTracingAccelerationStructure_Injected");
    ComputeShader.SetConstantGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetConstantGraphicsBuffer_InjectedDelegate>("UnityEngine.ComputeShader::SetConstantGraphicsBuffer_Injected");
    ComputeShader.GetKernelThreadGroupSizes_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.GetKernelThreadGroupSizes_InjectedDelegate>("UnityEngine.ComputeShader::GetKernelThreadGroupSizes_Injected");
    ComputeShader.Dispatch_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Dispatch_InjectedDelegate>("UnityEngine.ComputeShader::Dispatch_Injected");
    ComputeShader.Internal_DispatchIndirect_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirect_InjectedDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirect_Injected");
    ComputeShader.Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate>("UnityEngine.ComputeShader::Internal_DispatchIndirectGraphicsBuffer_Injected");
    ComputeShader.IsKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsKeywordEnabled_Injected");
    ComputeShader.EnableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.EnableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::EnableLocalKeyword_Injected");
    ComputeShader.DisableLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.DisableLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::DisableLocalKeyword_Injected");
    ComputeShader.SetLocalKeyword_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetLocalKeyword_InjectedDelegate>("UnityEngine.ComputeShader::SetLocalKeyword_Injected");
    ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsLocalKeywordEnabled_InjectedDelegate>("UnityEngine.ComputeShader::IsLocalKeywordEnabled_Injected");
    ComputeShader.IsSupported_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.IsSupported_InjectedDelegate>("UnityEngine.ComputeShader::IsSupported_Injected");
    ComputeShader.GetShaderKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.GetShaderKeywords_InjectedDelegate>("UnityEngine.ComputeShader::GetShaderKeywords_Injected");
    ComputeShader.GetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.GetEnabledKeywords_InjectedDelegate>("UnityEngine.ComputeShader::GetEnabledKeywords_Injected");
    ComputeShader.SetEnabledKeywords_InjectedDelegateField = IL2CPP.ResolveICall<ComputeShader.SetEnabledKeywords_InjectedDelegate>("UnityEngine.ComputeShader::SetEnabledKeywords_Injected");
  }

  [CallerCount(75)]
  [CachedScanResults(RefRangeStart = 464749, RefRangeEnd = 464824, XrefRangeStart = 464733, XrefRangeEnd = 464749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe int FindKernel(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 464829, RefRangeEnd = 464831, XrefRangeStart = 464824, XrefRangeEnd = 464829, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInt(int nameID, int val)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464841, RefRangeEnd = 464842, XrefRangeStart = 464831, XrefRangeEnd = 464841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetConstantComputeBuffer(
    int nameID,
    ComputeBuffer buffer,
    int offset,
    int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe LocalKeywordSpace keywordSpace
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 464846, RefRangeEnd = 464847, XrefRangeStart = 464842, XrefRangeEnd = 464846, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_get_keywordSpace_Public_get_LocalKeywordSpace_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(LocalKeywordSpace*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 464863, RefRangeEnd = 464879, XrefRangeStart = 464847, XrefRangeEnd = 464863, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void EnableKeyword(string keyword)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_EnableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 464895, RefRangeEnd = 464902, XrefRangeStart = 464879, XrefRangeEnd = 464895, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DisableKeyword(string keyword)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(keyword)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_DisableKeyword_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 464907, RefRangeEnd = 464910, XrefRangeStart = 464902, XrefRangeEnd = 464907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetShaderKeywords(Il2CppStringArray names)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) names)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetShaderKeywords_Private_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppStringArray shaderKeywords
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 464907, RefRangeEnd = 464910, XrefRangeStart = 464907, XrefRangeEnd = 464910, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_set_shaderKeywords_Public_set_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.GetShaderKeywords();
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464910, XrefRangeEnd = 464914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ComputeShader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ComputeShader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 464841, RefRangeEnd = 464842, XrefRangeStart = 464841, XrefRangeEnd = 464842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffer);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464914, XrefRangeEnd = 464916, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int FindKernel_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_FindKernel_Injected_Private_Static_Int32_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464916, XrefRangeEnd = 464918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetInt_Injected(System.IntPtr _unity_self, int nameID, int val)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &val;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetInt_Injected_Private_Static_Void_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464918, XrefRangeEnd = 464920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetConstantComputeBuffer_Injected(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &buffer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetConstantComputeBuffer_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464920, XrefRangeEnd = 464922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void get_keywordSpace_Injected(System.IntPtr _unity_self, out LocalKeywordSpace ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_get_keywordSpace_Injected_Private_Static_Void_IntPtr_byref_LocalKeywordSpace_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464922, XrefRangeEnd = 464924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EnableKeyword_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keyword;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_EnableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464924, XrefRangeEnd = 464926, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DisableKeyword_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper keyword)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref keyword;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_DisableKeyword_Injected_Private_Static_Void_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 464926, XrefRangeEnd = 464928, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetShaderKeywords_Injected(System.IntPtr _unity_self, Il2CppStringArray names)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) names);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ComputeShader.NativeMethodInfoPtr_SetShaderKeywords_Injected_Private_Static_Void_IntPtr_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool HasKernel(string name)
  {
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return ComputeShader.HasKernel_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void SetFloat(int nameID, float val)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetFloat_Injected(_unity_self, nameID, val);
  }

  public void SetVector(int nameID, Vector4 val)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetVector_Injected(_unity_self, nameID, ref val);
  }

  public void SetMatrix(int nameID, Matrix4x4 val)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetMatrix_Injected(_unity_self, nameID, ref val);
  }

  public unsafe void SetFloatArray(int nameID, Il2CppStructArray<float> values)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<float> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<float>) ref span).\u002Ector((Il2CppArrayBase<float>) values);
    fixed (float* begin = &((Il2CppSystem.Span<float>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<float>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      ComputeShader.SetFloatArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetIntArray(int nameID, Il2CppStructArray<int> values)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<int> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<int>) ref span).\u002Ector((Il2CppArrayBase<int>) values);
    fixed (int* begin = &((Il2CppSystem.Span<int>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<int>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      ComputeShader.SetIntArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<Vector4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector4>) ref span).\u002Ector((Il2CppArrayBase<Vector4>) values);
    fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      ComputeShader.SetVectorArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public unsafe void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    Il2CppSystem.Span<Matrix4x4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Matrix4x4>) ref span).\u002Ector((Il2CppArrayBase<Matrix4x4>) values);
    fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Matrix4x4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      ComputeShader.SetMatrixArray_Injected(_unity_self, nameID1, ref local);
    }
  }

  public void SetTexture(int kernelIndex, int nameID, Texture texture, int mipLevel)
  {
    if (texture == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    int nameID1 = nameID;
    System.IntPtr texture1 = Object.MarshalledUnityObject.MarshalNotNull<Texture>(texture);
    if (texture1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    int mipLevel1 = mipLevel;
    ComputeShader.SetTexture_Injected(_unity_self, kernelIndex1, nameID1, texture1, mipLevel1);
  }

  public void SetRenderTexture(
    int kernelIndex,
    int nameID,
    RenderTexture texture,
    int mipLevel,
    RenderTextureSubElement element)
  {
    if (texture == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    int nameID1 = nameID;
    System.IntPtr texture1 = Object.MarshalledUnityObject.MarshalNotNull<RenderTexture>(texture);
    if (texture1 == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) texture, nameof (texture));
    int mipLevel1 = mipLevel;
    int element1 = (int) element;
    ComputeShader.SetRenderTexture_Injected(_unity_self, kernelIndex1, nameID1, texture1, mipLevel1, (RenderTextureSubElement) element1);
  }

  public void SetTextureFromGlobal(int kernelIndex, int nameID, int globalTextureNameID)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetTextureFromGlobal_Injected(_unity_self, kernelIndex, nameID, globalTextureNameID);
  }

  public void Internal_SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    int nameID1 = nameID;
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    ComputeShader.Internal_SetBuffer_Injected(_unity_self, kernelIndex1, nameID1, native);
  }

  public void Internal_SetGraphicsBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    int nameID1 = nameID;
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    ComputeShader.Internal_SetGraphicsBuffer_Injected(_unity_self, kernelIndex1, nameID1, native);
  }

  public void Internal_SetRayTracingAccelerationStructure(
    int kernelIndex,
    int nameID,
    RayTracingAccelerationStructure accelerationStructure)
  {
    if (accelerationStructure == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) accelerationStructure, nameof (accelerationStructure));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    int nameID1 = nameID;
    System.IntPtr native = RayTracingAccelerationStructure.BindingsMarshaller.ConvertToNative(accelerationStructure);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) accelerationStructure, nameof (accelerationStructure));
    ComputeShader.Internal_SetRayTracingAccelerationStructure_Injected(_unity_self, kernelIndex1, nameID1, native);
  }

  public void SetRayTracingAccelerationStructure(
    int kernelIndex,
    int nameID,
    RayTracingAccelerationStructure accelerationStructure)
  {
    this.Internal_SetRayTracingAccelerationStructure(kernelIndex, nameID, accelerationStructure);
  }

  public void SetBuffer(int kernelIndex, int nameID, ComputeBuffer buffer)
  {
    this.Internal_SetBuffer(kernelIndex, nameID, buffer);
  }

  public void SetBuffer(int kernelIndex, int nameID, GraphicsBuffer buffer)
  {
    this.Internal_SetGraphicsBuffer(kernelIndex, nameID, buffer);
  }

  public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
  {
    if (buffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int nameID1 = nameID;
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(buffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) buffer, nameof (buffer));
    int offset1 = offset;
    int size1 = size;
    ComputeShader.SetConstantGraphicsBuffer_Injected(_unity_self, nameID1, native, offset1, size1);
  }

  public void GetKernelThreadGroupSizes(int kernelIndex, out uint x, out uint y, out uint z)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.GetKernelThreadGroupSizes_Injected(_unity_self, kernelIndex, out x, out y, out z);
  }

  public void Dispatch(int kernelIndex, int threadGroupsX, int threadGroupsY, int threadGroupsZ)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.Dispatch_Injected(_unity_self, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
  }

  public void Internal_DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
  {
    if (argsBuffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    System.IntPtr native = ComputeBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
    int argsOffset1 = (int) argsOffset;
    ComputeShader.Internal_DispatchIndirect_Injected(_unity_self, kernelIndex1, native, (uint) argsOffset1);
  }

  public void Internal_DispatchIndirectGraphicsBuffer(
    int kernelIndex,
    GraphicsBuffer argsBuffer,
    uint argsOffset)
  {
    if (argsBuffer == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int kernelIndex1 = kernelIndex;
    System.IntPtr native = GraphicsBuffer.BindingsMarshaller.ConvertToNative(argsBuffer);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) argsBuffer, nameof (argsBuffer));
    int argsOffset1 = (int) argsOffset;
    ComputeShader.Internal_DispatchIndirectGraphicsBuffer_Injected(_unity_self, kernelIndex1, native, (uint) argsOffset1);
  }

  public unsafe bool IsKeywordEnabled(string keyword)
  {
    try
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(keyword, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = keyword.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return ComputeShader.IsKeywordEnabled_Injected(_unity_self, ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public void EnableLocalKeyword(LocalKeyword keyword)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.EnableLocalKeyword_Injected(_unity_self, ref keyword);
  }

  public void DisableLocalKeyword(LocalKeyword keyword)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.DisableLocalKeyword_Injected(_unity_self, ref keyword);
  }

  public void SetLocalKeyword(LocalKeyword keyword, bool value)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetLocalKeyword_Injected(_unity_self, ref keyword, value);
  }

  public bool IsLocalKeywordEnabled(LocalKeyword keyword)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ComputeShader.IsLocalKeywordEnabled_Injected(_unity_self, ref keyword);
  }

  public void EnableKeyword([In] ref LocalKeyword keyword) => this.EnableLocalKeyword(keyword);

  public void DisableKeyword([In] ref LocalKeyword keyword) => this.DisableLocalKeyword(keyword);

  public void SetKeyword([In] ref LocalKeyword keyword, bool value)
  {
    this.SetLocalKeyword(keyword, value);
  }

  public bool IsKeywordEnabled([In] ref LocalKeyword keyword)
  {
    return this.IsLocalKeywordEnabled(keyword);
  }

  public bool IsSupported(int kernelIndex)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ComputeShader.IsSupported_Injected(_unity_self, kernelIndex);
  }

  public Il2CppStringArray GetShaderKeywords()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ComputeShader.GetShaderKeywords_Injected(_unity_self);
  }

  public Il2CppReferenceArray<LocalKeyword> GetEnabledKeywords()
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return ComputeShader.GetEnabledKeywords_Injected(_unity_self);
  }

  public void SetEnabledKeywords(Il2CppReferenceArray<LocalKeyword> keywords)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<ComputeShader>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    ComputeShader.SetEnabledKeywords_Injected(_unity_self, keywords);
  }

  public Il2CppReferenceArray<LocalKeyword> enabledKeywords
  {
    get => this.GetEnabledKeywords();
    set => this.SetEnabledKeywords(value);
  }

  public void SetFloat(string name, float val) => this.SetFloat(Shader.PropertyToID(name), val);

  public void SetInt(string name, int val) => this.SetInt(Shader.PropertyToID(name), val);

  public void SetVector(string name, Vector4 val) => this.SetVector(Shader.PropertyToID(name), val);

  public void SetMatrix(string name, Matrix4x4 val)
  {
    this.SetMatrix(Shader.PropertyToID(name), val);
  }

  public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
  {
    this.SetVectorArray(Shader.PropertyToID(name), values);
  }

  public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
  {
    this.SetMatrixArray(Shader.PropertyToID(name), values);
  }

  public void SetFloats(string name, Il2CppStructArray<float> values)
  {
    this.SetFloatArray(Shader.PropertyToID(name), values);
  }

  public void SetFloats(string name, params float[] values)
  {
    this.SetFloats(name, new Il2CppStructArray<float>(values));
  }

  public void SetFloats(int nameID, Il2CppStructArray<float> values)
  {
    this.SetFloatArray(nameID, values);
  }

  public void SetFloats(int nameID, params float[] values)
  {
    this.SetFloats(nameID, new Il2CppStructArray<float>(values));
  }

  public void SetInts(string name, Il2CppStructArray<int> values)
  {
    this.SetIntArray(Shader.PropertyToID(name), values);
  }

  public void SetInts(string name, params int[] values)
  {
    this.SetInts(name, new Il2CppStructArray<int>(values));
  }

  public void SetInts(int nameID, Il2CppStructArray<int> values)
  {
    this.SetIntArray(nameID, values);
  }

  public void SetInts(int nameID, params int[] values)
  {
    this.SetInts(nameID, new Il2CppStructArray<int>(values));
  }

  public void SetBool(string name, bool val) => this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);

  public void SetBool(int nameID, bool val) => this.SetInt(nameID, val ? 1 : 0);

  public void SetTexture(int kernelIndex, int nameID, Texture texture)
  {
    this.SetTexture(kernelIndex, nameID, texture, 0);
  }

  public void SetTexture(int kernelIndex, string name, Texture texture)
  {
    this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, 0);
  }

  public void SetTexture(int kernelIndex, string name, Texture texture, int mipLevel)
  {
    this.SetTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel);
  }

  public void SetTexture(
    int kernelIndex,
    int nameID,
    RenderTexture texture,
    int mipLevel,
    RenderTextureSubElement element)
  {
    this.SetRenderTexture(kernelIndex, nameID, texture, mipLevel, element);
  }

  public void SetTexture(
    int kernelIndex,
    string name,
    RenderTexture texture,
    int mipLevel,
    RenderTextureSubElement element)
  {
    this.SetRenderTexture(kernelIndex, Shader.PropertyToID(name), texture, mipLevel, element);
  }

  public void SetTextureFromGlobal(int kernelIndex, string name, string globalTextureName)
  {
    this.SetTextureFromGlobal(kernelIndex, Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
  }

  public void SetBuffer(int kernelIndex, string name, ComputeBuffer buffer)
  {
    this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
  }

  public void SetBuffer(int kernelIndex, string name, GraphicsBuffer buffer)
  {
    this.SetBuffer(kernelIndex, Shader.PropertyToID(name), buffer);
  }

  public void SetRayTracingAccelerationStructure(
    int kernelIndex,
    string name,
    RayTracingAccelerationStructure accelerationStructure)
  {
    this.SetRayTracingAccelerationStructure(kernelIndex, Shader.PropertyToID(name), accelerationStructure);
  }

  public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
  {
    this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
  }

  public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
  {
    this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
  }

  public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
  {
    this.SetConstantBuffer(Shader.PropertyToID(name), buffer, offset, size);
  }

  public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer, uint argsOffset)
  {
    if (argsBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (argsBuffer));
    if (argsBuffer.m_Ptr == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ObjectDisposedException(nameof (argsBuffer));
    if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    this.Internal_DispatchIndirect(kernelIndex, argsBuffer, argsOffset);
  }

  public void DispatchIndirect(int kernelIndex, ComputeBuffer argsBuffer)
  {
    this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
  }

  public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer, uint argsOffset)
  {
    if (argsBuffer == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (argsBuffer));
    if (argsBuffer.m_Ptr == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ObjectDisposedException(nameof (argsBuffer));
    if (SystemInfo.graphicsDeviceType == GraphicsDeviceType.Metal && !SystemInfo.supportsIndirectArgumentsBuffer)
      throw new Il2CppSystem.InvalidOperationException("Indirect argument buffers are not supported.");
    this.Internal_DispatchIndirectGraphicsBuffer(kernelIndex, argsBuffer, argsOffset);
  }

  public void DispatchIndirect(int kernelIndex, GraphicsBuffer argsBuffer)
  {
    this.DispatchIndirect(kernelIndex, argsBuffer, 0U);
  }

  public static bool HasKernel_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper name)
  {
    return ComputeShader.HasKernel_InjectedDelegateField(_unity_self, (System.IntPtr) ref name);
  }

  public static void SetFloat_Injected(System.IntPtr _unity_self, int nameID, float val)
  {
    ComputeShader.SetFloat_InjectedDelegateField(_unity_self, nameID, val);
  }

  public static void SetVector_Injected(System.IntPtr _unity_self, int nameID, [In] ref Vector4 val)
  {
    ComputeShader.SetVector_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref val);
  }

  public static void SetMatrix_Injected(System.IntPtr _unity_self, int nameID, [In] ref Matrix4x4 val)
  {
    ComputeShader.SetMatrix_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref val);
  }

  public static void SetFloatArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    ComputeShader.SetFloatArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetIntArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    ComputeShader.SetIntArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetVectorArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    ComputeShader.SetVectorArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetMatrixArray_Injected(
    System.IntPtr _unity_self,
    int nameID,
    ref ManagedSpanWrapper values)
  {
    ComputeShader.SetMatrixArray_InjectedDelegateField(_unity_self, nameID, (System.IntPtr) ref values);
  }

  public static void SetTexture_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr texture,
    int mipLevel)
  {
    ComputeShader.SetTexture_InjectedDelegateField(_unity_self, kernelIndex, nameID, texture, mipLevel);
  }

  public static void SetRenderTexture_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr texture,
    int mipLevel,
    RenderTextureSubElement element)
  {
    ComputeShader.SetRenderTexture_InjectedDelegateField(_unity_self, kernelIndex, nameID, texture, mipLevel, element);
  }

  public static void SetTextureFromGlobal_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    int globalTextureNameID)
  {
    ComputeShader.SetTextureFromGlobal_InjectedDelegateField(_unity_self, kernelIndex, nameID, globalTextureNameID);
  }

  public static void Internal_SetBuffer_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr buffer)
  {
    ComputeShader.Internal_SetBuffer_InjectedDelegateField(_unity_self, kernelIndex, nameID, buffer);
  }

  public static void Internal_SetGraphicsBuffer_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr buffer)
  {
    ComputeShader.Internal_SetGraphicsBuffer_InjectedDelegateField(_unity_self, kernelIndex, nameID, buffer);
  }

  public static void Internal_SetRayTracingAccelerationStructure_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr accelerationStructure)
  {
    ComputeShader.Internal_SetRayTracingAccelerationStructure_InjectedDelegateField(_unity_self, kernelIndex, nameID, accelerationStructure);
  }

  public static void SetConstantGraphicsBuffer_Injected(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size)
  {
    ComputeShader.SetConstantGraphicsBuffer_InjectedDelegateField(_unity_self, nameID, buffer, offset, size);
  }

  public static void GetKernelThreadGroupSizes_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    out uint x,
    out uint y,
    out uint z)
  {
    ComputeShader.GetKernelThreadGroupSizes_InjectedDelegateField(_unity_self, kernelIndex, (System.IntPtr) ref x, (System.IntPtr) ref y, (System.IntPtr) ref z);
  }

  public static void Dispatch_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    int threadGroupsX,
    int threadGroupsY,
    int threadGroupsZ)
  {
    ComputeShader.Dispatch_InjectedDelegateField(_unity_self, kernelIndex, threadGroupsX, threadGroupsY, threadGroupsZ);
  }

  public static void Internal_DispatchIndirect_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    System.IntPtr argsBuffer,
    uint argsOffset)
  {
    ComputeShader.Internal_DispatchIndirect_InjectedDelegateField(_unity_self, kernelIndex, argsBuffer, argsOffset);
  }

  public static void Internal_DispatchIndirectGraphicsBuffer_Injected(
    System.IntPtr _unity_self,
    int kernelIndex,
    System.IntPtr argsBuffer,
    uint argsOffset)
  {
    ComputeShader.Internal_DispatchIndirectGraphicsBuffer_InjectedDelegateField(_unity_self, kernelIndex, argsBuffer, argsOffset);
  }

  public static bool IsKeywordEnabled_Injected(System.IntPtr _unity_self, ref ManagedSpanWrapper keyword)
  {
    return ComputeShader.IsKeywordEnabled_InjectedDelegateField(_unity_self, (System.IntPtr) ref keyword);
  }

  public static unsafe void EnableLocalKeyword_Injected(
    System.IntPtr _unity_self,
    [In] ref LocalKeyword keyword)
  {
    ComputeShader.EnableLocalKeyword_InjectedDelegateField(_unity_self, (System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword));
  }

  public static unsafe void DisableLocalKeyword_Injected(
    System.IntPtr _unity_self,
    [In] ref LocalKeyword keyword)
  {
    ComputeShader.DisableLocalKeyword_InjectedDelegateField(_unity_self, (System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword));
  }

  public static unsafe void SetLocalKeyword_Injected(
    System.IntPtr _unity_self,
    [In] ref LocalKeyword keyword,
    bool value)
  {
    ComputeShader.SetLocalKeyword_InjectedDelegateField(_unity_self, (System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword), value);
  }

  public static unsafe bool IsLocalKeywordEnabled_Injected(
    System.IntPtr _unity_self,
    [In] ref LocalKeyword keyword)
  {
    return ComputeShader.IsLocalKeywordEnabled_InjectedDelegateField(_unity_self, (System.IntPtr) &IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keyword));
  }

  public static bool IsSupported_Injected(System.IntPtr _unity_self, int kernelIndex)
  {
    return ComputeShader.IsSupported_InjectedDelegateField(_unity_self, kernelIndex);
  }

  public static Il2CppStringArray GetShaderKeywords_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = ComputeShader.GetShaderKeywords_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public static Il2CppReferenceArray<LocalKeyword> GetEnabledKeywords_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr num = ComputeShader.GetEnabledKeywords_InjectedDelegateField(_unity_self);
    return num == System.IntPtr.Zero ? (Il2CppReferenceArray<LocalKeyword>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<LocalKeyword>>(num);
  }

  public static void SetEnabledKeywords_Injected(
    System.IntPtr _unity_self,
    Il2CppReferenceArray<LocalKeyword> keywords)
  {
    ComputeShader.SetEnabledKeywords_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) keywords));
  }

  private delegate bool HasKernel_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr name);

  private delegate void SetFloat_InjectedDelegate(System.IntPtr _unity_self, int nameID, float val);

  private delegate void SetVector_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

  private delegate void SetMatrix_InjectedDelegate(System.IntPtr _unity_self, int nameID, [In] System.IntPtr val);

  private delegate void SetFloatArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetIntArray_InjectedDelegate(System.IntPtr _unity_self, int nameID, System.IntPtr values);

  private delegate void SetVectorArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetMatrixArray_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr values);

  private delegate void SetTexture_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr texture,
    int mipLevel);

  private delegate void SetRenderTexture_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr texture,
    int mipLevel,
    RenderTextureSubElement element);

  private delegate void SetTextureFromGlobal_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    int globalTextureNameID);

  private delegate void Internal_SetBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr buffer);

  private delegate void Internal_SetGraphicsBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr buffer);

  private delegate void Internal_SetRayTracingAccelerationStructure_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int nameID,
    System.IntPtr accelerationStructure);

  private delegate void SetConstantGraphicsBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int nameID,
    System.IntPtr buffer,
    int offset,
    int size);

  private delegate void GetKernelThreadGroupSizes_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    [Out] System.IntPtr x,
    [Out] System.IntPtr y,
    [Out] System.IntPtr z);

  private delegate void Dispatch_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    int threadGroupsX,
    int threadGroupsY,
    int threadGroupsZ);

  private delegate void Internal_DispatchIndirect_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    System.IntPtr argsBuffer,
    uint argsOffset);

  private delegate void Internal_DispatchIndirectGraphicsBuffer_InjectedDelegate(
    System.IntPtr _unity_self,
    int kernelIndex,
    System.IntPtr argsBuffer,
    uint argsOffset);

  private delegate bool IsKeywordEnabled_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr keyword);

  private delegate void EnableLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

  private delegate void DisableLocalKeyword_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

  private delegate void SetLocalKeyword_InjectedDelegate(
    System.IntPtr _unity_self,
    [In] System.IntPtr keyword,
    bool value);

  private delegate bool IsLocalKeywordEnabled_InjectedDelegate(System.IntPtr _unity_self, [In] System.IntPtr keyword);

  private delegate bool IsSupported_InjectedDelegate(System.IntPtr _unity_self, int kernelIndex);

  private delegate System.IntPtr GetShaderKeywords_InjectedDelegate(System.IntPtr _unity_self);

  private delegate System.IntPtr GetEnabledKeywords_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void SetEnabledKeywords_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr keywords);
}
