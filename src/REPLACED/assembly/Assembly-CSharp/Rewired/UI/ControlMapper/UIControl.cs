// Decompiled with JetBrains decompiler
// Type: Rewired.UI.ControlMapper.UIControl
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

#nullable disable
namespace Rewired.UI.ControlMapper;

public class UIControl(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_title;
  private static readonly System.IntPtr NativeFieldInfoPtr__id;
  private static readonly System.IntPtr NativeFieldInfoPtr__showTitle;
  private static readonly System.IntPtr NativeFieldInfoPtr__uidCounter;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_id_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UIControl()
  {
    Il2CppClassPointerStore<UIControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Rewired.UI.ControlMapper", nameof (UIControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIControl>.NativeClassPtr);
    UIControl.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, nameof (title));
    UIControl.NativeFieldInfoPtr__id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, nameof (_id));
    UIControl.NativeFieldInfoPtr__showTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, nameof (_showTitle));
    UIControl.NativeFieldInfoPtr__uidCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIControl>.NativeClassPtr, nameof (_uidCounter));
    UIControl.NativeMethodInfoPtr_get_id_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670042);
    UIControl.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670043);
    UIControl.NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670044);
    UIControl.NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670045);
    UIControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670046);
    UIControl.NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670047);
    UIControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIControl>.NativeClassPtr, 100670048);
  }

  public unsafe int id
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_get_id_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79929, XrefRangeEnd = 79932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool showTitle
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_get_showTitle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(2), CachedScanResults(RefRangeStart = 79938, RefRangeEnd = 79940, XrefRangeStart = 79932, XrefRangeEnd = 79938, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_set_showTitle_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void SetCancelCallback(Il2CppSystem.Action cancelCallback)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) cancelCallback)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), UIControl.NativeMethodInfoPtr_SetCancelCallback_Public_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79940, XrefRangeEnd = 79943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe int GetNextUid()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr_GetNextUid_Private_Static_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UIControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIControl>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UIControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe TMP_Text title
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr_title));
      return num == System.IntPtr.Zero ? (TMP_Text) null : Il2CppObjectPool.Get<TMP_Text>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr_title), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _id
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__id));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__id)) = value;
    }
  }

  public unsafe bool _showTitle
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__showTitle));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UIControl.NativeFieldInfoPtr__showTitle)) = value;
    }
  }

  public static unsafe int _uidCounter
  {
    get
    {
      int uidCounter;
      IL2CPP.il2cpp_field_static_get_value(UIControl.NativeFieldInfoPtr__uidCounter, (void*) &uidCounter);
      return uidCounter;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(UIControl.NativeFieldInfoPtr__uidCounter, (void*) &value);
    }
  }
}
