// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.ObjectDrawers.FloatSliderAttribute
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

public class FloatSliderAttribute(IntPtr pointer) : ObjectDrawerAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_min;
  private static readonly IntPtr NativeFieldInfoPtr_max;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

  static FloatSliderAttribute()
  {
    Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.ObjectDrawers", nameof (FloatSliderAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr);
    FloatSliderAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr, nameof (min));
    FloatSliderAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr, nameof (max));
    FloatSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr, 100675606);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413304, XrefRangeEnd = 413305, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe FloatSliderAttribute(float min, float max)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FloatSliderAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &min;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(FloatSliderAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatSliderAttribute.NativeFieldInfoPtr_min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatSliderAttribute.NativeFieldInfoPtr_min)) = value;
    }
  }

  public unsafe float max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatSliderAttribute.NativeFieldInfoPtr_max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FloatSliderAttribute.NativeFieldInfoPtr_max)) = value;
    }
  }
}
