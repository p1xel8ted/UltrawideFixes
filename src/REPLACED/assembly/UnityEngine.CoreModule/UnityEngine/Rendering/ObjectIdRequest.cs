// Decompiled with JetBrains decompiler
// Type: UnityEngine.Rendering.ObjectIdRequest
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Rendering;

public class ObjectIdRequest(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__destination_k__BackingField;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0;

  static ObjectIdRequest()
  {
    Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", nameof (ObjectIdRequest));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr);
    ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr, "<destination>k__BackingField");
    ObjectIdRequest.NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectIdRequest>.NativeClassPtr, 100670396);
  }

  public unsafe RenderTexture destination
  {
    [CallerCount(13), CachedScanResults(RefRangeStart = 68795, RefRangeEnd = 68808, XrefRangeStart = 68795, XrefRangeEnd = 68808, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ObjectIdRequest.NativeMethodInfoPtr_get_destination_Public_get_RenderTexture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (RenderTexture) null : Il2CppObjectPool.Get<RenderTexture>(num3);
    }
    set => this._destination_k__BackingField = value;
  }

  public unsafe RenderTexture _destination_k__BackingField
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField));
      return num == System.IntPtr.Zero ? (RenderTexture) null : Il2CppObjectPool.Get<RenderTexture>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ObjectIdRequest.NativeFieldInfoPtr__destination_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public int mipLevel
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public CubemapFace face
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public int slice
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }

  public ObjectIdResult result
  {
    get => throw new System.NotSupportedException("Method unstripping failed");
    set => throw new System.NotSupportedException("Method unstripping failed");
  }
}
