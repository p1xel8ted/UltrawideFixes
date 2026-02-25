// Decompiled with JetBrains decompiler
// Type: Articy.Unity.UseActualFallbackValue
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity;

public sealed class UseActualFallbackValue(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mVariables;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_Boolean_Branch_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

  static UseActualFallbackValue()
  {
    Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity", nameof (UseActualFallbackValue));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr);
    UseActualFallbackValue.NativeFieldInfoPtr_mVariables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr, nameof (mVariables));
    UseActualFallbackValue.NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_Boolean_Branch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr, 100664066 /*0x06000302*/);
    UseActualFallbackValue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr, 100664067 /*0x06000303*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994675, XrefRangeEnd = 994679, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UseActualFallbackValue(BaseGlobalVariables aVariables, bool aValue, Branch aBranch = null)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UseActualFallbackValue>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aVariables);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &aValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aBranch);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UseActualFallbackValue.NativeMethodInfoPtr__ctor_Public_Void_BaseGlobalVariables_Boolean_Branch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void Dispose()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UseActualFallbackValue.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe BaseGlobalVariables mVariables
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UseActualFallbackValue.NativeFieldInfoPtr_mVariables));
      return num == System.IntPtr.Zero ? (BaseGlobalVariables) null : Il2CppObjectPool.Get<BaseGlobalVariables>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UseActualFallbackValue.NativeFieldInfoPtr_mVariables), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
