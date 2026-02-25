// Decompiled with JetBrains decompiler
// Type: UnityEngine.Sprites.DataUtility
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace UnityEngine.Sprites;

public sealed class DataUtility(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0;

  static DataUtility()
  {
    Il2CppClassPointerStore<DataUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Sprites", nameof (DataUtility));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataUtility>.NativeClassPtr);
    DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100670782);
    DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100670783);
    DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100670784);
    DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataUtility>.NativeClassPtr, 100670785);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489921, RefRangeEnd = 489923, XrefRangeStart = 489920, XrefRangeEnd = 489921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetInnerUV(Sprite sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetInnerUV_Public_Static_Vector4_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 489924, RefRangeEnd = 489928, XrefRangeStart = 489923, XrefRangeEnd = 489924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetOuterUV(Sprite sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetOuterUV_Public_Static_Vector4_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 489929, RefRangeEnd = 489931, XrefRangeStart = 489928, XrefRangeEnd = 489929, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector4 GetPadding(Sprite sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetPadding_Public_Static_Vector4_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector4*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 489931, XrefRangeEnd = 489935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe Vector2 GetMinSize(Sprite sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(DataUtility.NativeMethodInfoPtr_GetMinSize_Public_Static_Vector2_Sprite_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Vector2*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
