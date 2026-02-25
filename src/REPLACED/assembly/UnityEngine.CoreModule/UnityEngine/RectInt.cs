// Decompiled with JetBrains decompiler
// Type: UnityEngine.RectInt
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
public struct RectInt
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_XMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_YMin;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0;
  [FieldOffset(0)]
  public int m_XMin;
  [FieldOffset(4)]
  public int m_YMin;
  [FieldOffset(8)]
  public int m_Width;
  [FieldOffset(12)]
  public int m_Height;

  static RectInt()
  {
    Il2CppClassPointerStore<RectInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (RectInt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectInt>.NativeClassPtr);
    RectInt.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, nameof (m_XMin));
    RectInt.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, nameof (m_YMin));
    RectInt.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, nameof (m_Width));
    RectInt.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, nameof (m_Height));
    RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664557);
    RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664558);
    RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664559);
    RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664560 /*0x060004F0*/);
    RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664561);
    RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664562);
    RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664563);
    RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664564);
    RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664565);
    RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664566);
    RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664567);
    RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664568);
    RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664569);
    RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664570);
    RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664571);
    RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664572);
    RectInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664573);
    RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664574);
    RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664575);
  }

  public unsafe int x
  {
    [CallerCount(239), CachedScanResults(RefRangeStart = 260243, RefRangeEnd = 260482, XrefRangeStart = 260243, XrefRangeEnd = 260482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(19), CachedScanResults(RefRangeStart = 148228, RefRangeEnd = 148247, XrefRangeStart = 148228, XrefRangeEnd = 148247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int y
  {
    [CallerCount(59), CachedScanResults(RefRangeStart = 328510, RefRangeEnd = 328569, XrefRangeStart = 328510, XrefRangeEnd = 328569, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147707, RefRangeEnd = 147711, XrefRangeStart = 147707, XrefRangeEnd = 147711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int width
  {
    [CallerCount(34), CachedScanResults(RefRangeStart = 327541, RefRangeEnd = 327575, XrefRangeStart = 327541, XrefRangeEnd = 327575, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(5), CachedScanResults(RefRangeStart = 147413, RefRangeEnd = 147418, XrefRangeStart = 147413, XrefRangeEnd = 147418, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int height
  {
    [CallerCount(113), CachedScanResults(RefRangeStart = 327414, RefRangeEnd = 327527, XrefRangeStart = 327414, XrefRangeEnd = 327527, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(4), CachedScanResults(RefRangeStart = 147852, RefRangeEnd = 147856, XrefRangeStart = 147852, XrefRangeEnd = 147856, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe int xMin
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422164, XrefRangeEnd = 422168, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      int xMax = this.xMax;
      this.m_XMin = value;
      this.m_Width = xMax - this.m_XMin;
    }
  }

  public unsafe int yMin
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422168, XrefRangeEnd = 422172, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      int yMax = this.yMax;
      this.m_YMin = value;
      this.m_Height = yMax - this.m_YMin;
    }
  }

  public unsafe int xMax
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422172, XrefRangeEnd = 422176, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Width = value - this.m_XMin;
  }

  public unsafe int yMax
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422176, XrefRangeEnd = 422180, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set => this.m_Height = value - this.m_YMin;
  }

  [CallerCount(17)]
  [CachedScanResults(RefRangeStart = 148568, RefRangeEnd = 148585, XrefRangeStart = 148568, XrefRangeEnd = 148585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe RectInt(int xMin, int yMin, int width, int height)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[4];
    numPtr[0] = (System.IntPtr) &xMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &yMin;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &width;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &height;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 422213, RefRangeEnd = 422214, XrefRangeStart = 422180, XrefRangeEnd = 422213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool Overlaps(RectInt other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422214, XrefRangeEnd = 422215, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422215, XrefRangeEnd = 422233, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422233, XrefRangeEnd = 422237, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 422237, XrefRangeEnd = 422240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(RectInt other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectInt>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public Vector2 center
  {
    get
    {
      return new Vector2((float) this.x + (float) this.m_Width / 2f, (float) this.y + (float) this.m_Height / 2f);
    }
  }

  public Vector2Int min
  {
    get => new Vector2Int(this.xMin, this.yMin);
    set
    {
      this.xMin = value.x;
      this.yMin = value.y;
    }
  }

  public Vector2Int max
  {
    get => new Vector2Int(this.xMax, this.yMax);
    set
    {
      this.xMax = value.x;
      this.yMax = value.y;
    }
  }

  public Vector2Int position
  {
    get => new Vector2Int(this.m_XMin, this.m_YMin);
    set
    {
      this.m_XMin = value.x;
      this.m_YMin = value.y;
    }
  }

  public Vector2Int size
  {
    get => new Vector2Int(this.m_Width, this.m_Height);
    set
    {
      this.m_Width = value.x;
      this.m_Height = value.y;
    }
  }

  public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
  {
    this.min = minPosition;
    this.max = maxPosition;
  }

  public static RectInt zero => new RectInt(0, 0, 0, 0);

  public void ClampToBounds(RectInt bounds)
  {
    this.position = new Vector2Int(Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.xMax, this.position.x), bounds.xMin), Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.yMax, this.position.y), bounds.yMin));
    this.size = new Vector2Int(Il2CppSystem.Math.Min(bounds.xMax - this.position.x, this.size.x), Il2CppSystem.Math.Min(bounds.yMax - this.position.y, this.size.y));
  }

  public bool Contains(Vector2Int position)
  {
    return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static bool operator !=(RectInt lhs, RectInt rhs) => !(lhs == rhs);

  public static bool operator ==(RectInt lhs, RectInt rhs)
  {
    return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
  }

  public RectInt.PositionEnumerator allPositionsWithin
  {
    get => new RectInt.PositionEnumerator(this.min, this.max);
  }

  public struct PositionEnumerator
  {
  }
}
