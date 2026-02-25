// Decompiled with JetBrains decompiler
// Type: UnityEngine.Assertions.AssertionException
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Assertions;

public class AssertionException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UserMessage;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

  static AssertionException()
  {
    Il2CppClassPointerStore<AssertionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", nameof (AssertionException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionException>.NativeClassPtr);
    AssertionException.NativeFieldInfoPtr_m_UserMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, nameof (m_UserMessage));
    AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100669590);
    AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100669591);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481680, XrefRangeEnd = 481684, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AssertionException(string message, string userMessage)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssertionException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(message);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(userMessage);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public override unsafe string Message
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 481684, XrefRangeEnd = 481688, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
  }

  public unsafe string m_UserMessage
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
