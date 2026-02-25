// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyPrimitive
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyPrimitive(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_id;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_New_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyPrimitive()
  {
    Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyPrimitive));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr);
    ArticyPrimitive.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr, nameof (id));
    ArticyPrimitive.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr, 100663754);
    ArticyPrimitive.NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr, 100663755);
    ArticyPrimitive.NativeMethodInfoPtr_CloneObject_Public_Virtual_New_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr, 100663756);
    ArticyPrimitive.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr, 100663757);
  }

  public virtual unsafe ulong Id
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyPrimitive.NativeMethodInfoPtr_get_Id_Public_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ulong*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyPrimitive.NativeMethodInfoPtr_set_Id_Public_Virtual_New_set_Void_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(193)]
  [CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyPrimitive.NativeMethodInfoPtr_CloneObject_Public_Virtual_New_Object_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyPrimitive()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyPrimitive>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyPrimitive.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ulong id
  {
    get
    {
      return *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPrimitive.NativeFieldInfoPtr_id));
    }
    [param: In] set
    {
      *(ulong*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyPrimitive.NativeFieldInfoPtr_id)) = value;
    }
  }
}
