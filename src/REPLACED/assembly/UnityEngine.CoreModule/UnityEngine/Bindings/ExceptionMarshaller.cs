// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.ExceptionMarshaller
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Bindings;

public static class ExceptionMarshaller : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_s_pendingException;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0;

  static ExceptionMarshaller()
  {
    Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (ExceptionMarshaller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr);
    ExceptionMarshaller.NativeFieldInfoPtr_s_pendingException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr, nameof (s_pendingException));
    ExceptionMarshaller.NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExceptionMarshaller>.NativeClassPtr, 100669196);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 478531, XrefRangeEnd = 478536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetPendingException(Il2CppSystem.Exception ex)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) ex)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ExceptionMarshaller.NativeMethodInfoPtr_SetPendingException_Private_Static_Void_Exception_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ExceptionMarshaller(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppSystem.Exception s_pendingException
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(ExceptionMarshaller.NativeFieldInfoPtr_s_pendingException, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppSystem.Exception) null : Il2CppObjectPool.Get<Il2CppSystem.Exception>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(ExceptionMarshaller.NativeFieldInfoPtr_s_pendingException, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static void CheckPendingException()
  {
    Il2CppSystem.Exception pendingException = ExceptionMarshaller.s_pendingException;
    if (pendingException != null)
    {
      ExceptionMarshaller.s_pendingException = (Il2CppSystem.Exception) null;
      throw pendingException;
    }
  }
}
