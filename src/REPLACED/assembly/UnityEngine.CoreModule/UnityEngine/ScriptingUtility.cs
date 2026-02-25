// Decompiled with JetBrains decompiler
// Type: UnityEngine.ScriptingUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class ScriptingUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0;

  static ScriptingUtility()
  {
    Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (ScriptingUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
    ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100668256);
    ScriptingUtility.NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100668257);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 268212, RefRangeEnd = 268213, XrefRangeStart = 268212, XrefRangeEnd = 268213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool IsManagedCodeWorking()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetupCallbacks(System.IntPtr p)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &p
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_SetupCallbacks_Private_Static_Void_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [StructLayout(LayoutKind.Explicit)]
  public struct TestClass
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_value;
    [FieldOffset(0)]
    public int value;

    static TestClass()
    {
      Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, nameof (TestClass));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr);
      ScriptingUtility.TestClass.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, nameof (value));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
