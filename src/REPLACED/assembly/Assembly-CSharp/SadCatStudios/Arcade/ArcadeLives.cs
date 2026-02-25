// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Arcade.ArcadeLives
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SadCatStudios.Arcade;

public class ArcadeLives(IntPtr pointer) : MonoBehaviour(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_lifeImages;
  private static readonly IntPtr NativeFieldInfoPtr_currentLives;
  private static readonly IntPtr NativeMethodInfoPtr_get_MaxLives_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_CurrentLives_Public_get_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr_set_CurrentLives_Public_set_Void_Int32_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArcadeLives()
  {
    Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Arcade", nameof (ArcadeLives));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr);
    ArcadeLives.NativeFieldInfoPtr_lifeImages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, nameof (lifeImages));
    ArcadeLives.NativeFieldInfoPtr_currentLives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, nameof (currentLives));
    ArcadeLives.NativeMethodInfoPtr_get_MaxLives_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, 100676733);
    ArcadeLives.NativeMethodInfoPtr_get_CurrentLives_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, 100676734);
    ArcadeLives.NativeMethodInfoPtr_set_CurrentLives_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, 100676735);
    ArcadeLives.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr, 100676736);
  }

  public unsafe int MaxLives
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 126116, RefRangeEnd = 126117, XrefRangeStart = 126116, XrefRangeEnd = 126116, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeLives.NativeMethodInfoPtr_get_MaxLives_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe int CurrentLives
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArcadeLives.NativeMethodInfoPtr_get_CurrentLives_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 126120, RefRangeEnd = 126125, XrefRangeStart = 126117, XrefRangeEnd = 126120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1]
      {
        (IntPtr) &value
      };
      IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ArcadeLives.NativeMethodInfoPtr_set_CurrentLives_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(222)]
  [CachedScanResults(RefRangeStart = 358, RefRangeEnd = 580, XrefRangeStart = 358, XrefRangeEnd = 580, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArcadeLives()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArcadeLives>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArcadeLives.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Il2CppReferenceArray<Image> lifeImages
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeLives.NativeFieldInfoPtr_lifeImages));
      return num == IntPtr.Zero ? (Il2CppReferenceArray<Image>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Image>>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArcadeLives.NativeFieldInfoPtr_lifeImages), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int currentLives
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeLives.NativeFieldInfoPtr_currentLives));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArcadeLives.NativeFieldInfoPtr_currentLives)) = value;
    }
  }
}
