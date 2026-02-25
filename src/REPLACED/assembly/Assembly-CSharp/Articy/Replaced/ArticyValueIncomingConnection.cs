// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.ArticyValueIncomingConnection
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class ArticyValueIncomingConnection(IntPtr pointer) : ArticyValue<IncomingConnection>(pointer)
{
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyValueIncomingConnection()
  {
    Il2CppClassPointerStore<ArticyValueIncomingConnection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (ArticyValueIncomingConnection));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyValueIncomingConnection>.NativeClassPtr);
    ArticyValueIncomingConnection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyValueIncomingConnection>.NativeClassPtr, 100677935);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132626, XrefRangeEnd = 132629, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyValueIncomingConnection()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyValueIncomingConnection>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyValueIncomingConnection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
