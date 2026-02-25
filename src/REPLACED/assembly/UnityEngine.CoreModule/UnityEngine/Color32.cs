// Decompiled with JetBrains decompiler
// Type: UnityEngine.Color32
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine;

[StructLayout(LayoutKind.Explicit)]
public struct Color32
{
  private static readonly System.IntPtr NativeFieldInfoPtr_rgba;
  private static readonly System.IntPtr NativeFieldInfoPtr_r;
  private static readonly System.IntPtr NativeFieldInfoPtr_g;
  private static readonly System.IntPtr NativeFieldInfoPtr_b;
  private static readonly System.IntPtr NativeFieldInfoPtr_a;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  [FieldOffset(0)]
  public int rgba;
  [FieldOffset(0)]
  public byte r;
  [FieldOffset(1)]
  public byte g;
  [FieldOffset(2)]
  public byte b;
  [FieldOffset(3)]
  public byte a;

  static Color32()
  {
    Il2CppClassPointerStore<Color32>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (Color32));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Color32>.NativeClassPtr);
    Color32.NativeFieldInfoPtr_rgba = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, nameof (rgba));
    Color32.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, nameof (r));
    Color32.NativeFieldInfoPtr_g = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, nameof (g));
    Color32.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, nameof (b));
    Color32.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Color32>.NativeClassPtr, nameof (a));
    Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667275);
    Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667276);
    Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667277);
    Color32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667278);
    Color32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667279);
    Color32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667280 /*0x06000F90*/);
    Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667281);
    Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Color32>.NativeClassPtr, 100667282);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 438115, RefRangeEnd = 438116, XrefRangeStart = 438115, XrefRangeEnd = 438115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Color32(byte r, byte g, byte b, byte a)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &r;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &g;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &a;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr__ctor_Public_Void_Byte_Byte_Byte_Byte_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(106)]
  [CachedScanResults(RefRangeStart = 438124, RefRangeEnd = 438230, XrefRangeStart = 438116, XrefRangeEnd = 438124, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe implicit operator Color32(Color c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color32_Color_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color32*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public static unsafe implicit operator Color(Color32 c)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &c
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_op_Implicit_Public_Static_Color_Color32_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(Color*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438230, XrefRangeEnd = 438233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(Color32 other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Color32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438233, XrefRangeEnd = 438234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 438234, XrefRangeEnd = 438262, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Color32.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Color32>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static Color32 Lerp(Color32 a, Color32 b, float t)
  {
    t = Mathf.Clamp01(t);
    return new Color32((byte) ((double) a.r + (double) ((int) b.r - (int) a.r) * (double) t), (byte) ((double) a.g + (double) ((int) b.g - (int) a.g) * (double) t), (byte) ((double) a.b + (double) ((int) b.b - (int) a.b) * (double) t), (byte) ((double) a.a + (double) ((int) b.a - (int) a.a) * (double) t));
  }

  public static Color32 LerpUnclamped(Color32 a, Color32 b, float t)
  {
    return new Color32((byte) ((double) a.r + (double) ((int) b.r - (int) a.r) * (double) t), (byte) ((double) a.g + (double) ((int) b.g - (int) a.g) * (double) t), (byte) ((double) a.b + (double) ((int) b.b - (int) a.b) * (double) t), (byte) ((double) a.a + (double) ((int) b.a - (int) a.a) * (double) t));
  }

  public byte this[int index]
  {
    get
    {
      switch (index)
      {
        case 0:
          return this.r;
        case 1:
          return this.g;
        case 2:
          return this.b;
        case 3:
          return this.a;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
      }
    }
    set
    {
      switch (index)
      {
        case 0:
          this.r = value;
          break;
        case 1:
          this.g = value;
          break;
        case 2:
          this.b = value;
          break;
        case 3:
          this.a = value;
          break;
        default:
          throw new Il2CppSystem.IndexOutOfRangeException(Il2CppSystem.String.Concat("Invalid Color32 index(", index.ToString(), ")!"));
      }
    }
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);
}
