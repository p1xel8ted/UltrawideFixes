// Decompiled with JetBrains decompiler
// Type: UnityEngine.SparseTexture
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Bindings;
using UnityEngine.Experimental.Rendering;

#nullable disable
namespace UnityEngine;

public sealed class SparseTexture : Texture
{
  private static readonly SparseTexture.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<SparseTexture.Internal_CreateDelegate>("UnityEngine.SparseTexture::Internal_Create");
  private static readonly SparseTexture.get_tileWidth_InjectedDelegate get_tileWidth_InjectedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileWidth_InjectedDelegate>("UnityEngine.SparseTexture::get_tileWidth_Injected");
  private static readonly SparseTexture.get_tileHeight_InjectedDelegate get_tileHeight_InjectedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_tileHeight_InjectedDelegate>("UnityEngine.SparseTexture::get_tileHeight_Injected");
  private static readonly SparseTexture.get_isCreated_InjectedDelegate get_isCreated_InjectedDelegateField = IL2CPP.ResolveICall<SparseTexture.get_isCreated_InjectedDelegate>("UnityEngine.SparseTexture::get_isCreated_Injected");
  private static readonly SparseTexture.UpdateTile_InjectedDelegate UpdateTile_InjectedDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTile_InjectedDelegate>("UnityEngine.SparseTexture::UpdateTile_Injected");
  private static readonly SparseTexture.UpdateTileRaw_InjectedDelegate UpdateTileRaw_InjectedDelegateField = IL2CPP.ResolveICall<SparseTexture.UpdateTileRaw_InjectedDelegate>("UnityEngine.SparseTexture::UpdateTileRaw_Injected");

  public int tileWidth
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<SparseTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SparseTexture.get_tileWidth_Injected(_unity_self);
    }
  }

  public int tileHeight
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<SparseTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SparseTexture.get_tileHeight_Injected(_unity_self);
    }
  }

  public bool isCreated
  {
    get
    {
      System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<SparseTexture>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SparseTexture.get_isCreated_Injected(_unity_self);
    }
  }

  public static void Internal_Create(
    SparseTexture mono,
    int width,
    int height,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    int mipCount)
  {
    SparseTexture.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mono), width, height, format, colorSpace, mipCount);
  }

  public unsafe void UpdateTile(
    int tileX,
    int tileY,
    int miplevel,
    Il2CppStructArray<Color32> data)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<SparseTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int tileX1 = tileX;
    int tileY1 = tileY;
    int miplevel1 = miplevel;
    Il2CppSystem.Span<Color32> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<Color32>) ref span).\u002Ector((Il2CppArrayBase<Color32>) data);
    fixed (Color32* begin = &((Il2CppSystem.Span<Color32>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<Color32>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      SparseTexture.UpdateTile_Injected(_unity_self, tileX1, tileY1, miplevel1, ref local);
    }
  }

  public unsafe void UpdateTileRaw(
    int tileX,
    int tileY,
    int miplevel,
    Il2CppStructArray<byte> data)
  {
    System.IntPtr _unity_self = Object.MarshalledUnityObject.MarshalNotNull<SparseTexture>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    int tileX1 = tileX;
    int tileY1 = tileY;
    int miplevel1 = miplevel;
    Il2CppSystem.Span<byte> span;
    // ISSUE: explicit constructor call
    ((Il2CppSystem.Span<byte>) ref span).\u002Ector((Il2CppArrayBase<byte>) data);
    fixed (byte* begin = &((Il2CppSystem.Span<byte>) ref span).GetPinnableReference())
    {
      ManagedSpanWrapper managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.Span<byte>) ref span).Length);
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      SparseTexture.UpdateTileRaw_Injected(_unity_self, tileX1, tileY1, miplevel1, ref local);
    }
  }

  public void UnloadTile(int tileX, int tileY, int miplevel)
  {
    this.UpdateTileRaw(tileX, tileY, miplevel, (Il2CppStructArray<byte>) null);
  }

  public bool ValidateFormat(TextureFormat format, int width, int height)
  {
    bool flag = this.ValidateFormat(format);
    if (flag && TextureFormat.PVRTC_RGB2 <= format && format <= TextureFormat.PVRTC_RGBA4 && (width != height || !Mathf.IsPowerOfTwo(width)))
      throw new UnityException(Il2CppSystem.String.Format("'{0}' demands texture to be square and have power-of-two dimensions", (Il2CppSystem.Object) format.ToString()));
    return flag;
  }

  public bool ValidateFormat(GraphicsFormat format, int width, int height)
  {
    bool flag = this.ValidateFormat(format, GraphicsFormatUsage.Sparse);
    if (flag && GraphicsFormatUtility.IsPVRTCFormat(format) && (width != height || !Mathf.IsPowerOfTwo(width)))
      throw new UnityException(Il2CppSystem.String.Format("'{0}' demands texture to be square and have power-of-two dimensions", (Il2CppSystem.Object) format.ToString()));
    return flag;
  }

  public bool ValidateSize(int width, int height, GraphicsFormat format)
  {
    if ((long) GraphicsFormatUtility.GetBlockSize(format) * ((long) width / (long) GraphicsFormatUtility.GetBlockWidth(format)) * ((long) height / (long) GraphicsFormatUtility.GetBlockHeight(format)) >= 65536L /*0x010000*/)
      return true;
    Debug.LogError((Il2CppSystem.Object) "SparseTexture creation failed. The minimum size in bytes of a SparseTexture is 64KB.", (Object) this);
    return false;
  }

  public static void ValidateIsNotCrunched(TextureFormat textureFormat)
  {
    if (GraphicsFormatUtility.IsCrunchFormat(textureFormat))
      throw new Il2CppSystem.ArgumentException("Crunched SparseTexture is not supported.");
  }

  public static int get_tileWidth_Injected(System.IntPtr _unity_self)
  {
    return SparseTexture.get_tileWidth_InjectedDelegateField(_unity_self);
  }

  public static int get_tileHeight_Injected(System.IntPtr _unity_self)
  {
    return SparseTexture.get_tileHeight_InjectedDelegateField(_unity_self);
  }

  public static bool get_isCreated_Injected(System.IntPtr _unity_self)
  {
    return SparseTexture.get_isCreated_InjectedDelegateField(_unity_self);
  }

  public static void UpdateTile_Injected(
    System.IntPtr _unity_self,
    int tileX,
    int tileY,
    int miplevel,
    ref ManagedSpanWrapper data)
  {
    SparseTexture.UpdateTile_InjectedDelegateField(_unity_self, tileX, tileY, miplevel, (System.IntPtr) ref data);
  }

  public static void UpdateTileRaw_Injected(
    System.IntPtr _unity_self,
    int tileX,
    int tileY,
    int miplevel,
    ref ManagedSpanWrapper data)
  {
    SparseTexture.UpdateTileRaw_InjectedDelegateField(_unity_self, tileX, tileY, miplevel, (System.IntPtr) ref data);
  }

  private delegate void Internal_CreateDelegate(
    System.IntPtr mono,
    int width,
    int height,
    GraphicsFormat format,
    TextureColorSpace colorSpace,
    int mipCount);

  private delegate int get_tileWidth_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int get_tileHeight_InjectedDelegate(System.IntPtr _unity_self);

  private delegate bool get_isCreated_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void UpdateTile_InjectedDelegate(
    System.IntPtr _unity_self,
    int tileX,
    int tileY,
    int miplevel,
    System.IntPtr data);

  private delegate void UpdateTileRaw_InjectedDelegate(
    System.IntPtr _unity_self,
    int tileX,
    int tileY,
    int miplevel,
    System.IntPtr data);
}
