// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.Templates.PDAEntryTemplateConstraint
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

public class PDAEntryTemplateConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mPDAEntryData;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PDAEntryData_Public_get_PDAEntryDataFeatureConstraint_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static PDAEntryTemplateConstraint()
  {
    Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced.Templates", nameof (PDAEntryTemplateConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr);
    PDAEntryTemplateConstraint.NativeFieldInfoPtr_mPDAEntryData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr, nameof (mPDAEntryData));
    PDAEntryTemplateConstraint.NativeMethodInfoPtr_get_PDAEntryData_Public_get_PDAEntryDataFeatureConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr, 100678661);
    PDAEntryTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr, 100678662);
  }

  public unsafe PDAEntryDataFeatureConstraint PDAEntryData
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(PDAEntryTemplateConstraint.NativeMethodInfoPtr_get_PDAEntryData_Public_get_PDAEntryDataFeatureConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (PDAEntryDataFeatureConstraint) null : Il2CppObjectPool.Get<PDAEntryDataFeatureConstraint>(num3);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 138180, RefRangeEnd = 138181, XrefRangeStart = 138175, XrefRangeEnd = 138180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe PDAEntryTemplateConstraint()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PDAEntryTemplateConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(PDAEntryTemplateConstraint.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PDAEntryDataFeatureConstraint mPDAEntryData
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryTemplateConstraint.NativeFieldInfoPtr_mPDAEntryData));
      return num == System.IntPtr.Zero ? (PDAEntryDataFeatureConstraint) null : Il2CppObjectPool.Get<PDAEntryDataFeatureConstraint>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PDAEntryTemplateConstraint.NativeFieldInfoPtr_mPDAEntryData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
