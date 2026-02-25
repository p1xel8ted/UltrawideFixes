// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Triggers.InteractionZoneSaveLoader
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

public class InteractionZoneSaveLoader(System.IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_zone;
  private static readonly System.IntPtr NativeFieldInfoPtr_visualizer;
  private static readonly System.IntPtr NativeFieldInfoPtr_Interacted;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InteractionZoneSaveLoader()
  {
    Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Triggers", nameof (InteractionZoneSaveLoader));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr);
    InteractionZoneSaveLoader.NativeFieldInfoPtr_zone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, nameof (zone));
    InteractionZoneSaveLoader.NativeFieldInfoPtr_visualizer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, nameof (visualizer));
    InteractionZoneSaveLoader.NativeFieldInfoPtr_Interacted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, nameof (Interacted));
    InteractionZoneSaveLoader.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, 100671807);
    InteractionZoneSaveLoader.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, 100671808);
    InteractionZoneSaveLoader.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, 100671809);
    InteractionZoneSaveLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr, 100671810);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96325, XrefRangeEnd = 96327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InteractionZoneSaveLoader.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Object_ICheckpointSender_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96327, XrefRangeEnd = 96329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZoneSaveLoader.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 96329, XrefRangeEnd = 96343, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZoneSaveLoader.NativeMethodInfoPtr_Initialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InteractionZoneSaveLoader()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionZoneSaveLoader>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InteractionZoneSaveLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe InteractionZone zone
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_zone));
      return num == System.IntPtr.Zero ? (InteractionZone) null : Il2CppObjectPool.Get<InteractionZone>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_zone), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe GameObject visualizer
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_visualizer));
      return num == System.IntPtr.Zero ? (GameObject) null : Il2CppObjectPool.Get<GameObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_visualizer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool Interacted
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_Interacted));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractionZoneSaveLoader.NativeFieldInfoPtr_Interacted)) = value;
    }
  }
}
