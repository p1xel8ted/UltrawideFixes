// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Interfaces.IAsset
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Threading.Tasks;
using UnityEngine;

#nullable disable
namespace Articy.Unity.Interfaces;

public class IAsset(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Category_Public_Abstract_Virtual_New_get_AssetCategory_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAsset_Public_Abstract_Virtual_New_TAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_Task_1_TAsset_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetAsSprite_Public_Abstract_Virtual_New_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadAssetAsSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReleaseAsset_Public_Abstract_Virtual_New_Void_0;

  static IAsset()
  {
    Il2CppClassPointerStore<IAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Interfaces", nameof (IAsset));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IAsset>.NativeClassPtr);
    IAsset.NativeMethodInfoPtr_get_Category_Public_Abstract_Virtual_New_get_AssetCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664522);
    IAsset.NativeMethodInfoPtr_LoadAsset_Public_Abstract_Virtual_New_TAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664523);
    IAsset.NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_Task_1_TAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664524);
    IAsset.NativeMethodInfoPtr_LoadAssetAsSprite_Public_Abstract_Virtual_New_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664525);
    IAsset.NativeMethodInfoPtr_LoadAssetAsSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664526);
    IAsset.NativeMethodInfoPtr_ReleaseAsset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IAsset>.NativeClassPtr, 100664527);
  }

  public virtual unsafe AssetCategory Category
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.NativeMethodInfoPtr_get_Category_Public_Abstract_Virtual_New_get_AssetCategory_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(AssetCategory*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  public virtual unsafe TAsset LoadAsset<TAsset>() where TAsset : UnityEngine.Object
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.MethodInfoStoreGeneric_LoadAsset_Public_Abstract_Virtual_New_TAsset_0<TAsset>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.PointerToValueGeneric<TAsset>(num2, false, true);
  }

  [CallerCount(0)]
  public virtual unsafe Task<TAsset> LoadAssetAsync<TAsset>() where TAsset : UnityEngine.Object
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.MethodInfoStoreGeneric_LoadAssetAsync_Public_Abstract_Virtual_New_Task_1_TAsset_0<TAsset>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task<TAsset>) null : Il2CppObjectPool.Get<Task<TAsset>>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Sprite LoadAssetAsSprite()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.NativeMethodInfoPtr_LoadAssetAsSprite_Public_Abstract_Virtual_New_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Task<Sprite> LoadAssetAsSpriteAsync()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.NativeMethodInfoPtr_LoadAssetAsSpriteAsync_Public_Abstract_Virtual_New_Task_1_Sprite_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Task<Sprite>) null : Il2CppObjectPool.Get<Task<Sprite>>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe void ReleaseAsset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IAsset.NativeMethodInfoPtr_ReleaseAsset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  private sealed class MethodInfoStoreGeneric_LoadAsset_Public_Abstract_Virtual_New_TAsset_0<TAsset>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IAsset.NativeMethodInfoPtr_LoadAsset_Public_Abstract_Virtual_New_TAsset_0, Il2CppClassPointerStore<IAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAsset>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_LoadAssetAsync_Public_Abstract_Virtual_New_Task_1_TAsset_0<TAsset>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(IAsset.NativeMethodInfoPtr_LoadAssetAsync_Public_Abstract_Virtual_New_Task_1_TAsset_0, Il2CppClassPointerStore<IAsset>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TAsset>.NativeClassPtr))
    }))));
  }
}
