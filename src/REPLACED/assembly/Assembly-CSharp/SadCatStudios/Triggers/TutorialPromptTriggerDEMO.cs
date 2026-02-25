// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.TutorialPromptTriggerDEMO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Triggers;

public class TutorialPromptTriggerDEMO(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_activatorTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_text;
  private static readonly System.IntPtr NativeFieldInfoPtr_clear;
  private static readonly System.IntPtr NativeFieldInfoPtr_playOnce;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_played;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TutorialPromptTriggerDEMO()
  {
    Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (TutorialPromptTriggerDEMO));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr);
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_activatorTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (activatorTag));
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (text));
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (clear));
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_playOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (playOnce));
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_debugColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (debugColor));
    TutorialPromptTriggerDEMO.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, nameof (played));
    TutorialPromptTriggerDEMO.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, 100671570);
    TutorialPromptTriggerDEMO.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, 100671571);
    TutorialPromptTriggerDEMO.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, 100671572);
    TutorialPromptTriggerDEMO.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, 100671573);
    TutorialPromptTriggerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr, 100671574);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95215, XrefRangeEnd = 95223, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTriggerDEMO.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95223, XrefRangeEnd = 95229, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTriggerDEMO.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95229, XrefRangeEnd = 95231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialPromptTriggerDEMO.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95231, XrefRangeEnd = 95233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTriggerDEMO.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95233, XrefRangeEnd = 95234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialPromptTriggerDEMO()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPromptTriggerDEMO>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTriggerDEMO.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string activatorTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_activatorTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_activatorTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe string text
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_text)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe bool clear
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_clear));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_clear)) = value;
    }
  }

  public unsafe bool playOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_playOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_playOnce)) = value;
    }
  }

  public unsafe Color debugColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_debugColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_debugColor)) = value;
    }
  }

  public unsafe bool played
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_played));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTriggerDEMO.NativeFieldInfoPtr_played)) = value;
    }
  }
}
