// Decompiled with JetBrains decompiler
// Type: UnityEngine.Cursor
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

public class Cursor(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0;

  static Cursor()
  {
    Il2CppClassPointerStore<Cursor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Cursor));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Cursor>.NativeClassPtr);
    Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667196);
    Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667197);
    Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667198);
    Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667199);
    Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667200 /*0x06000F40*/);
    Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Cursor>.NativeClassPtr, 100667201);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 437883, RefRangeEnd = 437885, XrefRangeStart = 437878, XrefRangeEnd = 437883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetCursor(Texture2D texture, Vector2 hotspot, CursorMode cursorMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hotspot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cursorMode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Public_Static_Void_Texture2D_Vector2_CursorMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static unsafe bool visible
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 437887, RefRangeEnd = 437889, XrefRangeStart = 437885, XrefRangeEnd = 437887, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_visible_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 437891, RefRangeEnd = 437899, XrefRangeStart = 437889, XrefRangeEnd = 437891, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_visible_Public_Static_set_Void_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public static unsafe CursorLockMode lockState
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 437901, RefRangeEnd = 437905, XrefRangeStart = 437899, XrefRangeEnd = 437901, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_get_lockState_Public_Static_get_CursorLockMode_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(CursorLockMode*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 437907, RefRangeEnd = 437913, XrefRangeStart = 437905, XrefRangeEnd = 437907, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_set_lockState_Public_Static_set_Void_CursorLockMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437913, XrefRangeEnd = 437915, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetCursor_Injected(
    System.IntPtr texture,
    [In] ref Vector2 hotspot,
    CursorMode cursorMode)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &texture;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref hotspot;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &cursorMode;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Cursor.NativeMethodInfoPtr_SetCursor_Injected_Private_Static_Void_IntPtr_byref_Vector2_CursorMode_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public static void SetCursor(Texture2D texture, CursorMode cursorMode)
  {
    Cursor.SetCursor(texture, Vector2.zero, cursorMode);
  }
}
