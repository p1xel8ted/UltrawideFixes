// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.PhraseRecognitionSystem
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Windows.Speech;

public static class PhraseRecognitionSystem : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_OnError;
  private static readonly System.IntPtr NativeFieldInfoPtr_OnStatusChanged;
  private static readonly System.IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;
  private static readonly PhraseRecognitionSystem.get_isSupportedDelegate get_isSupportedDelegateField;
  private static readonly PhraseRecognitionSystem.get_StatusDelegate get_StatusDelegateField;
  private static readonly PhraseRecognitionSystem.RestartDelegate RestartDelegateField;
  private static readonly PhraseRecognitionSystem.ShutdownDelegate ShutdownDelegateField;

  static PhraseRecognitionSystem()
  {
    Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", nameof (PhraseRecognitionSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
    PhraseRecognitionSystem.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, nameof (OnError));
    PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, nameof (OnStatusChanged));
    PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100668961);
    PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100668962);
    PhraseRecognitionSystem.get_isSupportedDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_isSupportedDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_isSupported");
    PhraseRecognitionSystem.get_StatusDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_StatusDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_Status");
    PhraseRecognitionSystem.RestartDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.RestartDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Restart");
    PhraseRecognitionSystem.ShutdownDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.ShutdownDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Shutdown");
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472723, XrefRangeEnd = 472725, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &errorCode
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 472725, XrefRangeEnd = 472727, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void PhraseRecognitionSystem_InvokeStatusChangedEvent(
    SpeechSystemStatus status)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &status
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public PhraseRecognitionSystem(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe PhraseRecognitionSystem.ErrorDelegate OnError
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (PhraseRecognitionSystem.ErrorDelegate) null : Il2CppObjectPool.Get<PhraseRecognitionSystem.ErrorDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe PhraseRecognitionSystem.StatusDelegate OnStatusChanged
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (PhraseRecognitionSystem.StatusDelegate) null : Il2CppObjectPool.Get<PhraseRecognitionSystem.StatusDelegate>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static bool isSupported => PhraseRecognitionSystem.get_isSupportedDelegateField();

  public static SpeechSystemStatus Status => PhraseRecognitionSystem.get_StatusDelegateField();

  public static void Restart() => PhraseRecognitionSystem.RestartDelegateField();

  public static void Shutdown() => PhraseRecognitionSystem.ShutdownDelegateField();

  [SpecialName]
  public static void add_OnError(PhraseRecognitionSystem.ErrorDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_OnError(PhraseRecognitionSystem.ErrorDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void add_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  [SpecialName]
  public static void remove_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }

  public sealed class ErrorDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;

    static ErrorDelegate()
    {
      Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, nameof (ErrorDelegate));
      PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100668963);
      PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100668964);
    }

    [CallerCount(120)]
    [CachedScanResults(RefRangeStart = 472603, RefRangeEnd = 472723, XrefRangeStart = 472601, XrefRangeEnd = 472603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ErrorDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(SpeechError errorCode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &errorCode
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhraseRecognitionSystem.ErrorDelegate([In] System.Action<SpeechError> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.ErrorDelegate>((System.Delegate) obj0);
    }

    public static PhraseRecognitionSystem.ErrorDelegate operator +(
      [In] PhraseRecognitionSystem.ErrorDelegate obj0,
      [In] PhraseRecognitionSystem.ErrorDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhraseRecognitionSystem.ErrorDelegate>();
    }

    public static PhraseRecognitionSystem.ErrorDelegate operator -(
      [In] PhraseRecognitionSystem.ErrorDelegate obj0,
      [In] PhraseRecognitionSystem.ErrorDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhraseRecognitionSystem.ErrorDelegate) @delegate : @delegate.Cast<PhraseRecognitionSystem.ErrorDelegate>();
    }
  }

  public sealed class StatusDelegate(System.IntPtr pointer) : Il2CppSystem.MulticastDelegate(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;

    static StatusDelegate()
    {
      Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, nameof (StatusDelegate));
      PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100668965);
      PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100668966);
    }

    [CallerCount(120)]
    [CachedScanResults(RefRangeStart = 472603, RefRangeEnd = 472723, XrefRangeStart = 472603, XrefRangeEnd = 472723, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StatusDelegate(Il2CppSystem.Object @object, System.IntPtr method)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @object);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &method;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(0)]
    public virtual unsafe void Invoke(SpeechSystemStatus status)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &status
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static implicit operator PhraseRecognitionSystem.StatusDelegate(
      [In] System.Action<SpeechSystemStatus> obj0)
    {
      return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.StatusDelegate>((System.Delegate) obj0);
    }

    public static PhraseRecognitionSystem.StatusDelegate operator +(
      [In] PhraseRecognitionSystem.StatusDelegate obj0,
      [In] PhraseRecognitionSystem.StatusDelegate obj1)
    {
      return Il2CppSystem.Delegate.Combine((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1).Cast<PhraseRecognitionSystem.StatusDelegate>();
    }

    public static PhraseRecognitionSystem.StatusDelegate operator -(
      [In] PhraseRecognitionSystem.StatusDelegate obj0,
      [In] PhraseRecognitionSystem.StatusDelegate obj1)
    {
      Il2CppSystem.Delegate @delegate = Il2CppSystem.Delegate.Remove((Il2CppSystem.Delegate) obj0, (Il2CppSystem.Delegate) obj1);
      return (object) @delegate == null ? (PhraseRecognitionSystem.StatusDelegate) @delegate : @delegate.Cast<PhraseRecognitionSystem.StatusDelegate>();
    }
  }

  private delegate bool get_isSupportedDelegate();

  private delegate SpeechSystemStatus get_StatusDelegate();

  private delegate void RestartDelegate();

  private delegate void ShutdownDelegate();
}
