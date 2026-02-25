// Decompiled with JetBrains decompiler
// Type: UnityEngine.Jobs.TransformAccess
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Jobs;

[StructLayout(LayoutKind.Explicit)]
public struct TransformAccess
{
  private static readonly System.IntPtr NativeFieldInfoPtr_hierarchy;
  private static readonly System.IntPtr NativeFieldInfoPtr_index;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0;
  [FieldOffset(0)]
  public System.IntPtr hierarchy;
  [FieldOffset(8)]
  public int index;
  private static readonly TransformAccess.SetPositionAndRotation_InternalDelegate SetPositionAndRotation_InternalDelegateField;
  private static readonly TransformAccess.SetLocalPositionAndRotation_InternalDelegate SetLocalPositionAndRotation_InternalDelegateField;
  private static readonly TransformAccess.GetPositionAndRotation_InternalDelegate GetPositionAndRotation_InternalDelegateField;
  private static readonly TransformAccess.GetLocalPositionAndRotation_InternalDelegate GetLocalPositionAndRotation_InternalDelegateField;
  private static readonly TransformAccess.GetRotationDelegate GetRotationDelegateField;
  private static readonly TransformAccess.SetRotationDelegate SetRotationDelegateField;
  private static readonly TransformAccess.GetLocalPositionDelegate GetLocalPositionDelegateField;
  private static readonly TransformAccess.SetLocalPositionDelegate SetLocalPositionDelegateField;
  private static readonly TransformAccess.GetLocalRotationDelegate GetLocalRotationDelegateField;
  private static readonly TransformAccess.SetLocalRotationDelegate SetLocalRotationDelegateField;
  private static readonly TransformAccess.SetLocalScaleDelegate SetLocalScaleDelegateField;
  private static readonly TransformAccess.GetLocalToWorldMatrixDelegate GetLocalToWorldMatrixDelegateField;
  private static readonly TransformAccess.GetWorldToLocalMatrixDelegate GetWorldToLocalMatrixDelegateField;

