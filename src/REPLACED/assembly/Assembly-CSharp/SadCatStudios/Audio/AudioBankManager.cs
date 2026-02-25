// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Audio.AudioBankManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine.AddressableAssets;

#nullable disable
namespace SadCatStudios.Audio;

public class AudioBankManager(System.IntPtr pointer) : GlobalSingletonBehaviour<AudioBankManager>(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_labelToBanks;
  private static readonly System.IntPtr NativeMethodInfoPtr_LoadBanksForScene_Public_Void_AssetLabelReference_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static AudioBankManager()
  {
    Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Audio", nameof (AudioBankManager));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr);
    AudioBankManager.NativeFieldInfoPtr_labelToBanks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, nameof (labelToBanks));
    AudioBankManager.NativeMethodInfoPtr_LoadBanksForScene_Public_Void_AssetLabelReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, 100676410);
    AudioBankManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, 100676411);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 123280, RefRangeEnd = 123281, XrefRangeStart = 123238, XrefRangeEnd = 123280, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void LoadBanksForScene(AssetLabelReference sceneLabel)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sceneLabel)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioBankManager.NativeMethodInfoPtr_LoadBanksForScene_Public_Void_AssetLabelReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123281, XrefRangeEnd = 123284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe AudioBankManager()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(AudioBankManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe AudioBankManager.LabelToBank labelToBanks
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBankManager.NativeFieldInfoPtr_labelToBanks));
      return num == System.IntPtr.Zero ? (AudioBankManager.LabelToBank) null : Il2CppObjectPool.Get<AudioBankManager.LabelToBank>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioBankManager.NativeFieldInfoPtr_labelToBanks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  [Serializable]
  public class BankInfo(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Banks;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static BankInfo()
    {
      Il2CppClassPointerStore<AudioBankManager.BankInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, nameof (BankInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBankManager.BankInfo>.NativeClassPtr);
      AudioBankManager.BankInfo.NativeFieldInfoPtr_Banks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioBankManager.BankInfo>.NativeClassPtr, nameof (Banks));
      AudioBankManager.BankInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager.BankInfo>.NativeClassPtr, 100676412);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BankInfo()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBankManager.BankInfo>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBankManager.BankInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public unsafe List<string> Banks
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AudioBankManager.BankInfo.NativeFieldInfoPtr_Banks));
        return num == System.IntPtr.Zero ? (List<string>) null : Il2CppObjectPool.Get<List<string>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AudioBankManager.BankInfo.NativeFieldInfoPtr_Banks), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  public class AssetLabelComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetLabelReference_AssetLabelReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_AssetLabelReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static AssetLabelComparer()
    {
      Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, nameof (AssetLabelComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr);
      AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetLabelReference_AssetLabelReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr, 100676413);
      AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_AssetLabelReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr, 100676414);
      AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr, 100676415);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123223, XrefRangeEnd = 123231, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(AssetLabelReference x, AssetLabelReference y)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetLabelReference_AssetLabelReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(0)]
    public virtual unsafe int GetHashCode(AssetLabelReference obj)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
      };
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_New_Int32_AssetLabelReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AssetLabelComparer()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBankManager.AssetLabelComparer>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBankManager.AssetLabelComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [Serializable]
  public class LabelToBank(System.IntPtr pointer) : 
    UnitySerializedDictionary<AssetLabelReference, AudioBankManager.BankInfo>(pointer)
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    static LabelToBank()
    {
      Il2CppClassPointerStore<AudioBankManager.LabelToBank>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AudioBankManager>.NativeClassPtr, nameof (LabelToBank));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioBankManager.LabelToBank>.NativeClassPtr);
      AudioBankManager.LabelToBank.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioBankManager.LabelToBank>.NativeClassPtr, 100676416);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123231, XrefRangeEnd = 123238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LabelToBank()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioBankManager.LabelToBank>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(AudioBankManager.LabelToBank.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }
}
