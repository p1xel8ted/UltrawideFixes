// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.TutorialPromptTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.Foundation;
using SadCatStudios.UI;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace SadCatStudios.Triggers;

public class TutorialPromptTrigger(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_activatorTag;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyRef;
  private static readonly System.IntPtr NativeFieldInfoPtr_articyField;
  private static readonly System.IntPtr NativeFieldInfoPtr_clear;
  private static readonly System.IntPtr NativeFieldInfoPtr_playOnce;
  private static readonly System.IntPtr NativeFieldInfoPtr_debugColor;
  private static readonly System.IntPtr NativeFieldInfoPtr_played;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TutorialPromptTrigger()
  {
    Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (TutorialPromptTrigger));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr);
    TutorialPromptTrigger.NativeFieldInfoPtr_activatorTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (activatorTag));
    TutorialPromptTrigger.NativeFieldInfoPtr_articyRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (articyRef));
    TutorialPromptTrigger.NativeFieldInfoPtr_articyField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (articyField));
    TutorialPromptTrigger.NativeFieldInfoPtr_clear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (clear));
    TutorialPromptTrigger.NativeFieldInfoPtr_playOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (playOnce));
    TutorialPromptTrigger.NativeFieldInfoPtr_debugColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (debugColor));
    TutorialPromptTrigger.NativeFieldInfoPtr_played = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, nameof (played));
    TutorialPromptTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, 100671849);
    TutorialPromptTrigger.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, 100671850);
    TutorialPromptTrigger.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, 100671851);
    TutorialPromptTrigger.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, 100671852);
    TutorialPromptTrigger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr, 100671853);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96582, XrefRangeEnd = 96593, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnTriggerEnter(Collider other)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTrigger.NativeMethodInfoPtr_OnTriggerEnter_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96593, XrefRangeEnd = 96599, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void OnDrawGizmos()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTrigger.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96599, XrefRangeEnd = 96601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(TutorialPromptTrigger.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96601, XrefRangeEnd = 96603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTrigger.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96603, XrefRangeEnd = 96604, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TutorialPromptTrigger()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialPromptTrigger>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TutorialPromptTrigger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string activatorTag
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_activatorTag)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_activatorTag), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ArticyRef articyRef
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_articyRef));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_articyRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UIPromptsManager.ArticyPromptField articyField
  {
    get
    {
      return *(UIPromptsManager.ArticyPromptField*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_articyField));
    }
    [param: In] set
    {
      *(UIPromptsManager.ArticyPromptField*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_articyField)) = value;
    }
  }

  public unsafe bool clear
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_clear));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_clear)) = value;
    }
  }

  public unsafe bool playOnce
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_playOnce));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_playOnce)) = value;
    }
  }

  public unsafe Color debugColor
  {
    get
    {
      return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_debugColor));
    }
    [param: In] set
    {
      *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_debugColor)) = value;
    }
  }

  public unsafe bool played
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_played));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TutorialPromptTrigger.NativeFieldInfoPtr_played)) = value;
    }
  }
}
