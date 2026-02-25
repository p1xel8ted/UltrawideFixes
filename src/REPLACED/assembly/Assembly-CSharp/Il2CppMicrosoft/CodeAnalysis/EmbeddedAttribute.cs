// Decompiled with JetBrains decompiler
// Type: Il2CppMicrosoft.CodeAnalysis.EmbeddedAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Il2CppMicrosoft.CodeAnalysis;

public sealed class EmbeddedAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static EmbeddedAttribute()
  {
    Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Microsoft.CodeAnalysis", nameof (EmbeddedAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr);
    EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr, 100663297 /*0x06000001*/);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 0, XrefRangeEnd = 1, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe EmbeddedAttribute()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmbeddedAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(EmbeddedAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
