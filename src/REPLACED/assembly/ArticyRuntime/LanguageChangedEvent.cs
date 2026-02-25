// Decompiled with JetBrains decompiler
// Type: Articy.Unity.LanguageChangedEvent
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class LanguageChangedEvent(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ArticyLanguage_ArticyLanguage_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ArticyLanguage_ArticyLanguage_AsyncCallback_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;

  static LanguageChangedEvent()
  {
    Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (LanguageChangedEvent));
    LanguageChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr, 100663515 /*0x060000DB*/);
    LanguageChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ArticyLanguage_ArticyLanguage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr, 100663516 /*0x060000DC*/);
    LanguageChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ArticyLanguage_ArticyLanguage_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr, 100663517 /*0x060000DD*/);
    LanguageChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr, 100663518 /*0x060000DE*/);
  }

  [CallerCount(332)]
  [CachedScanResults(RefRangeStart = 346579, RefRangeEnd = 346911, XrefRangeStart = 346579, XrefRangeEnd = 346911, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe LanguageChangedEvent(Il2CppSystem.Object @object, System.IntPtr method)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LanguageChangedEvent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LanguageChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(ArticyLanguage aOldLanguage, ArticyLanguage aNewLanguage)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewLanguage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LanguageChangedEvent.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ArticyLanguage_ArticyLanguage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.IAsyncResult BeginInvoke(
    ArticyLanguage aOldLanguage,
    ArticyLanguage aNewLanguage,
    Il2CppSystem.AsyncCallback callback,
    Il2CppSystem.Object @object)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOldLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aNewLanguage);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) callback);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(LanguageChangedEvent.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ArticyLanguage_ArticyLanguage_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.IAsyncResult) null : Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(num3);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 162035, RefRangeEnd = 162037, XrefRangeStart = 162035, XrefRangeEnd = 162037, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) result)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(LanguageChangedEvent.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static implicit operator LanguageChangedEvent([In] System.Action<ArticyLanguage, ArticyLanguage> obj0)
  {
    return DelegateSupport.ConvertDelegate<LanguageChangedEvent>((System.Delegate) obj0);
  }

  public static LanguageChangedEvent operator +(
    [In] LanguageChangedEvent obj0,
    [In] LanguageChangedEvent obj1)
  {
    return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<LanguageChangedEvent>();
  }

  public static LanguageChangedEvent operator -(
    [In] LanguageChangedEvent obj0,
    [In] LanguageChangedEvent obj1)
  {
    Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
    return (object) @delegate == null ? (LanguageChangedEvent) @delegate : @delegate.Cast<LanguageChangedEvent>();
  }
}
