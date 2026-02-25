// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Timeline.TypewriterBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using SadCatStudios.UI.Elements;
using System;
using System.Runtime.InteropServices;
using UnityEngine.Playables;

#nullable disable
namespace SadCatStudios.Timeline;

[Serializable]
public class TypewriterBehavior(System.IntPtr pointer) : PlayableBehaviour(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_typewriter;
  private static readonly System.IntPtr NativeFieldInfoPtr_prevTotalWeight;
  private static readonly System.IntPtr NativeFieldInfoPtr_textLine;
  private static readonly System.IntPtr NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static TypewriterBehavior()
  {
    Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Timeline", nameof (TypewriterBehavior));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr);
    TypewriterBehavior.NativeFieldInfoPtr_typewriter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, nameof (typewriter));
    TypewriterBehavior.NativeFieldInfoPtr_prevTotalWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, nameof (prevTotalWeight));
    TypewriterBehavior.NativeFieldInfoPtr_textLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, nameof (textLine));
    TypewriterBehavior.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, 100670816);
    TypewriterBehavior.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, 100670817);
    TypewriterBehavior.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr, 100670818);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88452, XrefRangeEnd = 88501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void ProcessFrame(Playable playable, FrameData info, Il2CppSystem.Object playerData)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &playable;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &info;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) playerData);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TypewriterBehavior.NativeMethodInfoPtr_ProcessFrame_Public_Virtual_Void_Playable_FrameData_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 88501, XrefRangeEnd = 88502, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnPlayableDestroy(Playable playable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &playable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TypewriterBehavior.NativeMethodInfoPtr_OnPlayableDestroy_Public_Virtual_Void_Playable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(291)]
  [CachedScanResults(RefRangeStart = 1, RefRangeEnd = 292, XrefRangeStart = 1, XrefRangeEnd = 292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TypewriterBehavior()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypewriterBehavior>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TypewriterBehavior.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe UITextTypeWriter typewriter
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_typewriter));
      return num == System.IntPtr.Zero ? (UITextTypeWriter) null : Il2CppObjectPool.Get<UITextTypeWriter>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_typewriter), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe float prevTotalWeight
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_prevTotalWeight));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_prevTotalWeight)) = value;
    }
  }

  public unsafe ArticyRef textLine
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_textLine));
      return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TypewriterBehavior.NativeFieldInfoPtr_textLine), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
