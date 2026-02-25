// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.GlobalVariables.ArticyGlobalVariables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.GlobalVariables;

[Serializable]
public class ArticyGlobalVariables(IntPtr pointer) : BaseGlobalVariables(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_mQuests;
  private static readonly IntPtr NativeFieldInfoPtr_mMain;
  private static readonly IntPtr NativeMethodInfoPtr_get_Quests_Public_get_Quests_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Main_Public_get_Main_0;
  private static readonly IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_ArticyGlobalVariables_0;
  private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_ArticyGlobalVariables_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static ArticyGlobalVariables()
  {
    Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.GlobalVariables", nameof (ArticyGlobalVariables));
    ArticyGlobalVariables.NativeFieldInfoPtr_mQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, nameof (mQuests));
    ArticyGlobalVariables.NativeFieldInfoPtr_mMain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, nameof (mMain));
    ArticyGlobalVariables.NativeMethodInfoPtr_get_Quests_Public_get_Quests_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679015);
    ArticyGlobalVariables.NativeMethodInfoPtr_get_Main_Public_get_Main_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679016);
    ArticyGlobalVariables.NativeMethodInfoPtr_get_Default_Public_Static_get_ArticyGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679017);
    ArticyGlobalVariables.NativeMethodInfoPtr_Init_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679018);
    ArticyGlobalVariables.NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_ArticyGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679019);
    ArticyGlobalVariables.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr, 100679020);
  }

  public unsafe Quests Quests
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyGlobalVariables.NativeMethodInfoPtr_get_Quests_Public_get_Quests_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Quests) null : Il2CppObjectPool.Get<Quests>(num3);
    }
  }

  public unsafe Main Main
  {
    [CallerCount(1), CachedScanResults(RefRangeStart = 72966, RefRangeEnd = 72967, XrefRangeStart = 72966, XrefRangeEnd = 72967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyGlobalVariables.NativeMethodInfoPtr_get_Main_Public_get_Main_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (Main) null : Il2CppObjectPool.Get<Main>(num3);
    }
  }

  public static unsafe ArticyGlobalVariables Default
  {
    [CallerCount(9), CachedScanResults(RefRangeStart = 140053, RefRangeEnd = 140062, XrefRangeStart = 140047, XrefRangeEnd = 140053, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr num1;
      IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyGlobalVariables.NativeMethodInfoPtr_get_Default_Public_Static_get_ArticyGlobalVariables_0, IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      IntPtr num3 = num2;
      return num3 == IntPtr.Zero ? (ArticyGlobalVariables) null : Il2CppObjectPool.Get<ArticyGlobalVariables>(num3);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140062, XrefRangeEnd = 140716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void Init()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ArticyGlobalVariables.NativeMethodInfoPtr_Init_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140716, XrefRangeEnd = 140722, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe ArticyGlobalVariables CreateGlobalVariablesClone()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num1;
    IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ArticyGlobalVariables.NativeMethodInfoPtr_CreateGlobalVariablesClone_Public_Static_ArticyGlobalVariables_0, IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    IntPtr num3 = num2;
    return num3 == IntPtr.Zero ? (ArticyGlobalVariables) null : Il2CppObjectPool.Get<ArticyGlobalVariables>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140722, XrefRangeEnd = 140734, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ArticyGlobalVariables()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArticyGlobalVariables>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ArticyGlobalVariables.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe Quests mQuests
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyGlobalVariables.NativeFieldInfoPtr_mQuests));
      return num == IntPtr.Zero ? (Quests) null : Il2CppObjectPool.Get<Quests>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyGlobalVariables.NativeFieldInfoPtr_mQuests), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Main mMain
  {
    get
    {
      IntPtr num = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArticyGlobalVariables.NativeFieldInfoPtr_mMain));
      return num == IntPtr.Zero ? (Main) null : Il2CppObjectPool.Get<Main>(num);
    }
    [param: In] set
    {
      IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ArticyGlobalVariables.NativeFieldInfoPtr_mMain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
