// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.DrawingSettings
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

[StructLayout(LayoutKind.Explicit)]
public struct DrawingSettings
{
  private static readonly System.IntPtr NativeFieldInfoPtr_maxShaderPasses;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_SortingSettings;
  private static readonly System.IntPtr NativeFieldInfoPtr_shaderPassNames;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_PerObjectData;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideShaderID;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideShaderPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideMaterialInstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_OverrideMaterialPassIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_fallbackMaterialInstanceId;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_MainLightIndex;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_UseSrpBatcher;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0;
  [FieldOffset(0)]
  public SortingSettings m_SortingSettings;
  [FieldOffset(96 /*0x60*/)]
  public DrawingSettings._shaderPassNames_e__FixedBuffer shaderPassNames;
  [FieldOffset(160 /*0xA0*/)]
  public PerObjectData m_PerObjectData;
  [FieldOffset(164)]
  public DrawRendererFlags m_Flags;
  [FieldOffset(168)]
  public int m_OverrideShaderID;
  [FieldOffset(172)]
  public int m_OverrideShaderPassIndex;
  [FieldOffset(176 /*0xB0*/)]
  public int m_OverrideMaterialInstanceId;
  [FieldOffset(180)]
  public int m_OverrideMaterialPassIndex;
  [FieldOffset(184)]
  public int m_fallbackMaterialInstanceId;
  [FieldOffset(188)]
  public int m_MainLightIndex;
  [FieldOffset(192 /*0xC0*/)]
  public int m_UseSrpBatcher;
  public const int kMaxShaderPasses = 16 /*0x10*/;