  static TransformAccess()
  {
    Il2CppClassPointerStore<TransformAccess>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Jobs", nameof (TransformAccess));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr);
    TransformAccess.NativeFieldInfoPtr_hierarchy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, nameof (hierarchy));
    TransformAccess.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, nameof (index));
    TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668933);
    TransformAccess.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668934);
    TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668935);
    TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668936);
    TransformAccess.NativeMethodInfoPtr_SetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668937);
    TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, 100668938);
    TransformAccess.SetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetPositionAndRotation_Internal");
    TransformAccess.SetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPositionAndRotation_Internal");
    TransformAccess.GetPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetPositionAndRotation_Internal");
    TransformAccess.GetLocalPositionAndRotation_InternalDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionAndRotation_InternalDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPositionAndRotation_Internal");
    TransformAccess.GetRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.GetRotationDelegate>("UnityEngine.Jobs.TransformAccess::GetRotation");
    TransformAccess.SetRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetRotation");
    TransformAccess.GetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalPosition");
    TransformAccess.SetLocalPositionDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalPositionDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalPosition");
    TransformAccess.GetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalRotation");
    TransformAccess.SetLocalRotationDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalRotationDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalRotation");
    TransformAccess.SetLocalScaleDelegateField = IL2CPP.ResolveICall<TransformAccess.SetLocalScaleDelegate>("UnityEngine.Jobs.TransformAccess::SetLocalScale");
    TransformAccess.GetLocalToWorldMatrixDelegateField = IL2CPP.ResolveICall<TransformAccess.GetLocalToWorldMatrixDelegate>("UnityEngine.Jobs.TransformAccess::GetLocalToWorldMatrix");
    TransformAccess.GetWorldToLocalMatrixDelegateField = IL2CPP.ResolveICall<TransformAccess.GetWorldToLocalMatrixDelegate>("UnityEngine.Jobs.TransformAccess::GetWorldToLocalMatrix");
  }

  public unsafe Vector3 position
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472474, RefRangeEnd = 472476, XrefRangeStart = 472472, XrefRangeEnd = 472474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_position_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 472478, RefRangeEnd = 472480, XrefRangeStart = 472476, XrefRangeEnd = 472478, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3 localScale
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 472482, RefRangeEnd = 472484, XrefRangeStart = 472480, XrefRangeEnd = 472482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_get_localScale_Public_get_Vector3_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => TransformAccess.SetLocalScale(ref this, ref value);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472484, XrefRangeEnd = 472486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetPosition(ref TransformAccess access, out Vector3 p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref access;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref p;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472486, XrefRangeEnd = 472488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPosition(ref TransformAccess access, ref Vector3 p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref access;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref p;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_SetPosition_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472488, XrefRangeEnd = 472490, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void GetLocalScale(ref TransformAccess access, out Vector3 r)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) ref access;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref r;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TransformAccess.NativeMethodInfoPtr_GetLocalScale_Private_Static_Void_byref_TransformAccess_byref_Vector3_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TransformAccess>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Quaternion rotation
  {
    get
    {
      Quaternion r;
      TransformAccess.GetRotation(ref this, out r);
      return r;
    }
    set => TransformAccess.SetRotation(ref this, ref value);
  }

  public Vector3 localPosition
  {
    get
    {
      Vector3 p;
      TransformAccess.GetLocalPosition(ref this, out p);
      return p;
    }
    set => TransformAccess.SetLocalPosition(ref this, ref value);
  }

  public Quaternion localRotation
  {
    get
    {
      Quaternion r;
      TransformAccess.GetLocalRotation(ref this, out r);
      return r;
    }
    set => TransformAccess.SetLocalRotation(ref this, ref value);
  }

  public Matrix4x4 localToWorldMatrix
  {
    get
    {
      Matrix4x4 m;
      TransformAccess.GetLocalToWorldMatrix(ref this, out m);
      return m;
    }
  }

  public Matrix4x4 worldToLocalMatrix
  {
    get
    {
      Matrix4x4 m;
      TransformAccess.GetWorldToLocalMatrix(ref this, out m);
      return m;
    }
  }

  public bool isValid => this.hierarchy != Il2CppSystem.IntPtr.Zero;

  public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
  {
    TransformAccess.SetPositionAndRotation_Internal(ref this, ref position, ref rotation);
  }

  public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
  {
    TransformAccess.SetLocalPositionAndRotation_Internal(ref this, ref localPosition, ref localRotation);
  }

  public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
  {
    TransformAccess.GetPositionAndRotation_Internal(ref this, out position, out rotation);
  }

  public void GetLocalPositionAndRotation(out Vector3 localPosition, out Quaternion localRotation)
  {
    TransformAccess.GetLocalPositionAndRotation_Internal(ref this, out localPosition, out localRotation);
  }

  public static void SetPositionAndRotation_Internal(
    ref TransformAccess access,
    ref Vector3 position,
    ref Quaternion rotation)
  {
    TransformAccess.SetPositionAndRotation_InternalDelegateField((System.IntPtr) ref access, (System.IntPtr) ref position, (System.IntPtr) ref rotation);
  }

  public static void SetLocalPositionAndRotation_Internal(
    ref TransformAccess access,
    ref Vector3 localPosition,
    ref Quaternion localRotation)
  {
    TransformAccess.SetLocalPositionAndRotation_InternalDelegateField((System.IntPtr) ref access, (System.IntPtr) ref localPosition, (System.IntPtr) ref localRotation);
  }

  public static void GetPositionAndRotation_Internal(
    ref TransformAccess access,
    out Vector3 position,
    out Quaternion rotation)
  {
    TransformAccess.GetPositionAndRotation_InternalDelegateField((System.IntPtr) ref access, (System.IntPtr) ref position, (System.IntPtr) ref rotation);
  }

  public static void GetLocalPositionAndRotation_Internal(
    ref TransformAccess access,
    out Vector3 localPosition,
    out Quaternion localRotation)
  {
    TransformAccess.GetLocalPositionAndRotation_InternalDelegateField((System.IntPtr) ref access, (System.IntPtr) ref localPosition, (System.IntPtr) ref localRotation);
  }

  public static void GetRotation(ref TransformAccess access, out Quaternion r)
  {
    TransformAccess.GetRotationDelegateField((System.IntPtr) ref access, (System.IntPtr) ref r);
  }

  public static void SetRotation(ref TransformAccess access, ref Quaternion r)
  {
    TransformAccess.SetRotationDelegateField((System.IntPtr) ref access, (System.IntPtr) ref r);
  }

  public static void GetLocalPosition(ref TransformAccess access, out Vector3 p)
  {
    TransformAccess.GetLocalPositionDelegateField((System.IntPtr) ref access, (System.IntPtr) ref p);
  }

  public static void SetLocalPosition(ref TransformAccess access, ref Vector3 p)
  {
    TransformAccess.SetLocalPositionDelegateField((System.IntPtr) ref access, (System.IntPtr) ref p);
  }

  public static void GetLocalRotation(ref TransformAccess access, out Quaternion r)
  {
    TransformAccess.GetLocalRotationDelegateField((System.IntPtr) ref access, (System.IntPtr) ref r);
  }

  public static void SetLocalRotation(ref TransformAccess access, ref Quaternion r)
  {
    TransformAccess.SetLocalRotationDelegateField((System.IntPtr) ref access, (System.IntPtr) ref r);
  }

  public static void SetLocalScale(ref TransformAccess access, ref Vector3 r)
  {
    TransformAccess.SetLocalScaleDelegateField((System.IntPtr) ref access, (System.IntPtr) ref r);
  }

  public static void GetLocalToWorldMatrix(ref TransformAccess access, out Matrix4x4 m)
  {
    TransformAccess.GetLocalToWorldMatrixDelegateField((System.IntPtr) ref access, (System.IntPtr) ref m);
  }

  public static void GetWorldToLocalMatrix(ref TransformAccess access, out Matrix4x4 m)
  {
    TransformAccess.GetWorldToLocalMatrixDelegateField((System.IntPtr) ref access, (System.IntPtr) ref m);
  }

  public void CheckHierarchyValid()
  {
    if (!this.isValid)
      throw new Il2CppSystem.NullReferenceException("The TransformAccess is not valid and points to an invalid hierarchy");
  }

  public void MarkReadWrite()
  {
  }

  public void MarkReadOnly()
  {
  }

  public void CheckWriteAccess()
  {
  }

  private delegate void SetPositionAndRotation_InternalDelegate(
    System.IntPtr access,
    System.IntPtr position,
    System.IntPtr rotation);

  private delegate void SetLocalPositionAndRotation_InternalDelegate(
    System.IntPtr access,
    System.IntPtr localPosition,
    System.IntPtr localRotation);

  private delegate void GetPositionAndRotation_InternalDelegate(
    System.IntPtr access,
    [Out] System.IntPtr position,
    [Out] System.IntPtr rotation);

  private delegate void GetLocalPositionAndRotation_InternalDelegate(
    System.IntPtr access,
    [Out] System.IntPtr localPosition,
    [Out] System.IntPtr localRotation);

  private delegate void GetRotationDelegate(System.IntPtr access, [Out] System.IntPtr r);

  private delegate void SetRotationDelegate(System.IntPtr access, System.IntPtr r);

  private delegate void GetLocalPositionDelegate(System.IntPtr access, [Out] System.IntPtr p);

  private delegate void SetLocalPositionDelegate(System.IntPtr access, System.IntPtr p);

  private delegate void GetLocalRotationDelegate(System.IntPtr access, [Out] System.IntPtr r);

  private delegate void SetLocalRotationDelegate(System.IntPtr access, System.IntPtr r);

  private delegate void SetLocalScaleDelegate(System.IntPtr access, System.IntPtr r);

  private delegate void GetLocalToWorldMatrixDelegate(System.IntPtr access, [Out] System.IntPtr m);

  private delegate void GetWorldToLocalMatrixDelegate(System.IntPtr access, [Out] System.IntPtr m);
}
