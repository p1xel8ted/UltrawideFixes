// Decompiled with JetBrains decompiler
// Type: Cinemachine.Utility.CinemachineDebug
// Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E0CDA0E8-0334-4C69-ADD8-097D487ADAFD
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Cinemachine.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Cinemachine.Utility;

public class CinemachineDebug(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mClients;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnGUIHandlers;
  private static readonly System.IntPtr NativeFieldInfoPtr_mAvailableStringBuilders;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseScreenPos_Public_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetScreenPos_Public_Static_Rect_Object_String_GUIStyle_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SBFromPool_Public_Static_StringBuilder_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_StringBuilder_0;

  static CinemachineDebug()
  {
    Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr = IL2CPP.GetIl2CppClass("Cinemachine.dll", "Cinemachine.Utility", nameof (CinemachineDebug));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr);
    CinemachineDebug.NativeFieldInfoPtr_mClients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, nameof (mClients));
    CinemachineDebug.NativeFieldInfoPtr_OnGUIHandlers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, nameof (OnGUIHandlers));
    CinemachineDebug.NativeFieldInfoPtr_mAvailableStringBuilders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, nameof (mAvailableStringBuilders));
    CinemachineDebug.NativeMethodInfoPtr_ReleaseScreenPos_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, 100664470);
    CinemachineDebug.NativeMethodInfoPtr_GetScreenPos_Public_Static_Rect_Object_String_GUIStyle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, 100664471);
    CinemachineDebug.NativeMethodInfoPtr_SBFromPool_Public_Static_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, 100664472);
    CinemachineDebug.NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, 100664473);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 947735, RefRangeEnd = 947739, XrefRangeStart = 947726, XrefRangeEnd = 947735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReleaseScreenPos(UnityEngine.Object client)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) client)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.NativeMethodInfoPtr_ReleaseScreenPos_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 947785, RefRangeEnd = 947789, XrefRangeStart = 947739, XrefRangeEnd = 947785, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Rect GetScreenPos(UnityEngine.Object client, string text, GUIStyle style)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) client);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(text);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) style);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.NativeMethodInfoPtr_GetScreenPos_Public_Static_Rect_Object_String_GUIStyle_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Rect*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 947801, RefRangeEnd = 947809, XrefRangeStart = 947789, XrefRangeEnd = 947801, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe StringBuilder SBFromPool()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.NativeMethodInfoPtr_SBFromPool_Public_Static_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num3);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 947822, RefRangeEnd = 947830, XrefRangeStart = 947809, XrefRangeEnd = 947822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ReturnToPool(StringBuilder sb)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sb)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.NativeMethodInfoPtr_ReturnToPool_Public_Static_Void_StringBuilder_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe HashSet<UnityEngine.Object> mClients
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineDebug.NativeFieldInfoPtr_mClients, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (HashSet<UnityEngine.Object>) null : Il2CppObjectPool.Get<HashSet<UnityEngine.Object>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineDebug.NativeFieldInfoPtr_mClients, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe CinemachineDebug.OnGUIDelegate OnGUIHandlers
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineDebug.NativeFieldInfoPtr_OnGUIHandlers, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (CinemachineDebug.OnGUIDelegate) null : Il2CppObjectPool.Get<CinemachineDebug.OnGUIDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineDebug.NativeFieldInfoPtr_OnGUIHandlers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe List<StringBuilder> mAvailableStringBuilders
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(CinemachineDebug.NativeFieldInfoPtr_mAvailableStringBuilders, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (List<StringBuilder>) null : Il2CppObjectPool.Get<List<StringBuilder>>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(CinemachineDebug.NativeFieldInfoPtr_mAvailableStringBuilders, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public sealed class OnGUIDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;

    static OnGUIDelegate()
    {
      Il2CppClassPointerStore<CinemachineDebug.OnGUIDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CinemachineDebug>.NativeClassPtr, nameof (OnGUIDelegate));
      CinemachineDebug.OnGUIDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug.OnGUIDelegate>.NativeClassPtr, 100664474);
      CinemachineDebug.OnGUIDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CinemachineDebug.OnGUIDelegate>.NativeClassPtr, 100664475);
    }

    [CallerCount(483)]
    [CachedScanResults(RefRangeStart = 231718, RefRangeEnd = 232201, XrefRangeStart = 231718, XrefRangeEnd = 232201, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OnGUIDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CinemachineDebug.OnGUIDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.OnGUIDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(CinemachineDebug.OnGUIDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator CinemachineDebug.OnGUIDelegate([In] System.Action obj0)
    {
      return DelegateSupport.ConvertDelegate<CinemachineDebug.OnGUIDelegate>((System.Delegate) obj0);
    }

    public static CinemachineDebug.OnGUIDelegate operator +(
      [In] CinemachineDebug.OnGUIDelegate obj0,
      [In] CinemachineDebug.OnGUIDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<CinemachineDebug.OnGUIDelegate>();
    }

    public static CinemachineDebug.OnGUIDelegate operator -(
      [In] CinemachineDebug.OnGUIDelegate obj0,
      [In] CinemachineDebug.OnGUIDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (CinemachineDebug.OnGUIDelegate) @delegate : @delegate.Cast<CinemachineDebug.OnGUIDelegate>();
    }
  }
}
