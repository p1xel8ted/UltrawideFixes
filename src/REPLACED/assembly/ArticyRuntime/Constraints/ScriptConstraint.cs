// Decompiled with JetBrains decompiler
// Type: Articy.Unity.Constraints.ScriptConstraint
// Assembly: ArticyRuntime, Version=1.3.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F698248B-6003-4F1C-96FC-7042E54E0E7D
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\ArticyRuntime.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Unity.Constraints;

public sealed class ScriptConstraint(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__PlaceHolder_k__BackingField;
  private static readonly System.IntPtr NativeFieldInfoPtr__ScriptType_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_PlaceHolder_Private_set_Void_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_ScriptType_Public_get_ScriptType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_ScriptType_Private_set_Void_ScriptType_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

  static ScriptConstraint()
  {
    Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr = IL2CPP.GetIl2CppClass("ArticyRuntime.dll", "Articy.Unity.Constraints", nameof (ScriptConstraint));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr);
    ScriptConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, "<PlaceHolder>k__BackingField");
    ScriptConstraint.NativeFieldInfoPtr__ScriptType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, "<ScriptType>k__BackingField");
    ScriptConstraint.NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, 100664627);
    ScriptConstraint.NativeMethodInfoPtr_set_PlaceHolder_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, 100664628);
    ScriptConstraint.NativeMethodInfoPtr_get_ScriptType_Public_get_ScriptType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, 100664629);
    ScriptConstraint.NativeMethodInfoPtr_set_ScriptType_Private_set_Void_ScriptType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, 100664630);
    ScriptConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr, 100664631);
  }

  public unsafe string PlaceHolder
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptConstraint.NativeMethodInfoPtr_get_PlaceHolder_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return IL2CPP.Il2CppStringToManaged(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 68808, RefRangeEnd = 68811, XrefRangeStart = 68808, XrefRangeEnd = 68811, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.ManagedStringToIl2Cpp(value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptConstraint.NativeMethodInfoPtr_set_PlaceHolder_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe ScriptType ScriptType
  {
    [CallerCount(7), CachedScanResults(RefRangeStart = 21272, RefRangeEnd = 21279, XrefRangeStart = 21272, XrefRangeEnd = 21279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ScriptConstraint.NativeMethodInfoPtr_get_ScriptType_Public_get_ScriptType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(ScriptType*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(3), CachedScanResults(RefRangeStart = 64888, RefRangeEnd = 64891, XrefRangeStart = 64888, XrefRangeEnd = 64891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(ScriptConstraint.NativeMethodInfoPtr_set_ScriptType_Private_set_Void_ScriptType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 1000134, RefRangeEnd = 1000137, XrefRangeStart = 1000122, XrefRangeEnd = 1000134, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScriptConstraint(string aScriptType, string aPlaceHolder)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptConstraint>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(aScriptType);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(aPlaceHolder);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(ScriptConstraint.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe string _PlaceHolder_k__BackingField
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptConstraint.NativeFieldInfoPtr__PlaceHolder_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe ScriptType _ScriptType_k__BackingField
  {
    get
    {
      return *(ScriptType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptConstraint.NativeFieldInfoPtr__ScriptType_k__BackingField));
    }
    [param: In] set
    {
      *(ScriptType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptConstraint.NativeFieldInfoPtr__ScriptType_k__BackingField)) = value;
    }
  }
}
