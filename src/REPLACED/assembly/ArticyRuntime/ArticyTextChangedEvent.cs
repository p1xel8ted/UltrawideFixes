// Decompiled with JetBrains decompiler
// Type: Articy.Unity.ArticyTextChangedEvent
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Events;

#nullable disable
namespace Articy.Unity;

[Serializable]
public class ArticyTextChangedEvent(IntPtr pointer) : UnityEvent<string>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mOwner;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_ArticyText_0;
  private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_String_0;

  static ArticyTextChangedEvent()
  {
    Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (ArticyTextChangedEvent));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr);
    ArticyTextChangedEvent.NativeFieldInfoPtr_mOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr, nameof (mOwner));
    ArticyTextChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr, 100663859);
    ArticyTextChangedEvent.NativeMethodInfoPtr__ctor_Internal_Void_ArticyText_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr, 100663860);
    ArticyTextChangedEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr, 100663861);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991403, XrefRangeEnd = 991406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyTextChangedEvent()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextChangedEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991406, XrefRangeEnd = 991409, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyTextChangedEvent(ArticyText aOwner)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyTextChangedEvent>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aOwner)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextChangedEvent.NativeMethodInfoPtr__ctor_Internal_Void_ArticyText_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 991409, XrefRangeEnd = 991414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public new unsafe void AddListener(UnityAction<string> call)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) call)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyTextChangedEvent.NativeMethodInfoPtr_AddListener_Public_Void_UnityAction_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyText mOwner
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextChangedEvent.NativeFieldInfoPtr_mOwner));
      return num == IntPtr.Zero ? (ArticyText) null : Il2CppObjectPool.Get<ArticyText>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyTextChangedEvent.NativeFieldInfoPtr_mOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
