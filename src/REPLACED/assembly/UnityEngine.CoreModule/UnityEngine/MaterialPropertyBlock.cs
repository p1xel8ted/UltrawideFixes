// Decompiled with JetBrains decompiler
// Type: UnityEngine.MaterialPropertyBlock
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class MaterialPropertyBlock(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Ptr;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasPropertyImpl_Private_Boolean_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Private_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVector_Public_Vector4_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_HasPropertyImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0;
  private static readonly MaterialPropertyBlock.GetIntImpl_InjectedDelegate GetIntImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetColorImpl_InjectedDelegate GetColorImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate GetMatrixImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasFloatImpl_InjectedDelegate HasFloatImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasIntImpl_InjectedDelegate HasIntImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasTextureImpl_InjectedDelegate HasTextureImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasMatrixImpl_InjectedDelegate HasMatrixImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasVectorImpl_InjectedDelegate HasVectorImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasBufferImpl_InjectedDelegate HasBufferImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.HasConstantBufferImpl_InjectedDelegate HasConstantBufferImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.SetMatrixImpl_InjectedDelegate SetMatrixImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.SetGraphicsBufferImpl_InjectedDelegate SetGraphicsBufferImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.SetConstantGraphicsBufferImpl_InjectedDelegate SetConstantGraphicsBufferImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.SetMatrixArrayImpl_InjectedDelegate SetMatrixArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetFloatArrayImpl_InjectedDelegate GetFloatArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetVectorArrayImpl_InjectedDelegate GetVectorArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetMatrixArrayImpl_InjectedDelegate GetMatrixArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetFloatArrayCountImpl_InjectedDelegate GetFloatArrayCountImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetVectorArrayCountImpl_InjectedDelegate GetVectorArrayCountImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.GetMatrixArrayCountImpl_InjectedDelegate GetMatrixArrayCountImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.ExtractFloatArrayImpl_InjectedDelegate ExtractFloatArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.ExtractVectorArrayImpl_InjectedDelegate ExtractVectorArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.ExtractMatrixArrayImpl_InjectedDelegate ExtractMatrixArrayImpl_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom_InjectedDelegate Internal_CopySHCoefficientArraysFrom_InjectedDelegateField;
  private static readonly MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField;

  static MaterialPropertyBlock()
  {
    Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (MaterialPropertyBlock));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr);
    MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, nameof (m_Ptr));
    MaterialPropertyBlock.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665039);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665040 /*0x060006D0*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665041);
    MaterialPropertyBlock.NativeMethodInfoPtr_HasPropertyImpl_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665042);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665043);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665044);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665045);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665046);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665047);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665048);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665049);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665050);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665051);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665052);
    MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665053);
    MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665054);
    MaterialPropertyBlock.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665055);
    MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665056 /*0x060006E0*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665057);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665058);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665059);
    MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665060);
    MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665061);
    MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665062);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665063);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665064);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665065);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665066);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665067);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665068);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665069);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665070);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665071);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665072 /*0x060006F0*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665073);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665074);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665075);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665076);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665077);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665078);
    MaterialPropertyBlock.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665079);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetFloat_Public_Single_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665080);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665081);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665082);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665083);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665084);
    MaterialPropertyBlock.NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665085);
    MaterialPropertyBlock.NativeMethodInfoPtr_HasPropertyImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665086);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665087);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665088 /*0x06000700*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665089 /*0x06000701*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665090 /*0x06000702*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665091 /*0x06000703*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665092 /*0x06000704*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665093 /*0x06000705*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665094 /*0x06000706*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665095 /*0x06000707*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665096 /*0x06000708*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665097 /*0x06000709*/);
    MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, 100665098 /*0x0600070A*/);
    MaterialPropertyBlock.GetIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetIntImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetIntImpl_Injected");
    MaterialPropertyBlock.GetColorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetColorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetColorImpl_Injected");
    MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixImpl_Injected");
    MaterialPropertyBlock.HasFloatImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasFloatImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasFloatImpl_Injected");
    MaterialPropertyBlock.HasIntImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasIntImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasIntImpl_Injected");
    MaterialPropertyBlock.HasTextureImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasTextureImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasTextureImpl_Injected");
    MaterialPropertyBlock.HasMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasMatrixImpl_Injected");
    MaterialPropertyBlock.HasVectorImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasVectorImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasVectorImpl_Injected");
    MaterialPropertyBlock.HasBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasBufferImpl_Injected");
    MaterialPropertyBlock.HasConstantBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.HasConstantBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::HasConstantBufferImpl_Injected");
    MaterialPropertyBlock.SetMatrixImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetMatrixImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetMatrixImpl_Injected");
    MaterialPropertyBlock.SetGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetGraphicsBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetGraphicsBufferImpl_Injected");
    MaterialPropertyBlock.SetConstantGraphicsBufferImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetConstantGraphicsBufferImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetConstantGraphicsBufferImpl_Injected");
    MaterialPropertyBlock.SetMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.SetMatrixArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::SetMatrixArrayImpl_Injected");
    MaterialPropertyBlock.GetFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayImpl_Injected");
    MaterialPropertyBlock.GetVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayImpl_Injected");
    MaterialPropertyBlock.GetMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayImpl_Injected");
    MaterialPropertyBlock.GetFloatArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetFloatArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetFloatArrayCountImpl_Injected");
    MaterialPropertyBlock.GetVectorArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetVectorArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetVectorArrayCountImpl_Injected");
    MaterialPropertyBlock.GetMatrixArrayCountImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.GetMatrixArrayCountImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::GetMatrixArrayCountImpl_Injected");
    MaterialPropertyBlock.ExtractFloatArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractFloatArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractFloatArrayImpl_Injected");
    MaterialPropertyBlock.ExtractVectorArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractVectorArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractVectorArrayImpl_Injected");
    MaterialPropertyBlock.ExtractMatrixArrayImpl_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.ExtractMatrixArrayImpl_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::ExtractMatrixArrayImpl_Injected");
    MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopySHCoefficientArraysFrom_Injected");
    MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField = IL2CPP.ResolveICall<MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate>("UnityEngine.MaterialPropertyBlock::Internal_CopyProbeOcclusionArrayFrom_Injected");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424834, XrefRangeEnd = 424838, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetFloatImpl(int name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &name
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetFloatImpl_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424838, XrefRangeEnd = 424841, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetVectorImpl(int name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &name
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetVectorImpl_Private_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424841, XrefRangeEnd = 424848, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture GetTextureImpl(int name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &name
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetTextureImpl_Private_Texture_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424848, XrefRangeEnd = 424852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasPropertyImpl(int name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &name
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_HasPropertyImpl_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 424856, RefRangeEnd = 424858, XrefRangeStart = 424852, XrefRangeEnd = 424856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetIntImpl(int name, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 424862, RefRangeEnd = 424878, XrefRangeStart = 424858, XrefRangeEnd = 424862, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloatImpl(int name, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424878, XrefRangeEnd = 424881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVectorImpl(int name, Vector4 value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Private_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424881, XrefRangeEnd = 424884, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColorImpl(int name, Color value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Private_Void_Int32_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 424894, RefRangeEnd = 424914, XrefRangeStart = 424884, XrefRangeEnd = 424894, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTextureImpl(int name, Texture value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Private_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424924, RefRangeEnd = 424925, XrefRangeStart = 424914, XrefRangeEnd = 424924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetRenderTextureImpl(
    int name,
    RenderTexture value,
    RenderTextureSubElement element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Private_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424925, XrefRangeEnd = 424929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBufferImpl(int name, ComputeBuffer value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Private_Void_Int32_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424933, RefRangeEnd = 424934, XrefRangeStart = 424929, XrefRangeEnd = 424933, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetConstantBufferImpl(int name, ComputeBuffer value, int offset, int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBufferImpl_Private_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424934, XrefRangeEnd = 424944, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloatArrayImpl(int name, Il2CppStructArray<float> values, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424944, XrefRangeEnd = 424954, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVectorArrayImpl(int name, Il2CppStructArray<Vector4> values, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424954, XrefRangeEnd = 424956, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr CreateImpl()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_CreateImpl_Private_Static_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424956, XrefRangeEnd = 424958, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DestroyImpl(System.IntPtr mpb)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mpb
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_DestroyImpl_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool isEmpty
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 424962, RefRangeEnd = 424965, XrefRangeStart = 424958, XrefRangeEnd = 424962, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_get_isEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 424965, XrefRangeEnd = 424969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear(bool keepMemory)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &keepMemory
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 424973, RefRangeEnd = 424980, XrefRangeStart = 424969, XrefRangeEnd = 424973, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Clear()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424989, RefRangeEnd = 424990, XrefRangeStart = 424980, XrefRangeEnd = 424989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloatArray(int name, Il2CppStructArray<float> values, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Private_Void_Int32_Il2CppStructArray_1_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 424999, RefRangeEnd = 425001, XrefRangeStart = 424990, XrefRangeEnd = 424999, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVectorArray(int name, Il2CppStructArray<Vector4> values, int count)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Private_Void_Int32_Il2CppStructArray_1_Vector4_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(13)]
  [CachedScanResults(RefRangeStart = 425004, RefRangeEnd = 425017, XrefRangeStart = 425001, XrefRangeEnd = 425004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MaterialPropertyBlock()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425017, XrefRangeEnd = 425026, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void Finalize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425026, XrefRangeEnd = 425032, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Dispose_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 425037, RefRangeEnd = 425045, XrefRangeStart = 425032, XrefRangeEnd = 425037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInt(string name, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(12)]
  [CachedScanResults(RefRangeStart = 425049, RefRangeEnd = 425061, XrefRangeStart = 425045, XrefRangeEnd = 425049, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInt(int nameID, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInt_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 425066, RefRangeEnd = 425072, XrefRangeStart = 425061, XrefRangeEnd = 425066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloat(string name, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(16 /*0x10*/)]
  [CachedScanResults(RefRangeStart = 424862, RefRangeEnd = 424878, XrefRangeStart = 424862, XrefRangeEnd = 424878, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloat(int nameID, float value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloat_Public_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 424856, RefRangeEnd = 424858, XrefRangeStart = 424856, XrefRangeEnd = 424858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetInteger(int nameID, int value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetInteger_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 425076, RefRangeEnd = 425078, XrefRangeStart = 425072, XrefRangeEnd = 425076, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVector(string name, Vector4 value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_String_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(36)]
  [CachedScanResults(RefRangeStart = 425081, RefRangeEnd = 425117, XrefRangeStart = 425078, XrefRangeEnd = 425081, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVector(int nameID, Vector4 value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVector_Public_Void_Int32_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425117, XrefRangeEnd = 425121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetColor(string name, Color value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColor_Public_Void_String_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 425126, RefRangeEnd = 425127, XrefRangeStart = 425121, XrefRangeEnd = 425126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetBuffer(string name, ComputeBuffer value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetBuffer_Public_Void_String_ComputeBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 425138, RefRangeEnd = 425140, XrefRangeStart = 425127, XrefRangeEnd = 425138, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTexture(string name, Texture value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_String_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 424894, RefRangeEnd = 424914, XrefRangeStart = 424894, XrefRangeEnd = 424914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTexture(int nameID, Texture value)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424924, RefRangeEnd = 424925, XrefRangeStart = 424924, XrefRangeEnd = 424925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetTexture(int nameID, RenderTexture value, RenderTextureSubElement element)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTexture_Public_Void_Int32_RenderTexture_RenderTextureSubElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 424933, RefRangeEnd = 424934, XrefRangeStart = 424933, XrefRangeEnd = 424934, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetConstantBuffer(int nameID, ComputeBuffer value, int offset, int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBuffer_Public_Void_Int32_ComputeBuffer_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 425142, RefRangeEnd = 425147, XrefRangeStart = 425140, XrefRangeEnd = 425142, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetFloatArray(string name, Il2CppStructArray<float> values)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArray_Public_Void_String_Il2CppStructArray_1_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 425149, RefRangeEnd = 425151, XrefRangeStart = 425147, XrefRangeEnd = 425149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_String_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 425152, RefRangeEnd = 425153, XrefRangeStart = 425151, XrefRangeEnd = 425152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &nameID;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) values);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArray_Public_Void_Int32_Il2CppStructArray_1_Vector4_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 425158, RefRangeEnd = 425160, XrefRangeStart = 425153, XrefRangeEnd = 425158, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool HasProperty(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_HasProperty_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 425165, RefRangeEnd = 425166, XrefRangeStart = 425160, XrefRangeEnd = 425165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float GetFloat(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetFloat_Public_Single_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 425170, RefRangeEnd = 425171, XrefRangeStart = 425166, XrefRangeEnd = 425170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Vector4 GetVector(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetVector_Public_Vector4_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425171, XrefRangeEnd = 425179, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Texture GetTexture(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetTexture_Public_Texture_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Texture) null : Il2CppObjectPool.Get<Texture>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425179, XrefRangeEnd = 425181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe float GetFloatImpl_Injected(System.IntPtr _unity_self, int name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetFloatImpl_Injected_Private_Static_Single_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425181, XrefRangeEnd = 425183, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetVectorImpl_Injected(System.IntPtr _unity_self, int name, out Vector4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425183, XrefRangeEnd = 425185, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetTextureImpl_Injected(System.IntPtr _unity_self, int name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_GetTextureImpl_Injected_Private_Static_IntPtr_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425185, XrefRangeEnd = 425187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool HasPropertyImpl_Injected(System.IntPtr _unity_self, int name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_HasPropertyImpl_Injected_Private_Static_Boolean_IntPtr_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425187, XrefRangeEnd = 425189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetIntImpl_Injected(System.IntPtr _unity_self, int name, int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetIntImpl_Injected_Private_Static_Void_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425189, XrefRangeEnd = 425191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetFloatImpl_Injected(System.IntPtr _unity_self, int name, float value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatImpl_Injected_Private_Static_Void_IntPtr_Int32_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425191, XrefRangeEnd = 425193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetVectorImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Vector4 value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Vector4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425193, XrefRangeEnd = 425195, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetColorImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Color value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetColorImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425195, XrefRangeEnd = 425197, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTextureImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425197, XrefRangeEnd = 425199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetRenderTextureImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr value,
    RenderTextureSubElement element)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &element;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetRenderTextureImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_RenderTextureSubElement_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425199, XrefRangeEnd = 425201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425201, XrefRangeEnd = 425203, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetConstantBufferImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr value,
    int offset,
    int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[5];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &offset;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetConstantBufferImpl_Injected_Private_Static_Void_IntPtr_Int32_IntPtr_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425203, XrefRangeEnd = 425205, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetFloatArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    ref ManagedSpanWrapper values,
    int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref values;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetFloatArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425205, XrefRangeEnd = 425207, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetVectorArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    ref ManagedSpanWrapper values,
    int count)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &name;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref values;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &count;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_SetVectorArrayImpl_Injected_Private_Static_Void_IntPtr_Int32_byref_ManagedSpanWrapper_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425207, XrefRangeEnd = 425209, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool get_isEmpty_Injected(System.IntPtr _unity_self)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &_unity_self
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_get_isEmpty_Injected_Private_Static_Boolean_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 425209, XrefRangeEnd = 425211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear_Injected(System.IntPtr _unity_self, bool keepMemory)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &keepMemory;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.NativeMethodInfoPtr_Clear_Injected_Private_Static_Void_IntPtr_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe System.IntPtr m_Ptr
  {
    get
    {
      return *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr));
    }
    [param: In] set
    {
      *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MaterialPropertyBlock.NativeFieldInfoPtr_m_Ptr)) = value;
    }
  }

  public void AddFloat(string name, float value) => this.SetFloat(Shader.PropertyToID(name), value);

  public void AddFloat(int nameID, float value) => this.SetFloat(nameID, value);

  public void AddVector(string name, Vector4 value)
  {
    this.SetVector(Shader.PropertyToID(name), value);
  }

  public void AddVector(int nameID, Vector4 value) => this.SetVector(nameID, value);

  public void AddColor(string name, Color value) => this.SetColor(Shader.PropertyToID(name), value);

  public void AddColor(int nameID, Color value) => this.SetColor(nameID, value);

  public void AddMatrix(string name, Matrix4x4 value)
  {
    this.SetMatrix(Shader.PropertyToID(name), value);
  }

  public void AddMatrix(int nameID, Matrix4x4 value) => this.SetMatrix(nameID, value);

  public void AddTexture(string name, Texture value)
  {
    this.SetTexture(Shader.PropertyToID(name), value);
  }

  public void AddTexture(int nameID, Texture value) => this.SetTexture(nameID, value);

  public int GetIntImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.GetIntImpl_Injected(native, name);
  }

  public Color GetColorImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Color ret;
    MaterialPropertyBlock.GetColorImpl_Injected(native, name, out ret);
    return ret;
  }

  public Matrix4x4 GetMatrixImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    Matrix4x4 ret;
    MaterialPropertyBlock.GetMatrixImpl_Injected(native, name, out ret);
    return ret;
  }

  public bool HasFloatImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasFloatImpl_Injected(native, name);
  }

  public bool HasIntImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasIntImpl_Injected(native, name);
  }

  public bool HasTextureImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasTextureImpl_Injected(native, name);
  }

  public bool HasMatrixImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasMatrixImpl_Injected(native, name);
  }

  public bool HasVectorImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasVectorImpl_Injected(native, name);
  }

  public bool HasBufferImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasBufferImpl_Injected(native, name);
  }

  public bool HasConstantBufferImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.HasConstantBufferImpl_Injected(native, name);
  }

  public void SetMatrixImpl(int name, Matrix4x4 value)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    MaterialPropertyBlock.SetMatrixImpl_Injected(native, name, ref value);
  }

  public void SetGraphicsBufferImpl(int name, GraphicsBuffer value)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    MaterialPropertyBlock.SetGraphicsBufferImpl_Injected(native, name, value == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value));
  }

  public void SetConstantGraphicsBufferImpl(int name, GraphicsBuffer value, int offset, int size)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    MaterialPropertyBlock.SetConstantGraphicsBufferImpl_Injected(native, name, value == null ? System.IntPtr.Zero : GraphicsBuffer.BindingsMarshaller.ConvertToNative(value), offset, size);
  }

  public unsafe void SetMatrixArrayImpl(int name, Il2CppStructArray<Matrix4x4> values, int count)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int name1 = name;
    Il2CppSystem.Span<Matrix4x4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Matrix4x4>) ref span).\u002Ector((Il2CppArrayBase<Matrix4x4>) values);
    fixed (Matrix4x4* begin = &((Il2CppSystem.Span<Matrix4x4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Matrix4x4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int count1 = count;
      MaterialPropertyBlock.SetMatrixArrayImpl_Injected(native, name1, ref local, count1);
    }
  }

  public Il2CppStructArray<float> GetFloatArrayImpl(int name)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<float> floatArrayImpl;
    try
    {
      System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      MaterialPropertyBlock.GetFloatArrayImpl_Injected(native, name, out ret);
    }
    finally
    {
      Il2CppStructArray<float> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<float>((Il2CppArrayBase<float>&) ref il2CppStructArray);
      floatArrayImpl = il2CppStructArray;
    }
    return floatArrayImpl;
  }

  public Il2CppStructArray<Vector4> GetVectorArrayImpl(int name)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Vector4> vectorArrayImpl;
    try
    {
      System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      MaterialPropertyBlock.GetVectorArrayImpl_Injected(native, name, out ret);
    }
    finally
    {
      Il2CppStructArray<Vector4> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Vector4>((Il2CppArrayBase<Vector4>&) ref il2CppStructArray);
      vectorArrayImpl = il2CppStructArray;
    }
    return vectorArrayImpl;
  }

  public Il2CppStructArray<Matrix4x4> GetMatrixArrayImpl(int name)
  {
    BlittableArrayWrapper ret;
    Il2CppStructArray<Matrix4x4> matrixArrayImpl;
    try
    {
      System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
      if (native == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      MaterialPropertyBlock.GetMatrixArrayImpl_Injected(native, name, out ret);
    }
    finally
    {
      Il2CppStructArray<Matrix4x4> il2CppStructArray;
      // ISSUE: cast to a reference type
      ret.Unmarshal<Matrix4x4>((Il2CppArrayBase<Matrix4x4>&) ref il2CppStructArray);
      matrixArrayImpl = il2CppStructArray;
    }
    return matrixArrayImpl;
  }

  public int GetFloatArrayCountImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.GetFloatArrayCountImpl_Injected(native, name);
  }

  public int GetVectorArrayCountImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.GetVectorArrayCountImpl_Injected(native, name);
  }

  public int GetMatrixArrayCountImpl(int name)
  {
    System.IntPtr native = MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(this);
    if (native == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return MaterialPropertyBlock.GetMatrixArrayCountImpl_Injected(native, name);
  }

  public void ExtractFloatArrayImpl(int name, [Out] Il2CppStructArray<float> val)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void ExtractVectorArrayImpl(int name, [Out] Il2CppStructArray<Vector4> val)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public void ExtractMatrixArrayImpl(int name, [Out] Il2CppStructArray<Matrix4x4> val)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public static unsafe void Internal_CopySHCoefficientArraysFrom(
    MaterialPropertyBlock properties,
    Il2CppStructArray<SphericalHarmonicsL2> lightProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    System.IntPtr properties1 = properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties);
    Il2CppSystem.Span<SphericalHarmonicsL2> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).\u002Ector((Il2CppArrayBase<SphericalHarmonicsL2>) lightProbes);
    fixed (SphericalHarmonicsL2* begin = &((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<SphericalHarmonicsL2>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int sourceStart1 = sourceStart;
      int destStart1 = destStart;
      int count1 = count;
      MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom_Injected(properties1, ref local, sourceStart1, destStart1, count1);
    }
  }

  public static unsafe void Internal_CopyProbeOcclusionArrayFrom(
    MaterialPropertyBlock properties,
    Il2CppStructArray<Vector4> occlusionProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    System.IntPtr properties1 = properties == null ? System.IntPtr.Zero : MaterialPropertyBlock.BindingsMarshaller.ConvertToNative(properties);
    Il2CppSystem.Span<Vector4> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Vector4>) ref span).\u002Ector((Il2CppArrayBase<Vector4>) occlusionProbes);
    fixed (Vector4* begin = &((Il2CppSystem.Span<Vector4>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Vector4>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      int sourceStart1 = sourceStart;
      int destStart1 = destStart;
      int count1 = count;
      MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom_Injected(properties1, ref local, sourceStart1, destStart1, count1);
    }
  }

  public void SetMatrixArray(int name, Il2CppStructArray<Matrix4x4> values, int count)
  {
    if (values == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (values));
    if (((Il2CppArrayBase) values).Length == 0)
      throw new Il2CppSystem.ArgumentException("Zero-sized array is not allowed.");
    if (((Il2CppArrayBase) values).Length < count)
      throw new Il2CppSystem.ArgumentException("array has less elements than passed count.");
    this.SetMatrixArrayImpl(name, values, count);
  }

  public void ExtractFloatArray(int name, List<float> values)
  {
    if (values == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (values));
    values.Clear();
    int floatArrayCountImpl = this.GetFloatArrayCountImpl(name);
    if (floatArrayCountImpl <= 0)
      return;
    NoAllocHelpers.EnsureListElemCount<float>(values, floatArrayCountImpl);
    this.ExtractFloatArrayImpl(name, (Il2CppStructArray<float>) NoAllocHelpers.ExtractArrayFromList<float>(values));
  }

  public void ExtractVectorArray(int name, List<Vector4> values)
  {
    if (values == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (values));
    values.Clear();
    int vectorArrayCountImpl = this.GetVectorArrayCountImpl(name);
    if (vectorArrayCountImpl <= 0)
      return;
    NoAllocHelpers.EnsureListElemCount<Vector4>(values, vectorArrayCountImpl);
    this.ExtractVectorArrayImpl(name, (Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(values));
  }

  public void ExtractMatrixArray(int name, List<Matrix4x4> values)
  {
    if (values == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (values));
    values.Clear();
    int matrixArrayCountImpl = this.GetMatrixArrayCountImpl(name);
    if (matrixArrayCountImpl <= 0)
      return;
    NoAllocHelpers.EnsureListElemCount<Matrix4x4>(values, matrixArrayCountImpl);
    this.ExtractMatrixArrayImpl(name, (Il2CppStructArray<Matrix4x4>) NoAllocHelpers.ExtractArrayFromList<Matrix4x4>(values));
  }

  public void SetInteger(string name, int value)
  {
    this.SetIntImpl(Shader.PropertyToID(name), value);
  }

  public void SetColor(int nameID, Color value) => this.SetColorImpl(nameID, value);

  public void SetMatrix(string name, Matrix4x4 value)
  {
    this.SetMatrixImpl(Shader.PropertyToID(name), value);
  }

  public void SetMatrix(int nameID, Matrix4x4 value) => this.SetMatrixImpl(nameID, value);

  public void SetBuffer(int nameID, ComputeBuffer value) => this.SetBufferImpl(nameID, value);

  public void SetBuffer(string name, GraphicsBuffer value)
  {
    this.SetGraphicsBufferImpl(Shader.PropertyToID(name), value);
  }

  public void SetBuffer(int nameID, GraphicsBuffer value)
  {
    this.SetGraphicsBufferImpl(nameID, value);
  }

  public void SetTexture(string name, RenderTexture value, RenderTextureSubElement element)
  {
    this.SetRenderTextureImpl(Shader.PropertyToID(name), value, element);
  }

  public void SetConstantBuffer(string name, ComputeBuffer value, int offset, int size)
  {
    this.SetConstantBufferImpl(Shader.PropertyToID(name), value, offset, size);
  }

  public void SetConstantBuffer(string name, GraphicsBuffer value, int offset, int size)
  {
    this.SetConstantGraphicsBufferImpl(Shader.PropertyToID(name), value, offset, size);
  }

  public void SetConstantBuffer(int nameID, GraphicsBuffer value, int offset, int size)
  {
    this.SetConstantGraphicsBufferImpl(nameID, value, offset, size);
  }

  public void SetFloatArray(string name, List<float> values)
  {
    this.SetFloatArray(Shader.PropertyToID(name), (Il2CppStructArray<float>) NoAllocHelpers.ExtractArrayFromList<float>(values), values.Count);
  }

  public void SetFloatArray(int nameID, List<float> values)
  {
    this.SetFloatArray(nameID, (Il2CppStructArray<float>) NoAllocHelpers.ExtractArrayFromList<float>(values), values.Count);
  }

  public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
  {
    this.SetFloatArray(nameID, values, ((Il2CppArrayBase) values).Length);
  }

  public void SetVectorArray(string name, List<Vector4> values)
  {
    this.SetVectorArray(Shader.PropertyToID(name), (Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(values), values.Count);
  }

  public void SetVectorArray(int nameID, List<Vector4> values)
  {
    this.SetVectorArray(nameID, (Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(values), values.Count);
  }

  public void SetMatrixArray(string name, List<Matrix4x4> values)
  {
    this.SetMatrixArray(Shader.PropertyToID(name), (Il2CppStructArray<Matrix4x4>) NoAllocHelpers.ExtractArrayFromList<Matrix4x4>(values), values.Count);
  }

  public void SetMatrixArray(int nameID, List<Matrix4x4> values)
  {
    this.SetMatrixArray(nameID, (Il2CppStructArray<Matrix4x4>) NoAllocHelpers.ExtractArrayFromList<Matrix4x4>(values), values.Count);
  }

  public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
  {
    this.SetMatrixArray(Shader.PropertyToID(name), values, ((Il2CppArrayBase) values).Length);
  }

  public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
  {
    this.SetMatrixArray(nameID, values, ((Il2CppArrayBase) values).Length);
  }

  public bool HasProperty(int nameID) => this.HasPropertyImpl(nameID);

  public bool HasInt(string name) => this.HasFloatImpl(Shader.PropertyToID(name));

  public bool HasInt(int nameID) => this.HasFloatImpl(nameID);

  public bool HasFloat(string name) => this.HasFloatImpl(Shader.PropertyToID(name));

  public bool HasFloat(int nameID) => this.HasFloatImpl(nameID);

  public bool HasInteger(string name) => this.HasIntImpl(Shader.PropertyToID(name));

  public bool HasInteger(int nameID) => this.HasIntImpl(nameID);

  public bool HasTexture(string name) => this.HasTextureImpl(Shader.PropertyToID(name));

  public bool HasTexture(int nameID) => this.HasTextureImpl(nameID);

  public bool HasMatrix(string name) => this.HasMatrixImpl(Shader.PropertyToID(name));

  public bool HasMatrix(int nameID) => this.HasMatrixImpl(nameID);

  public bool HasVector(string name) => this.HasVectorImpl(Shader.PropertyToID(name));

  public bool HasVector(int nameID) => this.HasVectorImpl(nameID);

  public bool HasColor(string name) => this.HasVectorImpl(Shader.PropertyToID(name));

  public bool HasColor(int nameID) => this.HasVectorImpl(nameID);

  public bool HasBuffer(string name) => this.HasBufferImpl(Shader.PropertyToID(name));

  public bool HasBuffer(int nameID) => this.HasBufferImpl(nameID);

  public bool HasConstantBuffer(string name)
  {
    return this.HasConstantBufferImpl(Shader.PropertyToID(name));
  }

  public bool HasConstantBuffer(int nameID) => this.HasConstantBufferImpl(nameID);

  public float GetFloat(int nameID) => this.GetFloatImpl(nameID);

  public int GetInt(string name) => (int) this.GetFloatImpl(Shader.PropertyToID(name));

  public int GetInt(int nameID) => (int) this.GetFloatImpl(nameID);

  public int GetInteger(string name) => this.GetIntImpl(Shader.PropertyToID(name));

  public int GetInteger(int nameID) => this.GetIntImpl(nameID);

  public Vector4 GetVector(int nameID) => this.GetVectorImpl(nameID);

  public Color GetColor(string name) => this.GetColorImpl(Shader.PropertyToID(name));

  public Color GetColor(int nameID) => this.GetColorImpl(nameID);

  public Matrix4x4 GetMatrix(string name) => this.GetMatrixImpl(Shader.PropertyToID(name));

  public Matrix4x4 GetMatrix(int nameID) => this.GetMatrixImpl(nameID);

  public Texture GetTexture(int nameID) => this.GetTextureImpl(nameID);

  public Il2CppStructArray<float> GetFloatArray(string name)
  {
    return this.GetFloatArray(Shader.PropertyToID(name));
  }

  public Il2CppStructArray<float> GetFloatArray(int nameID)
  {
    return this.GetFloatArrayCountImpl(nameID) != 0 ? this.GetFloatArrayImpl(nameID) : (Il2CppStructArray<float>) null;
  }

  public Il2CppStructArray<Vector4> GetVectorArray(string name)
  {
    return this.GetVectorArray(Shader.PropertyToID(name));
  }

  public Il2CppStructArray<Vector4> GetVectorArray(int nameID)
  {
    return this.GetVectorArrayCountImpl(nameID) != 0 ? this.GetVectorArrayImpl(nameID) : (Il2CppStructArray<Vector4>) null;
  }

  public Il2CppStructArray<Matrix4x4> GetMatrixArray(string name)
  {
    return this.GetMatrixArray(Shader.PropertyToID(name));
  }

  public Il2CppStructArray<Matrix4x4> GetMatrixArray(int nameID)
  {
    return this.GetMatrixArrayCountImpl(nameID) != 0 ? this.GetMatrixArrayImpl(nameID) : (Il2CppStructArray<Matrix4x4>) null;
  }

  public void GetFloatArray(string name, List<float> values)
  {
    this.ExtractFloatArray(Shader.PropertyToID(name), values);
  }

  public void GetFloatArray(int nameID, List<float> values)
  {
    this.ExtractFloatArray(nameID, values);
  }

  public void GetVectorArray(string name, List<Vector4> values)
  {
    this.ExtractVectorArray(Shader.PropertyToID(name), values);
  }

  public void GetVectorArray(int nameID, List<Vector4> values)
  {
    this.ExtractVectorArray(nameID, values);
  }

  public void GetMatrixArray(string name, List<Matrix4x4> values)
  {
    this.ExtractMatrixArray(Shader.PropertyToID(name), values);
  }

  public void GetMatrixArray(int nameID, List<Matrix4x4> values)
  {
    this.ExtractMatrixArray(nameID, values);
  }

  public void CopySHCoefficientArraysFrom(List<SphericalHarmonicsL2> lightProbes)
  {
    if (lightProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (lightProbes));
    this.CopySHCoefficientArraysFrom((Il2CppStructArray<SphericalHarmonicsL2>) NoAllocHelpers.ExtractArrayFromList<SphericalHarmonicsL2>(lightProbes), 0, 0, lightProbes.Count);
  }

  public void CopySHCoefficientArraysFrom(
    Il2CppStructArray<SphericalHarmonicsL2> lightProbes)
  {
    if (lightProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (lightProbes));
    this.CopySHCoefficientArraysFrom(lightProbes, 0, 0, ((Il2CppArrayBase) lightProbes).Length);
  }

  public void CopySHCoefficientArraysFrom(
    List<SphericalHarmonicsL2> lightProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    this.CopySHCoefficientArraysFrom((Il2CppStructArray<SphericalHarmonicsL2>) NoAllocHelpers.ExtractArrayFromList<SphericalHarmonicsL2>(lightProbes), sourceStart, destStart, count);
  }

  public void CopySHCoefficientArraysFrom(
    Il2CppStructArray<SphericalHarmonicsL2> lightProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    if (lightProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (lightProbes));
    if (sourceStart < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (sourceStart), "Argument sourceStart must not be negative.");
    if (destStart < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (sourceStart), "Argument destStart must not be negative.");
    if (count < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (count), "Argument count must not be negative.");
    if (((Il2CppArrayBase) lightProbes).Length < sourceStart + count)
      throw new Il2CppSystem.ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
    MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom(this, lightProbes, sourceStart, destStart, count);
  }

  public void CopyProbeOcclusionArrayFrom(List<Vector4> occlusionProbes)
  {
    if (occlusionProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (occlusionProbes));
    this.CopyProbeOcclusionArrayFrom((Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(occlusionProbes), 0, 0, occlusionProbes.Count);
  }

  public void CopyProbeOcclusionArrayFrom(Il2CppStructArray<Vector4> occlusionProbes)
  {
    if (occlusionProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (occlusionProbes));
    this.CopyProbeOcclusionArrayFrom(occlusionProbes, 0, 0, ((Il2CppArrayBase) occlusionProbes).Length);
  }

  public void CopyProbeOcclusionArrayFrom(
    List<Vector4> occlusionProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    this.CopyProbeOcclusionArrayFrom((Il2CppStructArray<Vector4>) NoAllocHelpers.ExtractArrayFromList<Vector4>(occlusionProbes), sourceStart, destStart, count);
  }

  public void CopyProbeOcclusionArrayFrom(
    Il2CppStructArray<Vector4> occlusionProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    if (occlusionProbes == null)
      throw new Il2CppSystem.ArgumentNullException(nameof (occlusionProbes));
    if (sourceStart < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (sourceStart), "Argument sourceStart must not be negative.");
    if (destStart < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (sourceStart), "Argument destStart must not be negative.");
    if (count < 0)
      throw new Il2CppSystem.ArgumentOutOfRangeException(nameof (count), "Argument count must not be negative.");
    if (((Il2CppArrayBase) occlusionProbes).Length < sourceStart + count)
      throw new Il2CppSystem.ArgumentOutOfRangeException("The specified source start index or count is out of the range.");
    MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom(this, occlusionProbes, sourceStart, destStart, count);
  }

  public static int GetIntImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.GetIntImpl_InjectedDelegateField(_unity_self, name);
  }

  public static void GetColorImpl_Injected(System.IntPtr _unity_self, int name, out Color ret)
  {
    MaterialPropertyBlock.GetColorImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref ret);
  }

  public static void GetMatrixImpl_Injected(System.IntPtr _unity_self, int name, out Matrix4x4 ret)
  {
    MaterialPropertyBlock.GetMatrixImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref ret);
  }

  public static bool HasFloatImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasFloatImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasIntImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasIntImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasTextureImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasTextureImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasMatrixImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasMatrixImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasVectorImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasVectorImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasBufferImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasBufferImpl_InjectedDelegateField(_unity_self, name);
  }

  public static bool HasConstantBufferImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.HasConstantBufferImpl_InjectedDelegateField(_unity_self, name);
  }

  public static void SetMatrixImpl_Injected(System.IntPtr _unity_self, int name, [In] ref Matrix4x4 value)
  {
    MaterialPropertyBlock.SetMatrixImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref value);
  }

  public static void SetGraphicsBufferImpl_Injected(System.IntPtr _unity_self, int name, System.IntPtr value)
  {
    MaterialPropertyBlock.SetGraphicsBufferImpl_InjectedDelegateField(_unity_self, name, value);
  }

  public static void SetConstantGraphicsBufferImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr value,
    int offset,
    int size)
  {
    MaterialPropertyBlock.SetConstantGraphicsBufferImpl_InjectedDelegateField(_unity_self, name, value, offset, size);
  }

  public static void SetMatrixArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    ref ManagedSpanWrapper values,
    int count)
  {
    MaterialPropertyBlock.SetMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref values, count);
  }

  public static void GetFloatArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper ret)
  {
    MaterialPropertyBlock.GetFloatArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref ret);
  }

  public static void GetVectorArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper ret)
  {
    MaterialPropertyBlock.GetVectorArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref ret);
  }

  public static void GetMatrixArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper ret)
  {
    MaterialPropertyBlock.GetMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref ret);
  }

  public static int GetFloatArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.GetFloatArrayCountImpl_InjectedDelegateField(_unity_self, name);
  }

  public static int GetVectorArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.GetVectorArrayCountImpl_InjectedDelegateField(_unity_self, name);
  }

  public static int GetMatrixArrayCountImpl_Injected(System.IntPtr _unity_self, int name)
  {
    return MaterialPropertyBlock.GetMatrixArrayCountImpl_InjectedDelegateField(_unity_self, name);
  }

  public static void ExtractFloatArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper val)
  {
    MaterialPropertyBlock.ExtractFloatArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref val);
  }

  public static void ExtractVectorArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper val)
  {
    MaterialPropertyBlock.ExtractVectorArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref val);
  }

  public static void ExtractMatrixArrayImpl_Injected(
    System.IntPtr _unity_self,
    int name,
    out BlittableArrayWrapper val)
  {
    MaterialPropertyBlock.ExtractMatrixArrayImpl_InjectedDelegateField(_unity_self, name, (System.IntPtr) ref val);
  }

  public static void Internal_CopySHCoefficientArraysFrom_Injected(
    System.IntPtr properties,
    ref ManagedSpanWrapper lightProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    MaterialPropertyBlock.Internal_CopySHCoefficientArraysFrom_InjectedDelegateField(properties, (System.IntPtr) ref lightProbes, sourceStart, destStart, count);
  }

  public static void Internal_CopyProbeOcclusionArrayFrom_Injected(
    System.IntPtr properties,
    ref ManagedSpanWrapper occlusionProbes,
    int sourceStart,
    int destStart,
    int count)
  {
    MaterialPropertyBlock.Internal_CopyProbeOcclusionArrayFrom_InjectedDelegateField(properties, (System.IntPtr) ref occlusionProbes, sourceStart, destStart, count);
  }

  public static class BindingsMarshaller : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0;

    static BindingsMarshaller()
    {
      Il2CppClassPointerStore<MaterialPropertyBlock.BindingsMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MaterialPropertyBlock>.NativeClassPtr, nameof (BindingsMarshaller));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialPropertyBlock.BindingsMarshaller>.NativeClassPtr);
      MaterialPropertyBlock.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialPropertyBlock.BindingsMarshaller>.NativeClassPtr, 100665099 /*0x0600070B*/);
    }

    [CallerCount(0)]
    public static unsafe System.IntPtr ConvertToNative(MaterialPropertyBlock materialPropertyBlock)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) materialPropertyBlock)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MaterialPropertyBlock.BindingsMarshaller.NativeMethodInfoPtr_ConvertToNative_Public_Static_IntPtr_MaterialPropertyBlock_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
    }

    public BindingsMarshaller(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }

  private delegate int GetIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate void GetColorImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

  private delegate void GetMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [Out] System.IntPtr ret);

  private delegate bool HasFloatImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasIntImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasTextureImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasVectorImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate bool HasConstantBufferImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate void SetMatrixImpl_InjectedDelegate(System.IntPtr _unity_self, int name, [In] System.IntPtr value);

  private delegate void SetGraphicsBufferImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr value);

  private delegate void SetConstantGraphicsBufferImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr value,
    int offset,
    int size);

  private delegate void SetMatrixArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    System.IntPtr values,
    int count);

  private delegate void GetFloatArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr ret);

  private delegate void GetVectorArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr ret);

  private delegate void GetMatrixArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr ret);

  private delegate int GetFloatArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate int GetVectorArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate int GetMatrixArrayCountImpl_InjectedDelegate(System.IntPtr _unity_self, int name);

  private delegate void ExtractFloatArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr val);

  private delegate void ExtractVectorArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr val);

  private delegate void ExtractMatrixArrayImpl_InjectedDelegate(
    System.IntPtr _unity_self,
    int name,
    [Out] System.IntPtr val);

  private delegate void Internal_CopySHCoefficientArraysFrom_InjectedDelegate(
    System.IntPtr properties,
    System.IntPtr lightProbes,
    int sourceStart,
    int destStart,
    int count);

  private delegate void Internal_CopyProbeOcclusionArrayFrom_InjectedDelegate(
    System.IntPtr properties,
    System.IntPtr occlusionProbes,
    int sourceStart,
    int destStart,
    int count);
}
