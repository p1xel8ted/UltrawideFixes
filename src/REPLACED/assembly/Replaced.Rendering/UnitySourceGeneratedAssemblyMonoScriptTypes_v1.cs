// Decompiled with JetBrains decompiler
// Type: UnitySourceGeneratedAssemblyMonoScriptTypes_v1
// Assembly: Replaced.Rendering, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D285D39E-64D8-4503-AC6E-53BD55A674A4
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.Rendering.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
public class UnitySourceGeneratedAssemblyMonoScriptTypes_v1(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
  {
    Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.Rendering.dll", "", nameof (UnitySourceGeneratedAssemblyMonoScriptTypes_v1));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr);
    UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663301 /*0x06000005*/);
    UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, 100663302 /*0x06000006*/);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 923710, XrefRangeEnd = 923721, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData Get()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr_Get_Private_Static_MonoScriptData_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
    return new UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData(pointer);
  }

  [CallerCount(3004)]
  [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe UnitySourceGeneratedAssemblyMonoScriptTypes_v1()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public sealed class MonoScriptData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FilePathsData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TypesData;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalTypes;
    private static readonly System.IntPtr NativeFieldInfoPtr_TotalFiles;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEditorOnly;

    static MonoScriptData()
    {
      Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1>.NativeClassPtr, nameof (MonoScriptData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr);
      UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, nameof (FilePathsData));
      UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, nameof (TypesData));
      UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, nameof (TotalTypes));
      UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, nameof (TotalFiles));
      UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr, nameof (IsEditorOnly));
    }

    public MonoScriptData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public MonoScriptData()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData>.NativeClassPtr))
    {
    }

    public unsafe Il2CppStructArray<byte> FilePathsData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_FilePathsData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppStructArray<byte> TypesData
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData));
        return num == System.IntPtr.Zero ? (Il2CppStructArray<byte>) null : Il2CppObjectPool.Get<Il2CppStructArray<byte>>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TypesData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int TotalTypes
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalTypes)) = value;
      }
    }

    public unsafe int TotalFiles
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_TotalFiles)) = value;
      }
    }

    public unsafe bool IsEditorOnly
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(UnitySourceGeneratedAssemblyMonoScriptTypes_v1.MonoScriptData.NativeFieldInfoPtr_IsEditorOnly)) = value;
      }
    }
  }
}
