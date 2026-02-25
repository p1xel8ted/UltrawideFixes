// Decompiled with JetBrains decompiler
// Type: UnityEngine.Bindings.ThrowHelper
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Bindings;

public static class ThrowHelper : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0;

  static ThrowHelper()
  {
    Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Bindings", nameof (ThrowHelper));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr);
    ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100669187);
    ThrowHelper.NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowHelper>.NativeClassPtr, 100669188);
  }

  [CallerCount(561)]
  [CachedScanResults(RefRangeStart = 474819, RefRangeEnd = 475380, XrefRangeStart = 474811, XrefRangeEnd = 474819, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ThrowArgumentNullException(Il2CppSystem.Object obj, string parameterName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(parameterName);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowArgumentNullException_Public_Static_Void_Object_String_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3094)]
  [CachedScanResults(RefRangeStart = 475388, RefRangeEnd = 478482, XrefRangeStart = 475380, XrefRangeEnd = 475388, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void ThrowNullReferenceException(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ThrowHelper.NativeMethodInfoPtr_ThrowNullReferenceException_Public_Static_Void_Object_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public ThrowHelper(System.IntPtr pointer)
    : base(pointer)
  {
  }
}
