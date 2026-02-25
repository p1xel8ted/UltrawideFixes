// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.ScriptDataProxy
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

public class ScriptDataProxy(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_Logger;
  private static readonly System.IntPtr NativeFieldInfoPtr_mUnderlyingData;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_UnderlyingData_Internal_get_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ScriptDataProxy_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt16_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Char_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Double_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Decimal_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptDataProxy_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_String_0;

  static ScriptDataProxy()
  {
    Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (ScriptDataProxy));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr);
    ScriptDataProxy.NativeFieldInfoPtr_Logger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, nameof (Logger));
    ScriptDataProxy.NativeFieldInfoPtr_mUnderlyingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, nameof (mUnderlyingData));
    ScriptDataProxy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664412);
    ScriptDataProxy.NativeMethodInfoPtr__ctor_Public_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664413);
    ScriptDataProxy.NativeMethodInfoPtr_get_UnderlyingData_Internal_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664414);
    ScriptDataProxy.NativeMethodInfoPtr_op_Addition_Public_Static_ScriptDataProxy_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664415);
    ScriptDataProxy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664416 /*0x06000460*/);
    ScriptDataProxy.NativeMethodInfoPtr_Equals_Public_Boolean_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664417);
    ScriptDataProxy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664418);
    ScriptDataProxy.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664419);
    ScriptDataProxy.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664420);
    ScriptDataProxy.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664421);
    ScriptDataProxy.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664422);
    ScriptDataProxy.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664423);
    ScriptDataProxy.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664424);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664425);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664426);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664427);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664428);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664429);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664430);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664431);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664432 /*0x06000470*/);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664433);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664434);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664435);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664436);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664437);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664438);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664439);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664440);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664441);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664442);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664443);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664444);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664445);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Decimal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664446);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664447);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664448 /*0x06000480*/);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptDataProxy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664449);
    ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr, 100664450);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDataProxy()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(31 /*0x1F*/)]
  [CachedScanResults(RefRangeStart = 999253, RefRangeEnd = 999284, XrefRangeStart = 999243, XrefRangeEnd = 999253, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptDataProxy(Il2CppSystem.Object aObj)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptDataProxy>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aObj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr__ctor_Public_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Object UnderlyingData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_get_UnderlyingData_Internal_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
    }
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999319, RefRangeEnd = 999321, XrefRangeStart = 999284, XrefRangeEnd = 999319, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ScriptDataProxy operator +(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Addition_Public_Static_ScriptDataProxy_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999321, XrefRangeEnd = 999323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe bool Equals(Il2CppSystem.Object obj)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptDataProxy.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public unsafe bool Equals(ScriptDataProxy p)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) p)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_Equals_Public_Boolean_ScriptDataProxy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public override unsafe int GetHashCode()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScriptDataProxy.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999323, XrefRangeEnd = 999326, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999326, XrefRangeEnd = 999332, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999332, XrefRangeEnd = 999335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator >=(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999335, XrefRangeEnd = 999341, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator <=(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999347, RefRangeEnd = 999349, XrefRangeStart = 999341, XrefRangeEnd = 999347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999349, XrefRangeEnd = 999353, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator !=(ScriptDataProxy a1, ScriptDataProxy a2)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a1);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) a2);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_ScriptDataProxy_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999353, XrefRangeEnd = 999358, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator int(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int32_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 999364, RefRangeEnd = 999365, XrefRangeStart = 999358, XrefRangeEnd = 999364, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(int d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999365, XrefRangeEnd = 999370, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator uint(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt32_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(uint*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999370, XrefRangeEnd = 999376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(uint d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999376, XrefRangeEnd = 999381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator short(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int16_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(short*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999381, XrefRangeEnd = 999387, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(short d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int16_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999387, XrefRangeEnd = 999392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ushort(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt16_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ushort*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999392, XrefRangeEnd = 999398, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(ushort d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt16_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999398, XrefRangeEnd = 999403, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator long(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Int64_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(long*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999403, XrefRangeEnd = 999409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(long d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Int64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999409, XrefRangeEnd = 999414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ulong(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999414, XrefRangeEnd = 999420, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(ulong d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_UInt64_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999420, XrefRangeEnd = 999425, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator byte(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Byte_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(byte*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999425, XrefRangeEnd = 999431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(byte d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Byte_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999431, XrefRangeEnd = 999436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator char(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Char_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(char*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999436, XrefRangeEnd = 999442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(char d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Char_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999442, XrefRangeEnd = 999447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator float(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Single_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 999453, RefRangeEnd = 999455, XrefRangeStart = 999447, XrefRangeEnd = 999453, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(float d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Single_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999455, XrefRangeEnd = 999460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator double(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Double_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(double*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999460, XrefRangeEnd = 999466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(double d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Double_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999466, XrefRangeEnd = 999476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Il2CppSystem.Decimal(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Decimal_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Il2CppSystem.Decimal*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999476, XrefRangeEnd = 999483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(Il2CppSystem.Decimal d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Decimal_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999483, XrefRangeEnd = 999488, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator bool(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_Boolean_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999488, XrefRangeEnd = 999494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(bool d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &d
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999494, XrefRangeEnd = 999500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator string(ScriptDataProxy d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_String_ScriptDataProxy_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999500, XrefRangeEnd = 999504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator ScriptDataProxy(string d)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(d)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptDataProxy.NativeMethodInfoPtr_op_Implicit_Public_Static_ScriptDataProxy_String_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ScriptDataProxy) null : Il2CppObjectPool.Get<ScriptDataProxy>(num3);
  }

  public static unsafe ArticyLogger Logger
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ScriptDataProxy.NativeFieldInfoPtr_Logger, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (ArticyLogger) null : Il2CppObjectPool.Get<ArticyLogger>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ScriptDataProxy.NativeFieldInfoPtr_Logger, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Object mUnderlyingData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptDataProxy.NativeFieldInfoPtr_mUnderlyingData));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptDataProxy.NativeFieldInfoPtr_mUnderlyingData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
