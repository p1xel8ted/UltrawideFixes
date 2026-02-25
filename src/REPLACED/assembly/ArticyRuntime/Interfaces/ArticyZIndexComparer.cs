// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.ArticyZIndexComparer
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace Articy.Unity.Interfaces;

public class ArticyZIndexComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IObjectWithZIndex_IObjectWithZIndex_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyZIndexComparer()
  {
    Il2CppClassPointerStore<ArticyZIndexComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (ArticyZIndexComparer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyZIndexComparer>.NativeClassPtr);
    ArticyZIndexComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IObjectWithZIndex_IObjectWithZIndex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyZIndexComparer>.NativeClassPtr, 100664581 /*0x06000505*/);
    ArticyZIndexComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyZIndexComparer>.NativeClassPtr, 100664582 /*0x06000506*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000019, XrefRangeEnd = 1000025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int Compare(IObjectWithZIndex x, IObjectWithZIndex y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyZIndexComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_IObjectWithZIndex_IObjectWithZIndex_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyZIndexComparer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyZIndexComparer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyZIndexComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
