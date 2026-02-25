// Decompiled with JetBrains decompiler
// Type: UnityEngine.PlayerPrefsException
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine;

public class PlayerPrefsException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

  static PlayerPrefsException()
  {
    Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (PlayerPrefsException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr);
    PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr, 100667711);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 441567, XrefRangeEnd = 441571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PlayerPrefsException(string error)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPrefsException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(error)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PlayerPrefsException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
