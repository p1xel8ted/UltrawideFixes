// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeFinalBossGameManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

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

public class ArcadeFinalBossGameManager(IntPtr pointer) : 
  LocalSingletonBehaviour<ArcadeFinalBossGameManager>(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_inputActionLabels;
  private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;
  private static readonly IntPtr NativeFieldInfoPtr_done;
  private static readonly IntPtr NativeFieldInfoPtr_elementBuilder;
  private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_ExitArcade_Public_Void_Boolean_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeFinalBossGameManager()
  {
    Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeFinalBossGameManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr);
    ArcadeFinalBossGameManager.NativeFieldInfoPtr_inputActionLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, nameof (inputActionLabels));
    ArcadeFinalBossGameManager.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, "<Result>k__BackingField");
    ArcadeFinalBossGameManager.NativeFieldInfoPtr_done = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, nameof (done));
    ArcadeFinalBossGameManager.NativeFieldInfoPtr_elementBuilder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, nameof (elementBuilder));
    ArcadeFinalBossGameManager.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676451);
    ArcadeFinalBossGameManager.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676452);
    ArcadeFinalBossGameManager.NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676453);
    ArcadeFinalBossGameManager.NativeMethodInfoPtr_ExitArcade_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676454);
    ArcadeFinalBossGameManager.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676455);
    ArcadeFinalBossGameManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr, 100676456);
  }

  public unsafe bool Result
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 80471, RefRangeEnd = 80472, XrefRangeStart = 80471, XrefRangeEnd = 80472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr_get_Result_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr_set_Result_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123446, XrefRangeEnd = 123455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Init(UniTaskCompletionSource done, int stageIndex)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) done);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &stageIndex;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr_Init_Public_Void_UniTaskCompletionSource_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123455, XrefRangeEnd = 123457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ExitArcade(bool result)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      (IntPtr) &result
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr_ExitArcade_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123457, XrefRangeEnd = 123469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetControlElements(
    Il2CppReferenceArray<ArcadeGameManager.ControlElement> elements)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) elements)
    };
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr_SetControlElements_Public_Void_Il2CppReferenceArray_1_ControlElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123469, XrefRangeEnd = 123476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeFinalBossGameManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeFinalBossGameManager>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeFinalBossGameManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<UIGlyphText> inputActionLabels
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_inputActionLabels));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<UIGlyphText>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<UIGlyphText>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_inputActionLabels), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe bool _Result_k__BackingField
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr__Result_k__BackingField));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr__Result_k__BackingField)) = value;
    }
  }

  public unsafe UniTaskCompletionSource done
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_done));
      return num == IntPtr.Zero ? (UniTaskCompletionSource) null : Il2CppObjectPool.Get<UniTaskCompletionSource>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_done), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe StringBuilder elementBuilder
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_elementBuilder));
      return num == IntPtr.Zero ? (StringBuilder) null : Il2CppObjectPool.Get<StringBuilder>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeFinalBossGameManager.NativeFieldInfoPtr_elementBuilder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
