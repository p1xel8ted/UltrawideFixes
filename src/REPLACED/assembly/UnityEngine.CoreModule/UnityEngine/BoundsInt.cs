// Decompiled with JetBrains decompiler
// Type: UnityEngine.BoundsInt
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
public struct BoundsInt
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Position;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_Size;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_zMin_Public_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public Vector3Int m_Position;
  [FieldOffset(12)]
  public Vector3Int m_Size;

  static BoundsInt()
  {
    Il2CppClassPointerStore<BoundsInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (BoundsInt));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr);
    BoundsInt.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, nameof (m_Position));
    BoundsInt.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, nameof (m_Size));
    BoundsInt.NativeMethodInfoPtr_get_min_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664468);
    BoundsInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664469);
    BoundsInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664470);
    BoundsInt.NativeMethodInfoPtr_get_zMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664471);
    BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664472);
    BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664473);
    BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664474);
    BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664475);
    BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664476);
    BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664477);
    BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664478);
    BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664479);
    BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664480 /*0x060004A0*/);
    BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664481);
  }

  public unsafe Vector3Int min
  {
    [CallerCount(2), CachedScanResults(RefRangeStart = 421883, RefRangeEnd = 421885, XrefRangeStart = 421871, XrefRangeEnd = 421883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_min_Public_get_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      this.xMin = value.x;
      this.yMin = value.y;
      this.zMin = value.z;
    }
  }

  public unsafe int xMin
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421885, XrefRangeEnd = 421889, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      int xMax = this.xMax;
      this.m_Position.x = value;
      this.m_Size.x = xMax - this.m_Position.x;
    }
  }

  public unsafe int yMin
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421889, XrefRangeEnd = 421893, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      int yMax = this.yMax;
      this.m_Position.y = value;
      this.m_Size.y = yMax - this.m_Position.y;
    }
  }

  public unsafe int zMin
  {
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421893, XrefRangeEnd = 421897, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_zMin_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    set
    {
      int zMax = this.zMax;
      this.m_Position.z = value;
      this.m_Size.z = zMax - this.m_Position.z;
    }
  }

  public unsafe Vector3Int position
  {
    [CallerCount(60), CachedScanResults(RefRangeStart = 421732, RefRangeEnd = 421792, XrefRangeStart = 421732, XrefRangeEnd = 421792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(8), CachedScanResults(RefRangeStart = 327327, RefRangeEnd = 327335, XrefRangeStart = 327327, XrefRangeEnd = 327335, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe Vector3Int size
  {
    [CallerCount(28), CachedScanResults(RefRangeStart = 421792, RefRangeEnd = 421820, XrefRangeStart = 421792, XrefRangeEnd = 421820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(Vector3Int*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(6), CachedScanResults(RefRangeStart = 421820, RefRangeEnd = 421826, XrefRangeStart = 421820, XrefRangeEnd = 421826, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe BoundsInt(Vector3Int position, Vector3Int size)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &position;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &size;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421897, XrefRangeEnd = 421898, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421898, XrefRangeEnd = 421918, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe string ToString(string format, Il2CppSystem.IFormatProvider formatProvider)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(format);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) formatProvider);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421918, XrefRangeEnd = 421921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe bool Equals(BoundsInt other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &other
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 421921, XrefRangeEnd = 421923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public int x
  {
    get => this.m_Position.x;
    set => this.m_Position.x = value;
  }

  public int y
  {
    get => this.m_Position.y;
    set => this.m_Position.y = value;
  }

  public int z
  {
    get => this.m_Position.z;
    set => this.m_Position.z = value;
  }

  public Vector3 center
  {
    get
    {
      return new Vector3((float) this.x + (float) this.m_Size.x / 2f, (float) this.y + (float) this.m_Size.y / 2f, (float) this.z + (float) this.m_Size.z / 2f);
    }
  }

  public Vector3Int max
  {
    get => new Vector3Int(this.xMax, this.yMax, this.zMax);
    set
    {
      this.xMax = value.x;
      this.yMax = value.y;
      this.zMax = value.z;
    }
  }

  public int xMax
  {
    get => Il2CppSystem.Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
    set => this.m_Size.x = value - this.m_Position.x;
  }

  public int yMax
  {
    get => Il2CppSystem.Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
    set => this.m_Size.y = value - this.m_Position.y;
  }

  public int zMax
  {
    get => Il2CppSystem.Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
    set => this.m_Size.z = value - this.m_Position.z;
  }

  public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
  {
    this.min = minPosition;
    this.max = maxPosition;
  }

  public void ClampToBounds(BoundsInt bounds)
  {
    this.position = new Vector3Int(Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.xMax, this.position.x), bounds.xMin), Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.yMax, this.position.y), bounds.yMin), Il2CppSystem.Math.Max(Il2CppSystem.Math.Min(bounds.zMax, this.position.z), bounds.zMin));
    this.size = new Vector3Int(Il2CppSystem.Math.Min(bounds.xMax - this.position.x, this.size.x), Il2CppSystem.Math.Min(bounds.yMax - this.position.y, this.size.y), Il2CppSystem.Math.Min(bounds.zMax - this.position.z, this.size.z));
  }

  public bool Contains(Vector3Int position)
  {
    return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
  }

  public string ToString(string format) => this.ToString(format, (Il2CppSystem.IFormatProvider) null);

  public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
  {
    return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
  }

  public static bool operator !=(BoundsInt lhs, BoundsInt rhs) => !(lhs == rhs);

  public BoundsInt.PositionEnumerator allPositionsWithin
  {
    get => new BoundsInt.PositionEnumerator(this.min, this.max);
  }

  public struct PositionEnumerator
  {
  }
}
