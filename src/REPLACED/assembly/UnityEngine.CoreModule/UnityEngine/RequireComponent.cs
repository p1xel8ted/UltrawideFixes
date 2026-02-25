// Decompiled with JetBrains decompiler
// Type: UnityEngine.RequireComponent
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public sealed class RequireComponent(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type0;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type1;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Type2;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0;

  static RequireComponent()
  {
    Il2CppClassPointerStore<RequireComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RequireComponent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr);
    RequireComponent.NativeFieldInfoPtr_m_Type0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, nameof (m_Type0));
    RequireComponent.NativeFieldInfoPtr_m_Type1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, nameof (m_Type1));
    RequireComponent.NativeFieldInfoPtr_m_Type2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, nameof (m_Type2));
    RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100667853);
    RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100667854);
    RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr, 100667855);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RequireComponent(Il2CppSystem.Type requiredComponent)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 442734, RefRangeEnd = 442737, XrefRangeStart = 442733, XrefRangeEnd = 442734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RequireComponent(Il2CppSystem.Type requiredComponent, Il2CppSystem.Type requiredComponent2)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent2);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 442738, RefRangeEnd = 442739, XrefRangeStart = 442737, XrefRangeEnd = 442738, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RequireComponent(
    Il2CppSystem.Type requiredComponent,
    Il2CppSystem.Type requiredComponent2,
    Il2CppSystem.Type requiredComponent3)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RequireComponent>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent2);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) requiredComponent3);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RequireComponent.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppSystem.Type m_Type0
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type0), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Type m_Type1
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppSystem.Type m_Type2
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2));
      return num == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(RequireComponent.NativeFieldInfoPtr_m_Type2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
