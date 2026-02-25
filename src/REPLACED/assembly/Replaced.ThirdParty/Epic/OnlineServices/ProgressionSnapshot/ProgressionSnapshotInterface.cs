// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.ProgressionSnapshot.ProgressionSnapshotInterface
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.ProgressionSnapshot;

public sealed class ProgressionSnapshotInterface(System.IntPtr pointer) : Handle(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_AddprogressionApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_BeginsnapshotApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_DeletesnapshotApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_EndsnapshotApiLatest;
  private static readonly System.IntPtr NativeFieldInfoPtr_InvalidProgressionsnapshotid;
  private static readonly System.IntPtr NativeFieldInfoPtr_SubmitsnapshotApiLatest;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AddProgression_Public_Result_AddProgressionOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginSnapshot_Public_Result_BeginSnapshotOptions_byref_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DeleteSnapshot_Public_Void_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndSnapshot_Public_Result_EndSnapshotOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SubmitSnapshot_Public_Void_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0;

  static ProgressionSnapshotInterface()
  {
    Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.ProgressionSnapshot", nameof (ProgressionSnapshotInterface));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr);
    ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (AddprogressionApiLatest));
    ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (BeginsnapshotApiLatest));
    ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (DeletesnapshotApiLatest));
    ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (EndsnapshotApiLatest));
    ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (InvalidProgressionsnapshotid));
    ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, nameof (SubmitsnapshotApiLatest));
    ProgressionSnapshotInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667203);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_AddProgression_Public_Result_AddProgressionOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667205);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_BeginSnapshot_Public_Result_BeginSnapshotOptions_byref_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667206);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_DeleteSnapshot_Public_Void_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667207);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_EndSnapshot_Public_Result_EndSnapshotOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667208);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_SubmitSnapshot_Public_Void_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667209);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667210);
    ProgressionSnapshotInterface.NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr, 100667211);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ProgressionSnapshotInterface()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProgressionSnapshotInterface>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382930, XrefRangeEnd = 382938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result AddProgression(AddProgressionOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_AddProgression_Public_Result_AddProgressionOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382938, XrefRangeEnd = 382949, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result BeginSnapshot(BeginSnapshotOptions options, out uint outSnapshotId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref outSnapshotId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_BeginSnapshot_Public_Result_BeginSnapshotOptions_byref_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382949, XrefRangeEnd = 382968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void DeleteSnapshot(
    DeleteSnapshotOptions options,
    Il2CppSystem.Object clientData,
    OnDeleteSnapshotCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_DeleteSnapshot_Public_Void_DeleteSnapshotOptions_Object_OnDeleteSnapshotCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382968, XrefRangeEnd = 382976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Result EndSnapshot(EndSnapshotOptions options)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_EndSnapshot_Public_Result_EndSnapshotOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382976, XrefRangeEnd = 382995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SubmitSnapshot(
    SubmitSnapshotOptions options,
    Il2CppSystem.Object clientData,
    OnSubmitSnapshotCallback completionDelegate)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) clientData);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) completionDelegate);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_SubmitSnapshot_Public_Void_SubmitSnapshotOptions_Object_OnSubmitSnapshotCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 382995, XrefRangeEnd = 383001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnDeleteSnapshotCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_OnDeleteSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 383001, XrefRangeEnd = 383007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void OnSubmitSnapshotCallbackInternalImplementation(System.IntPtr data)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &data
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ProgressionSnapshotInterface.NativeMethodInfoPtr_OnSubmitSnapshotCallbackInternalImplementation_Internal_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe int AddprogressionApiLatest
  {
    get
    {
      int addprogressionApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest, (void*) &addprogressionApiLatest);
      return addprogressionApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_AddprogressionApiLatest, (void*) &value);
    }
  }

  public static unsafe int BeginsnapshotApiLatest
  {
    get
    {
      int beginsnapshotApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest, (void*) &beginsnapshotApiLatest);
      return beginsnapshotApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_BeginsnapshotApiLatest, (void*) &value);
    }
  }

  public static unsafe int DeletesnapshotApiLatest
  {
    get
    {
      int deletesnapshotApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest, (void*) &deletesnapshotApiLatest);
      return deletesnapshotApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_DeletesnapshotApiLatest, (void*) &value);
    }
  }

  public static unsafe int EndsnapshotApiLatest
  {
    get
    {
      int endsnapshotApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest, (void*) &endsnapshotApiLatest);
      return endsnapshotApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_EndsnapshotApiLatest, (void*) &value);
    }
  }

  public static unsafe int InvalidProgressionsnapshotid
  {
    get
    {
      int progressionsnapshotid;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid, (void*) &progressionsnapshotid);
      return progressionsnapshotid;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_InvalidProgressionsnapshotid, (void*) &value);
    }
  }

  public static unsafe int SubmitsnapshotApiLatest
  {
    get
    {
      int submitsnapshotApiLatest;
      IL2CPP.il2cpp_field_static_get_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest, (void*) &submitsnapshotApiLatest);
      return submitsnapshotApiLatest;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ProgressionSnapshotInterface.NativeFieldInfoPtr_SubmitsnapshotApiLatest, (void*) &value);
    }
  }
}
