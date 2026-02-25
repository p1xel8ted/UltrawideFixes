// Decompiled with JetBrains decompiler
// Type: UnityEngineInternal.TypeInferenceRuleAttribute
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngineInternal;

[Serializable]
public class TypeInferenceRuleAttribute(System.IntPtr pointer) : Il2CppSystem.Attribute(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__rule;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

  static TypeInferenceRuleAttribute()
  {
    Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", nameof (TypeInferenceRuleAttribute));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr);
    TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, nameof (_rule));
    TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663301 /*0x06000005*/);
    TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663302 /*0x06000006*/);
    TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr, 100663303 /*0x06000007*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 413306, XrefRangeEnd = 413310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TypeInferenceRuleAttribute(TypeInferenceRules rule)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &rule
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_TypeInferenceRules_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(35)]
  [CachedScanResults(RefRangeStart = 255058, RefRangeEnd = 255093, XrefRangeStart = 255058, XrefRangeEnd = 255093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TypeInferenceRuleAttribute(string rule)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInferenceRuleAttribute>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(rule)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(TypeInferenceRuleAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(211)]
  [CachedScanResults(RefRangeStart = 296220, RefRangeEnd = 296431, XrefRangeStart = 296220, XrefRangeEnd = 296431, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TypeInferenceRuleAttribute.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public unsafe string _rule
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TypeInferenceRuleAttribute.NativeFieldInfoPtr__rule), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }
}
