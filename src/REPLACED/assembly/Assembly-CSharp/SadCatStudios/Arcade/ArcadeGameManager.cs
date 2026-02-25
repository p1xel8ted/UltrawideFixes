// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeGameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Cysharp.Threading.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using SadCatStudios.UI;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeGameManager(System.IntPtr pointer) : LocalSingletonBehaviour<ArcadeGameManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_inputActionLabels;
  private static readonly System.IntPtr NativeFieldInfoPtr_elementBuilder;
  private static readonly System.IntPtr NativeFieldInfoPtr_done;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ExitArcade_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeGameManager()
  {
    Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeGameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr);
    ArcadeGameManager.NativeFieldInfoPtr_inputActionLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, nameof (inputActionLabels));
    ArcadeGameManager.NativeFieldInfoPtr_elementBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, nameof (elementBuilder));
    ArcadeGameManager.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, nameof (done));
    ArcadeGameManager.NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, 100676523);
    ArcadeGameManager.NativeMethodInfoPtr_ExitArcade_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, 100676524);
    ArcadeGameManager.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, 100676525);
    ArcadeGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, 100676526);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 79744, RefRangeEnd = 79745, XrefRangeStart = 79744, XrefRangeEnd = 79745, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(UniTaskCompletionSource done)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) done)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeGameManager.NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123890, XrefRangeEnd = 123892, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitArcade()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeGameManager.NativeMethodInfoPtr_ExitArcade_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(21)]
  [CachedScanResults(RefRangeStart = 123904, RefRangeEnd = 123925, XrefRangeStart = 123892, XrefRangeEnd = 123904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControlElements(
    Il2CppReferenceArray<ArcadeGameManager.ControlElement> elements)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elements)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeGameManager.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123925, XrefRangeEnd = 123932, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeGameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIGlyphText> inputActionLabels
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_inputActionLabels));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<UIGlyphText>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIGlyphText>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_inputActionLabels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder elementBuilder
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_elementBuilder));
      return num == System.IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_elementBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe UniTaskCompletionSource done
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_done));
      return num == System.IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.NativeFieldInfoPtr_done), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public sealed class ControlElement : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NameRef;
    private static readonly System.IntPtr NativeFieldInfoPtr_Action;

    static ControlElement()
    {
      Il2CppClassPointerStore<ArcadeGameManager.ControlElement>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArcadeGameManager>.NativeClassPtr, nameof (ControlElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeGameManager.ControlElement>.NativeClassPtr);
      ArcadeGameManager.ControlElement.NativeFieldInfoPtr_NameRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeGameManager.ControlElement>.NativeClassPtr, nameof (NameRef));
      ArcadeGameManager.ControlElement.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeGameManager.ControlElement>.NativeClassPtr, nameof (Action));
    }

    public ControlElement(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ControlElement()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeGameManager.ControlElement>.NativeClassPtr))
    {
    }

    public unsafe ArticyRef NameRef
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.ControlElement.NativeFieldInfoPtr_NameRef));
        return num == System.IntPtr.Zero ? (ArticyRef) null : Il2CppObjectPool.Get<ArticyRef>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.ControlElement.NativeFieldInfoPtr_NameRef), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe string Action
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.ControlElement.NativeFieldInfoPtr_Action)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeGameManager.ControlElement.NativeFieldInfoPtr_Action), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
