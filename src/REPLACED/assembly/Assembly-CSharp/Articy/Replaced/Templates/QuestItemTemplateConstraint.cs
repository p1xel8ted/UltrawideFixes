// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.QuestItemTemplateConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Replaced.Features;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced.Templates;

public class QuestItemTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mItem;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static QuestItemTemplateConstraint()
  {
    Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (QuestItemTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr);
    QuestItemTemplateConstraint.NativeFieldInfoPtr_mItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr, nameof (mItem));
    QuestItemTemplateConstraint.NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr, 100678687);
    QuestItemTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr, 100678688);
  }

  public unsafe ItemFeatureConstraint Item
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuestItemTemplateConstraint.NativeMethodInfoPtr_get_Item_Public_get_ItemFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ItemFeatureConstraint) null : Il2CppObjectPool.Get<ItemFeatureConstraint>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138320, RefRangeEnd = 138321, XrefRangeStart = 138315, XrefRangeEnd = 138320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe QuestItemTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestItemTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuestItemTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ItemFeatureConstraint mItem
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(QuestItemTemplateConstraint.NativeFieldInfoPtr_mItem));
      return num == System.IntPtr.Zero ? (ItemFeatureConstraint) null : Il2CppObjectPool.Get<ItemFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(QuestItemTemplateConstraint.NativeFieldInfoPtr_mItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
