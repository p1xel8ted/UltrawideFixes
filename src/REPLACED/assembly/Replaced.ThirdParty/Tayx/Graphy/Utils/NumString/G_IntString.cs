// Decompiled with JetBrains decompiler
// Type: Tayx.Graphy.Utils.NumString.G_IntString
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
namespace Tayx.Graphy.Utils.NumString;

public static class G_IntString : Il2CppSystem.Object
{
  private static readonly System.IntPtr NativeFieldInfoPtr_negativeBuffer;
  private static readonly System.IntPtr NativeFieldInfoPtr_positiveBuffer;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0;

  static G_IntString()
  {
    Il2CppClassPointerStore<G_IntString>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Tayx.Graphy.Utils.NumString", nameof (G_IntString));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<G_IntString>.NativeClassPtr);
    G_IntString.NativeFieldInfoPtr_negativeBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, nameof (negativeBuffer));
    G_IntString.NativeFieldInfoPtr_positiveBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, nameof (positiveBuffer));
    G_IntString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100663543 /*0x060000F7*/);
    G_IntString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100663544 /*0x060000F8*/);
    G_IntString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100663545 /*0x060000F9*/);
    G_IntString.NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100663546 /*0x060000FA*/);
    G_IntString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<G_IntString>.NativeClassPtr, 100663547 /*0x060000FB*/);
  }

  public static unsafe bool Inited
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361975, XrefRangeEnd = 361979, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_Inited_Public_Static_get_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe int MinValue
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361979, XrefRangeEnd = 361983, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_MinValue_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public static unsafe int MaxValue
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 361983, XrefRangeEnd = 361987, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_get_MaxValue_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 362010, RefRangeEnd = 362011, XrefRangeStart = 361987, XrefRangeEnd = 362010, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Init(int minNegativeValue, int maxPositiveValue)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &minNegativeValue;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxPositiveValue;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_Init_Public_Static_Void_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(7)]
  [CachedScanResults(RefRangeStart = 362018, RefRangeEnd = 362025, XrefRangeStart = 362011, XrefRangeEnd = 362018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe string ToStringNonAlloc(this int value)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &value
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(G_IntString.NativeMethodInfoPtr_ToStringNonAlloc_Public_Static_String_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public G_IntString(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public static unsafe Il2CppStringArray negativeBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(G_IntString.NativeFieldInfoPtr_negativeBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_IntString.NativeFieldInfoPtr_negativeBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public static unsafe Il2CppStringArray positiveBuffer
  {
    get
    {
      System.IntPtr num1;
      IL2CPP.il2cpp_field_static_get_value(G_IntString.NativeFieldInfoPtr_positiveBuffer, (void*) &num1);
      System.IntPtr num2 = num1;
      return num2 == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num2);
    }
    [param: In] set
    {
      IL2CPP.il2cpp_field_static_set_value(G_IntString.NativeFieldInfoPtr_positiveBuffer, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
