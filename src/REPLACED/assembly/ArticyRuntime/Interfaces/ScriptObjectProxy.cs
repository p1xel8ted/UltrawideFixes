// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.ScriptObjectProxy
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Interfaces;

public class ScriptObjectProxy(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mTarget;
  private static readonly System.IntPtr NativeFieldInfoPtr_mInstanceId;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BaseGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_IPropertyProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyObject_ScriptObjectProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptObjectProxy_ArticyObject_0;

  static ScriptObjectProxy()
  {
    Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (ScriptObjectProxy));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr);
    ScriptObjectProxy.NativeFieldInfoPtr_mTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, nameof (mTarget));
    ScriptObjectProxy.NativeFieldInfoPtr_mInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, nameof (mInstanceId));
    ScriptObjectProxy.NativeMethodInfoPtr__ctor_Public_Void_String_BaseGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, 100664452);
    ScriptObjectProxy.NativeMethodInfoPtr__ctor_Public_Void_IPropertyProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, 100664453);
    ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, 100664454);
    ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyObject_ScriptObjectProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, 100664455);
    ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptObjectProxy_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr, 100664456);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999504, XrefRangeEnd = 999523, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptObjectProxy(string aStr, BaseGlobalVariables aVariables)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aStr);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVariables);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptObjectProxy.NativeMethodInfoPtr__ctor_Public_Void_String_BaseGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(125)]
  [CachedScanResults(RefRangeStart = 68812, RefRangeEnd = 68937, XrefRangeStart = 68812, XrefRangeEnd = 68937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptObjectProxy(IPropertyProvider aPropProvider)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptObjectProxy>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aPropProvider)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptObjectProxy.NativeMethodInfoPtr__ctor_Public_Void_IPropertyProvider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999523, XrefRangeEnd = 999534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator string(ScriptObjectProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptObjectProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(32 /*0x20*/)]
  [CachedScanResults(RefRangeStart = 999536, RefRangeEnd = 999568, XrefRangeStart = 999534, XrefRangeEnd = 999536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ArticyObject(ScriptObjectProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ArticyObject_ScriptObjectProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
  }

  [CallerCount(24)]
  [CachedScanResults(RefRangeStart = 999572, RefRangeEnd = 999596, XrefRangeStart = 999568, XrefRangeEnd = 999572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptObjectProxy(ArticyObject aObject)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObject)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptObjectProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptObjectProxy_ArticyObject_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptObjectProxy) null : Il2CppObjectPool.Get<ScriptObjectProxy>(num3);
  }

  public unsafe IPropertyProvider mTarget
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptObjectProxy.NativeFieldInfoPtr_mTarget));
      return num == System.IntPtr.Zero ? (IPropertyProvider) null : Il2CppObjectPool.Get<IPropertyProvider>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptObjectProxy.NativeFieldInfoPtr_mTarget), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe uint mInstanceId
  {
    get
    {
      return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptObjectProxy.NativeFieldInfoPtr_mInstanceId));
    }
    [param: In] set
    {
      *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptObjectProxy.NativeFieldInfoPtr_mInstanceId)) = value;
    }
  }
}
