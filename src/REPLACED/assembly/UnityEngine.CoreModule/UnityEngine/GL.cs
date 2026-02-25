// Decompiled with JetBrains decompiler
// Type: UnityEngine.GL
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class GL(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Color_Public_Static_Void_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0;
  public const int TRIANGLES = 4;
  public const int TRIANGLE_STRIP = 5;
  public const int QUADS = 7;
  public const int LINES = 1;
  public const int LINE_STRIP = 2;
  private static readonly GL.VerticesDelegate VerticesDelegateField;
  private static readonly GL.MultiTexCoord3Delegate MultiTexCoord3DelegateField;
  private static readonly GL.get_wireframeDelegate get_wireframeDelegateField;
  private static readonly GL.set_wireframeDelegate set_wireframeDelegateField;
  private static readonly GL.get_sRGBWriteDelegate get_sRGBWriteDelegateField;
  private static readonly GL.set_sRGBWriteDelegate set_sRGBWriteDelegateField;
  private static readonly GL.get_invertCullingDelegate get_invertCullingDelegateField;
  private static readonly GL.set_invertCullingDelegate set_invertCullingDelegateField;
  private static readonly GL.FlushDelegate FlushDelegateField;
  private static readonly GL.RenderTargetBarrierDelegate RenderTargetBarrierDelegateField;
  private static readonly GL.IssuePluginEventDelegate IssuePluginEventDelegateField;
  private static readonly GL.SetRevertBackfacingDelegate SetRevertBackfacingDelegateField;
  private static readonly GL.LoadIdentityDelegate LoadIdentityDelegateField;
  private static readonly GL.LoadPixelMatrixDelegate LoadPixelMatrixDelegateField;
  private static readonly GL.InvalidateStateDelegate InvalidateStateDelegateField;
  private static readonly GL.GLIssuePluginEventDelegate GLIssuePluginEventDelegateField;
  private static readonly GL.GetWorldViewMatrix_InjectedDelegate GetWorldViewMatrix_InjectedDelegateField;
  private static readonly GL.MultMatrix_InjectedDelegate MultMatrix_InjectedDelegateField;
  private static readonly GL.ClearWithSkybox_InjectedDelegate ClearWithSkybox_InjectedDelegateField;

  static GL()
  {
    Il2CppClassPointerStore<GL>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (GL));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GL>.NativeClassPtr);
    GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664730);
    GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664731);
    GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664732);
    GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664733);
    GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664734);
    GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664735);
    GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664736 /*0x060005A0*/);
    GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664737);
    GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664738);
    GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664739);
    GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664740);
    GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664741);
    GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664742);
    GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664743);
    GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664744);
    GL.NativeMethodInfoPtr_End_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664745);
    GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664746);
    GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664747);
    GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664748);
    GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664749);
    GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664750);
    GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664751);
    GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664752 /*0x060005B0*/);
    GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664753);
    GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GL>.NativeClassPtr, 100664754);
    GL.VerticesDelegateField = IL2CPP.ResolveICall<GL.VerticesDelegate>("UnityEngine.GL::Vertices");
    GL.MultiTexCoord3DelegateField = IL2CPP.ResolveICall<GL.MultiTexCoord3Delegate>("UnityEngine.GL::MultiTexCoord3");
    GL.get_wireframeDelegateField = IL2CPP.ResolveICall<GL.get_wireframeDelegate>("UnityEngine.GL::get_wireframe");
    GL.set_wireframeDelegateField = IL2CPP.ResolveICall<GL.set_wireframeDelegate>("UnityEngine.GL::set_wireframe");
    GL.get_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.get_sRGBWriteDelegate>("UnityEngine.GL::get_sRGBWrite");
    GL.set_sRGBWriteDelegateField = IL2CPP.ResolveICall<GL.set_sRGBWriteDelegate>("UnityEngine.GL::set_sRGBWrite");
    GL.get_invertCullingDelegateField = IL2CPP.ResolveICall<GL.get_invertCullingDelegate>("UnityEngine.GL::get_invertCulling");
    GL.set_invertCullingDelegateField = IL2CPP.ResolveICall<GL.set_invertCullingDelegate>("UnityEngine.GL::set_invertCulling");
    GL.FlushDelegateField = IL2CPP.ResolveICall<GL.FlushDelegate>("UnityEngine.GL::Flush");
    GL.RenderTargetBarrierDelegateField = IL2CPP.ResolveICall<GL.RenderTargetBarrierDelegate>("UnityEngine.GL::RenderTargetBarrier");
    GL.IssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.IssuePluginEventDelegate>("UnityEngine.GL::IssuePluginEvent");
    GL.SetRevertBackfacingDelegateField = IL2CPP.ResolveICall<GL.SetRevertBackfacingDelegate>("UnityEngine.GL::SetRevertBackfacing");
    GL.LoadIdentityDelegateField = IL2CPP.ResolveICall<GL.LoadIdentityDelegate>("UnityEngine.GL::LoadIdentity");
    GL.LoadPixelMatrixDelegateField = IL2CPP.ResolveICall<GL.LoadPixelMatrixDelegate>("UnityEngine.GL::LoadPixelMatrix");
    GL.InvalidateStateDelegateField = IL2CPP.ResolveICall<GL.InvalidateStateDelegate>("UnityEngine.GL::InvalidateState");
    GL.GLIssuePluginEventDelegateField = IL2CPP.ResolveICall<GL.GLIssuePluginEventDelegate>("UnityEngine.GL::GLIssuePluginEvent");
    GL.GetWorldViewMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.GetWorldViewMatrix_InjectedDelegate>("UnityEngine.GL::GetWorldViewMatrix_Injected");
    GL.MultMatrix_InjectedDelegateField = IL2CPP.ResolveICall<GL.MultMatrix_InjectedDelegate>("UnityEngine.GL::MultMatrix_Injected");
    GL.ClearWithSkybox_InjectedDelegateField = IL2CPP.ResolveICall<GL.ClearWithSkybox_InjectedDelegate>("UnityEngine.GL::ClearWithSkybox_Injected");
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 423561, RefRangeEnd = 423569, XrefRangeStart = 423559, XrefRangeEnd = 423561, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Vertex3(float x, float y, float z)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Vertex3_Public_Static_Void_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 423571, RefRangeEnd = 423575, XrefRangeStart = 423569, XrefRangeEnd = 423571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TexCoord3(float x, float y, float z)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &z;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord3_Public_Static_Void_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 423577, RefRangeEnd = 423581, XrefRangeStart = 423575, XrefRangeEnd = 423577, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void TexCoord2(float x, float y)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &x;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &y;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_TexCoord2_Public_Static_Void_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423581, XrefRangeEnd = 423583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ImmediateColor(float r, float g, float b, float a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_ImmediateColor_Private_Static_Void_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 423585, RefRangeEnd = 423589, XrefRangeStart = 423583, XrefRangeEnd = 423585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Color(UnityEngine.Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Color_Public_Static_Void_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423589, XrefRangeEnd = 423591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetViewMatrix(Matrix4x4 m)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &m
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Private_Static_Void_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe Matrix4x4 modelview
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 423593, RefRangeEnd = 423597, XrefRangeStart = 423591, XrefRangeEnd = 423593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_set_modelview_Public_Static_set_Void_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => GL.GetWorldViewMatrix();
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423599, RefRangeEnd = 423601, XrefRangeStart = 423597, XrefRangeEnd = 423599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PushMatrix()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PushMatrix_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423603, RefRangeEnd = 423605, XrefRangeStart = 423601, XrefRangeEnd = 423603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PopMatrix()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_PopMatrix_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423607, RefRangeEnd = 423608, XrefRangeStart = 423605, XrefRangeEnd = 423607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadOrtho()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadOrtho_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 423610, RefRangeEnd = 423613, XrefRangeStart = 423608, XrefRangeEnd = 423610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadProjectionMatrix(Matrix4x4 mat)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mat
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Public_Static_Void_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(9)]
  [CachedScanResults(RefRangeStart = 423615, RefRangeEnd = 423624, XrefRangeStart = 423613, XrefRangeEnd = 423615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Matrix4x4 GetGPUProjectionMatrix(Matrix4x4 proj, bool renderIntoTexture)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &proj;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderIntoTexture;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Public_Static_Matrix4x4_Matrix4x4_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Matrix4x4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423626, RefRangeEnd = 423627, XrefRangeStart = 423624, XrefRangeEnd = 423626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GLLoadPixelMatrixScript(
    float left,
    float right,
    float bottom,
    float top)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &top;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLLoadPixelMatrixScript_Private_Static_Void_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423626, RefRangeEnd = 423627, XrefRangeStart = 423626, XrefRangeEnd = 423627, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadPixelMatrix(float left, float right, float bottom, float top)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &bottom;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &top;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadPixelMatrix_Public_Static_Void_Single_Single_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423629, RefRangeEnd = 423631, XrefRangeStart = 423627, XrefRangeEnd = 423629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Begin(int mode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &mode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Begin_Public_Static_Void_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423633, RefRangeEnd = 423635, XrefRangeStart = 423631, XrefRangeEnd = 423633, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void End()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_End_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423635, XrefRangeEnd = 423637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GLClear(
    bool clearDepth,
    bool clearColor,
    UnityEngine.Color backgroundColor,
    float depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &clearDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clearColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &backgroundColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Private_Static_Void_Boolean_Boolean_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 423639, RefRangeEnd = 423640, XrefRangeStart = 423637, XrefRangeEnd = 423639, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear(
    bool clearDepth,
    bool clearColor,
    UnityEngine.Color backgroundColor,
    float depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &clearDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clearColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &backgroundColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423642, RefRangeEnd = 423644, XrefRangeStart = 423640, XrefRangeEnd = 423642, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Clear(bool clearDepth, bool clearColor, UnityEngine.Color backgroundColor)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &clearDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clearColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &backgroundColor;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Clear_Public_Static_Void_Boolean_Boolean_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 423646, RefRangeEnd = 423648, XrefRangeStart = 423644, XrefRangeEnd = 423646, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Viewport(Rect pixelRect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &pixelRect
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Public_Static_Void_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423648, XrefRangeEnd = 423650, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetViewMatrix_Injected([In] ref Matrix4x4 m)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref m
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_SetViewMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423650, XrefRangeEnd = 423652, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void LoadProjectionMatrix_Injected([In] ref Matrix4x4 mat)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref mat
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_LoadProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423652, XrefRangeEnd = 423654, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetGPUProjectionMatrix_Injected(
    [In] ref Matrix4x4 proj,
    bool renderIntoTexture,
    out Matrix4x4 ret)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) ref proj;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &renderIntoTexture;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref ret;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GetGPUProjectionMatrix_Injected_Private_Static_Void_byref_Matrix4x4_Boolean_byref_Matrix4x4_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423654, XrefRangeEnd = 423656, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GLClear_Injected(
    bool clearDepth,
    bool clearColor,
    [In] ref UnityEngine.Color backgroundColor,
    float depth)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &clearDepth;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clearColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref backgroundColor;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &depth;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_GLClear_Injected_Private_Static_Void_Boolean_Boolean_byref_Color_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 423656, XrefRangeEnd = 423658, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Viewport_Injected([In] ref Rect pixelRect)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) ref pixelRect
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(GL.NativeMethodInfoPtr_Viewport_Injected_Private_Static_Void_byref_Rect_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static void Vertex(Vector3 v) => GL.Vertex3(v.x, v.y, v.z);

  public static unsafe void Vertices(Vector3* v, Vector3* coords, Vector4* colors, int length)
  {
    GL.VerticesDelegateField((System.IntPtr) v, (System.IntPtr) coords, (System.IntPtr) colors, length);
  }

  public static void TexCoord(Vector3 v) => GL.TexCoord3(v.x, v.y, v.z);

  public static void MultiTexCoord3(int unit, float x, float y, float z)
  {
    GL.MultiTexCoord3DelegateField(unit, x, y, z);
  }

  public static void MultiTexCoord(int unit, Vector3 v) => GL.MultiTexCoord3(unit, v.x, v.y, v.z);

  public static void MultiTexCoord2(int unit, float x, float y)
  {
    GL.MultiTexCoord3(unit, x, y, 0.0f);
  }

  public static bool wireframe
  {
    get => GL.get_wireframeDelegateField();
    set => GL.set_wireframeDelegateField(value);
  }

  public static bool sRGBWrite
  {
    get => GL.get_sRGBWriteDelegateField();
    set => GL.set_sRGBWriteDelegateField(value);
  }

  public static bool invertCulling
  {
    get => GL.get_invertCullingDelegateField();
    set => GL.set_invertCullingDelegateField(value);
  }

  public static void Flush() => GL.FlushDelegateField();

  public static void RenderTargetBarrier() => GL.RenderTargetBarrierDelegateField();

  public static Matrix4x4 GetWorldViewMatrix()
  {
    Matrix4x4 ret;
    GL.GetWorldViewMatrix_Injected(out ret);
    return ret;
  }

  public static void MultMatrix(Matrix4x4 m) => GL.MultMatrix_Injected(ref m);

  public static void IssuePluginEvent(int eventID) => GL.IssuePluginEventDelegateField(eventID);

  public static void SetRevertBackfacing(bool revertBackFaces)
  {
    GL.SetRevertBackfacingDelegateField(revertBackFaces);
  }

  public static void LoadIdentity() => GL.LoadIdentityDelegateField();

  public static void LoadPixelMatrix() => GL.LoadPixelMatrixDelegateField();

  public static void InvalidateState() => GL.InvalidateStateDelegateField();

  public static void GLIssuePluginEvent(System.IntPtr callback, int eventID)
  {
    GL.GLIssuePluginEventDelegateField(callback, eventID);
  }

  public static void IssuePluginEvent(System.IntPtr callback, int eventID)
  {
    if (callback == Il2CppSystem.IntPtr.Zero)
      throw new Il2CppSystem.ArgumentException("Null callback specified.", nameof (callback));
    GL.GLIssuePluginEvent(callback, eventID);
  }

  public static void ClearWithSkybox(bool clearDepth, Camera camera)
  {
    GL.ClearWithSkybox_Injected(clearDepth, Object.MarshalledUnityObject.Marshal<Camera>(camera));
  }

  public static void GetWorldViewMatrix_Injected(out Matrix4x4 ret)
  {
    GL.GetWorldViewMatrix_InjectedDelegateField((System.IntPtr) ref ret);
  }

  public static void MultMatrix_Injected([In] ref Matrix4x4 m)
  {
    GL.MultMatrix_InjectedDelegateField((System.IntPtr) ref m);
  }

  public static void ClearWithSkybox_Injected(bool clearDepth, System.IntPtr camera)
  {
    GL.ClearWithSkybox_InjectedDelegateField(clearDepth, camera);
  }

  private delegate void VerticesDelegate(System.IntPtr v, System.IntPtr coords, System.IntPtr colors, int length);

  private delegate void MultiTexCoord3Delegate(int unit, float x, float y, float z);

  private delegate bool get_wireframeDelegate();

  private delegate void set_wireframeDelegate(bool value);

  private delegate bool get_sRGBWriteDelegate();

  private delegate void set_sRGBWriteDelegate(bool value);

  private delegate bool get_invertCullingDelegate();

  private delegate void set_invertCullingDelegate(bool value);

  private delegate void FlushDelegate();

  private delegate void RenderTargetBarrierDelegate();

  private delegate void IssuePluginEventDelegate(int eventID);

  private delegate void SetRevertBackfacingDelegate(bool revertBackFaces);

  private delegate void LoadIdentityDelegate();

  private delegate void LoadPixelMatrixDelegate();

  private delegate void InvalidateStateDelegate();

  private delegate void GLIssuePluginEventDelegate(System.IntPtr callback, int eventID);

  private delegate void GetWorldViewMatrix_InjectedDelegate([Out] System.IntPtr ret);

  private delegate void MultMatrix_InjectedDelegate([In] System.IntPtr m);

  private delegate void ClearWithSkybox_InjectedDelegate(bool clearDepth, System.IntPtr camera);
}
