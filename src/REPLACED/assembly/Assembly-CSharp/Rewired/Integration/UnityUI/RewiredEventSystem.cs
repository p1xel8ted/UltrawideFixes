// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredEventSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine.EventSystems;

#nullable disable
namespace Rewired.Integration.UnityUI;

public class RewiredEventSystem(IntPtr pointer) : EventSystem(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr__alwaysUpdate;
  private static readonly IntPtr NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static RewiredEventSystem()
  {
    Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.Integration.UnityUI", nameof (RewiredEventSystem));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr);
    RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, nameof (_alwaysUpdate));
    RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668314);
    RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668315);
    RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668316);
    RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr, 100668317);
  }

  public unsafe bool alwaysUpdate
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_get_alwaysUpdate_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr_set_alwaysUpdate_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66886, XrefRangeEnd = 66902, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), RewiredEventSystem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 66902, XrefRangeEnd = 66906, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RewiredEventSystem()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RewiredEventSystem>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RewiredEventSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool _alwaysUpdate
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(RewiredEventSystem.NativeFieldInfoPtr__alwaysUpdate)) = value;
    }
  }
}
