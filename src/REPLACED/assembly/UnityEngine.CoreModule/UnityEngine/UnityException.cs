// Decompiled with JetBrains decompiler
// Type: UnityEngine.UnityException
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Runtime.Serialization;
using System;

#nullable disable
namespace UnityEngine;

[Serializable]
public class UnityException(System.IntPtr pointer) : Il2CppSystem.Exception(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
  public const int Result = -2147467261 /*0x80004003*/;

  static UnityException()
  {
    Il2CppClassPointerStore<UnityException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (UnityException));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityException>.NativeClassPtr);
    UnityException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100668264);
    UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100668265);
    UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityException>.NativeClassPtr, 100668266);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453341, XrefRangeEnd = 453347, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 453351, RefRangeEnd = 453355, XrefRangeStart = 453347, XrefRangeEnd = 453351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException(string message)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(message)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 453355, XrefRangeEnd = 453359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnityException(SerializationInfo info, StreamingContext context)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityException>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) info);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) context));
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnityException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
