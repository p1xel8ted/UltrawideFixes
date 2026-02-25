// Decompiled with JetBrains decompiler
// Type: UnityEngine.Events.BaseInvokableCall
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;

#nullable disable
namespace UnityEngine.Events;

public class BaseInvokableCall(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0;

  static BaseInvokableCall()
  {
    Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", nameof (BaseInvokableCall));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr);
    BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669059);
    BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669060);
    BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669061);
    BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669062);
    BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669063);
    BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr, 100669064);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseInvokableCall()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(5)]
  [CachedScanResults(RefRangeStart = 473007, RefRangeEnd = 473012, XrefRangeStart = 473003, XrefRangeEnd = 473007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe BaseInvokableCall(Il2CppSystem.Object target, MethodInfo function)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) target);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) function);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr__ctor_Protected_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Invoke(Il2CppReferenceArray<Il2CppSystem.Object> args)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) args)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseInvokableCall.NativeMethodInfoPtr_Invoke_Public_Abstract_Virtual_New_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(6)]
  [CachedScanResults(RefRangeStart = 473015, RefRangeEnd = 473021, XrefRangeStart = 473012, XrefRangeEnd = 473015, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ThrowOnInvalidArg<T>(Il2CppSystem.Object arg)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) arg)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 473025, RefRangeEnd = 473032, XrefRangeStart = 473021, XrefRangeEnd = 473025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool AllowInvoke(Il2CppSystem.Delegate @delegate)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @delegate)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BaseInvokableCall.NativeMethodInfoPtr_AllowInvoke_Protected_Static_Boolean_Delegate_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Find(Il2CppSystem.Object targetObj, MethodInfo method)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetObj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) method);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BaseInvokableCall.NativeMethodInfoPtr_Find_Public_Abstract_Virtual_New_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  private sealed class MethodInfoStoreGeneric_ThrowOnInvalidArg_Protected_Static_Void_Object_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(BaseInvokableCall.NativeMethodInfoPtr_ThrowOnInvalidArg_Protected_Static_Void_Object_0, Il2CppClassPointerStore<BaseInvokableCall>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