  static DrawingSettings()
  {
    Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (DrawingSettings));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr);
    DrawingSettings.NativeFieldInfoPtr_maxShaderPasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (maxShaderPasses));
    DrawingSettings.NativeFieldInfoPtr_m_SortingSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_SortingSettings));
    DrawingSettings.NativeFieldInfoPtr_shaderPassNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (shaderPassNames));
    DrawingSettings.NativeFieldInfoPtr_m_PerObjectData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_PerObjectData));
    DrawingSettings.NativeFieldInfoPtr_m_Flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_Flags));
    DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_OverrideShaderID));
    DrawingSettings.NativeFieldInfoPtr_m_OverrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_OverrideShaderPassIndex));
    DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_OverrideMaterialInstanceId));
    DrawingSettings.NativeFieldInfoPtr_m_OverrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_OverrideMaterialPassIndex));
    DrawingSettings.NativeFieldInfoPtr_m_fallbackMaterialInstanceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_fallbackMaterialInstanceId));
    DrawingSettings.NativeFieldInfoPtr_m_MainLightIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_MainLightIndex));
    DrawingSettings.NativeFieldInfoPtr_m_UseSrpBatcher = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, nameof (m_UseSrpBatcher));
    DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670372);
    DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670373);
    DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670374);
    DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670375);
    DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670376);
    DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670377);
    DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670378);
    DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670379);
    DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670380);
    DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670381);
    DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670382);
    DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670383);
    DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, 100670384);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 487573, RefRangeEnd = 487576, XrefRangeStart = 487568, XrefRangeEnd = 487573, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DrawingSettings(ShaderTagId shaderPassName, SortingSettings sortingSettings)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &shaderPassName;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sortingSettings;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr__ctor_Public_Void_ShaderTagId_SortingSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe PerObjectData perObjectData
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487576, RefRangeEnd = 487578, XrefRangeStart = 487576, XrefRangeEnd = 487576, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_perObjectData_Public_set_Void_PerObjectData_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_PerObjectData;
  }

  public unsafe bool enableInstancing
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 487578, RefRangeEnd = 487580, XrefRangeStart = 487578, XrefRangeEnd = 487578, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_enableInstancing_Public_set_Void_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => (this.m_Flags & DrawRendererFlags.EnableInstancing) != 0;
  }

  public unsafe Material overrideMaterial
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487580, XrefRangeEnd = 487581, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterial_Public_set_Void_Material_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      return this.m_OverrideMaterialInstanceId != 0 ? UnityEngine.Object.FindObjectFromInstanceID(this.m_OverrideMaterialInstanceId).TryCast<Material>() : (Material) null;
    }
  }

  public unsafe Shader overrideShader
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487581, XrefRangeEnd = 487582, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShader_Public_set_Void_Shader_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get
    {
      return this.m_OverrideShaderID != 0 ? UnityEngine.Object.FindObjectFromInstanceID(this.m_OverrideShaderID).TryCast<Shader>() : (Shader) null;
    }
  }

  public unsafe int overrideMaterialPassIndex
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideMaterialPassIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_OverrideMaterialPassIndex;
  }

  public unsafe int overrideShaderPassIndex
  {
    [CallerCount(0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_set_overrideShaderPassIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
    get => this.m_OverrideShaderPassIndex;
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 487586, RefRangeEnd = 487588, XrefRangeStart = 487582, XrefRangeEnd = 487586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ShaderTagId GetShaderPassName(int index)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &index
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetShaderPassName_Public_ShaderTagId_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(ShaderTagId*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 487592, RefRangeEnd = 487595, XrefRangeStart = 487588, XrefRangeEnd = 487592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetShaderPassName(int index, ShaderTagId shaderPassName)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &index;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &shaderPassName;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_SetShaderPassName_Public_Void_Int32_ShaderTagId_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(3)]
  [CachedScanResults(RefRangeStart = 487605, RefRangeEnd = 487608, XrefRangeStart = 487595, XrefRangeEnd = 487605, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(DrawingSettings other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_DrawingSettings_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487608, XrefRangeEnd = 487614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object obj)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487614, XrefRangeEnd = 487615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 487615, XrefRangeEnd = 487619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool operator ==(DrawingSettings left, DrawingSettings right)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &left;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &right;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DrawingSettings.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_DrawingSettings_DrawingSettings_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static unsafe int maxShaderPasses
  {
    get
    {
      int maxShaderPasses;
      IL2CPP.il2cpp_field_static_get_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*) &maxShaderPasses);
      return maxShaderPasses;
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(DrawingSettings.NativeFieldInfoPtr_maxShaderPasses, (void*) &value);
    }
  }

  public SortingSettings sortingSettings
  {
    get => this.m_SortingSettings;
    set => this.m_SortingSettings = value;
  }

  public bool enableDynamicBatching
  {
    get => (this.m_Flags & DrawRendererFlags.EnableDynamicBatching) != 0;
    set
    {
      if (value)
        this.m_Flags |= DrawRendererFlags.EnableDynamicBatching;
      else
        this.m_Flags &= ~DrawRendererFlags.EnableDynamicBatching;
    }
  }

  public Material fallbackMaterial
  {
    get
    {
      return this.m_fallbackMaterialInstanceId != 0 ? UnityEngine.Object.FindObjectFromInstanceID(this.m_fallbackMaterialInstanceId).TryCast<Material>() : (Material) null;
    }
    set => this.m_fallbackMaterialInstanceId = value != null ? value.GetInstanceID() : 0;
  }

  public int mainLightIndex
  {
    get => this.m_MainLightIndex;
    set => this.m_MainLightIndex = value;
  }

  public static bool operator !=(DrawingSettings left, DrawingSettings right)
  {
    return !left.Equals(right);
  }

  [ObfuscatedName("UnityEngine.Rendering.DrawingSettings+<shaderPassNames>e__FixedBuffer")]
  [StructLayout(LayoutKind.Explicit)]
  public struct _shaderPassNames_e__FixedBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FixedElementField;
    [FieldOffset(0)]
    public int FixedElementField;

    static _shaderPassNames_e__FixedBuffer()
    {
      Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DrawingSettings>.NativeClassPtr, "<shaderPassNames>e__FixedBuffer");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr);
      DrawingSettings._shaderPassNames_e__FixedBuffer.NativeFieldInfoPtr_FixedElementField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, nameof (FixedElementField));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DrawingSettings._shaderPassNames_e__FixedBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
