// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.G_Singleton`1
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace Tayx.Graphy.Utils;

public class G_Singleton<T>(System.IntPtr pointer) : MonoBehaviour(pointer) where T : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr__instance;
  private static readonly System.IntPtr NativeFieldInfoPtr__lock;
  private static readonly System.IntPtr NativeFieldInfoPtr__applicationIsQuitting;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static G_Singleton()
  {
    // ISSUE: explicit non-virtual call
    // ISSUE: explicit non-virtual call
    Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Utils", "G_Singleton`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))).TypeHandle).value);
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr);
    G_Singleton<T>.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, nameof (_instance));
    G_Singleton<T>.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, nameof (_lock));
    G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, nameof (_applicationIsQuitting));
    G_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100663526 /*0x060000E6*/);
    G_Singleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100663527 /*0x060000E7*/);
    G_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100663528 /*0x060000E8*/);
    G_Singleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr, 100663529 /*0x060000E9*/);
  }

  public static unsafe T Instance
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 361839, RefRangeEnd = 361840, XrefRangeStart = 361748, XrefRangeEnd = 361839, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_get_Instance_Public_Static_get_T_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.PointerToValueGeneric<T>(num2, false, true);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361840, XrefRangeEnd = 361852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361852, XrefRangeEnd = 361854, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDestroy()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe G_Singleton()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<G_Singleton<T>>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_Singleton<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe T _instance
  {
    get
    {
      System.IntPtr num;
      IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__instance, (void*) &num);
      return IL2CPP.PointerToValueGeneric<T>(num, false, false);
    }
    [param: In] set
    {
      System.IntPtr fieldInfoPtrInstance = G_Singleton<T>.NativeFieldInfoPtr__instance;
      T& local1;
      if (!typeof (T).IsValueType)
      {
        __Boxed<T> local2 = (object) value;
        if (!(local2 is string))
        {
          System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
          local1 = ptr == System.IntPtr.Zero ? (T&) ptr : (!IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ptr)) ? (T&) ptr : (T&) IL2CPP.il2cpp_object_unbox(ptr));
        }
        else
          local1 = (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string);
      }
      else
        local1 = ref value;
      IL2CPP.il2cpp_field_static_set_value(fieldInfoPtrInstance, (void*) ref local1);
    }
  }

  public static unsafe Il2CppSystem.Object _lock
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__lock, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_Singleton<T>.NativeFieldInfoPtr__lock, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe bool _applicationIsQuitting
  {
    get
    {
      bool applicationIsQuitting;
      IL2CPP.il2cpp_field_static_get_value(G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting, (void*) &applicationIsQuitting);
      return applicationIsQuitting;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_Singleton<T>.NativeFieldInfoPtr__applicationIsQuitting, (void*) &value);
    }
  }
}
