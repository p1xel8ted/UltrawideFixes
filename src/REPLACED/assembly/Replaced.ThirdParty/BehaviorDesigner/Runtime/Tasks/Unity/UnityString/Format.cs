// Decompiled with JetBrains decompiler
// Type: BehaviorDesigner.Runtime.Tasks.Unity.UnityString.Format
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace BehaviorDesigner.Runtime.Tasks.Unity.UnityString;

public class Format(System.IntPtr pointer) : BehaviorDesigner.Runtime.Tasks.Action(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_format;
  private static readonly System.IntPtr NativeFieldInfoPtr_variables;
  private static readonly System.IntPtr NativeFieldInfoPtr_storeResult;
  private static readonly System.IntPtr NativeFieldInfoPtr_variableValues;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static Format()
  {
    Il2CppClassPointerStore<Format>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "BehaviorDesigner.Runtime.Tasks.Unity.UnityString", nameof (Format));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Format>.NativeClassPtr);
    Format.NativeFieldInfoPtr_format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, nameof (format));
    Format.NativeFieldInfoPtr_variables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, nameof (variables));
    Format.NativeFieldInfoPtr_storeResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, nameof (storeResult));
    Format.NativeFieldInfoPtr_variableValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Format>.NativeClassPtr, nameof (variableValues));
    Format.NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100674294);
    Format.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100674295);
    Format.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100674296);
    Format.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Format>.NativeClassPtr, 100674297);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406686, XrefRangeEnd = 406689, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Format.NativeMethodInfoPtr_OnAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406689, XrefRangeEnd = 406701, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe TaskStatus OnUpdate()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Format.NativeMethodInfoPtr_OnUpdate_Public_Virtual_TaskStatus_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(TaskStatus*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 406701, XrefRangeEnd = 406704, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void OnReset()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Format.NativeMethodInfoPtr_OnReset_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Format()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Format>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Format.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe SharedString format
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_format));
      return num == System.IntPtr.Zero ? (SharedString) null : Il2CppObjectPool.Get<SharedString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_format), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<SharedGenericVariable> variables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_variables));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<SharedGenericVariable>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<SharedGenericVariable>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_variables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe SharedString storeResult
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_storeResult));
      return num == System.IntPtr.Zero ? (SharedString) null : Il2CppObjectPool.Get<SharedString>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_storeResult), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe Il2CppReferenceArray<Il2CppSystem.Object> variableValues
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_variableValues));
      return num == System.IntPtr.Zero ? (Il2CppReferenceArray<Il2CppSystem.Object>) null : Il2CppObjectPool.Get<Il2CppReferenceArray<Il2CppSystem.Object>>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Format.NativeFieldInfoPtr_variableValues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
