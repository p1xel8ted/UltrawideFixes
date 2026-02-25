// Decompiled with JetBrains decompiler
// Type: JetBrains.Annotations.MustUseReturnValueAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace JetBrains.Annotations;

public sealed class MustUseReturnValueAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static MustUseReturnValueAttribute()
  {
    Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", nameof (MustUseReturnValueAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr);
    MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr, 100663628);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MustUseReturnValueAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MustUseReturnValueAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MustUseReturnValueAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public string Justification => throw new System.NotSupportedException("Method unstripping failed");
}
