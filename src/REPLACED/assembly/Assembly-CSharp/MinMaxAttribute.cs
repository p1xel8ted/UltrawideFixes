// Decompiled with JetBrains decompiler
// Type: MinMaxAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class MinMaxAttribute(IntPtr pointer) : PropertyAttribute(pointer)
{
  private static readonly IntPtr NativeFieldInfoPtr_Min;
  private static readonly IntPtr NativeFieldInfoPtr_Max;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

  static MinMaxAttribute()
  {
    Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (MinMaxAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr);
    MinMaxAttribute.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, nameof (Min));
    MinMaxAttribute.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, nameof (Max));
    MinMaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr, 100663615);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21791, XrefRangeEnd = 21792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MinMaxAttribute(float min, float max)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinMaxAttribute>.NativeClassPtr))
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = (IntPtr) &min;
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &max;
    IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MinMaxAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe float Min
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_Min));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_Min)) = value;
    }
  }

  public unsafe float Max
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_Max));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinMaxAttribute.NativeFieldInfoPtr_Max)) = value;
    }
  }
}
