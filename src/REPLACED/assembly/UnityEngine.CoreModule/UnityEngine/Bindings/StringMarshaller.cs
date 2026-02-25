// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.StringMarshaller
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace UnityEngine.Bindings;

public static class StringMarshaller : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0;

  static StringMarshaller()
  {
    Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (StringMarshaller));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr);
    StringMarshaller.NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringMarshaller>.NativeClassPtr, 100669198);
  }

  [CallerCount(0)]
  public static unsafe bool TryMarshalEmptyOrNullString(
    string s,
    ref ManagedSpanWrapper managedSpanWrapper)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(s);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref managedSpanWrapper;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(StringMarshaller.NativeMethodInfoPtr_TryMarshalEmptyOrNullString_Public_Static_Boolean_String_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public StringMarshaller(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
