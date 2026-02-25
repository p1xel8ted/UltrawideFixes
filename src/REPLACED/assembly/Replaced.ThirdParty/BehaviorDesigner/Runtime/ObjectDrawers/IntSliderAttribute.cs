// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.ObjectDrawers.IntSliderAttribute
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using BehaviorDesigner.Runtime.Tasks;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.ObjectDrawers;

public class IntSliderAttribute(IntPtr pointer) : ObjectDrawerAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_min;
  private static readonly IntPtr NativeFieldInfoPtr_max;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

  static IntSliderAttribute()
  {
    Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.ObjectDrawers", nameof (IntSliderAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr);
    IntSliderAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr, nameof (min));
    IntSliderAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr, nameof (max));
    IntSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr, 100675607);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413305, XrefRangeEnd = 413306, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IntSliderAttribute(int min, int max)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSliderAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &min;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IntSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe int min
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntSliderAttribute.NativeFieldInfoPtr_min));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntSliderAttribute.NativeFieldInfoPtr_min)) = value;
    }
  }

  public unsafe int max
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntSliderAttribute.NativeFieldInfoPtr_max));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(IntSliderAttribute.NativeFieldInfoPtr_max)) = value;
    }
  }
}
