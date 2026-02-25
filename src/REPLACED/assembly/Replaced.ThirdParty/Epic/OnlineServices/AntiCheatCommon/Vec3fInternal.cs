// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.Vec3fInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon;

[StructLayout(LayoutKind.Explicit)]
public struct Vec3fInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_z;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Vec3f_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public float m_x;
  [FieldOffset(4)]
  public float m_y;
  [FieldOffset(8)]
  public float m_z;

  static Vec3fInternal()
  {
    Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (Vec3fInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr);
    Vec3fInternal.NativeFieldInfoPtr_m_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, nameof (m_x));
    Vec3fInternal.NativeFieldInfoPtr_m_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, nameof (m_y));
    Vec3fInternal.NativeFieldInfoPtr_m_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, nameof (m_z));
    Vec3fInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100672997);
    Vec3fInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100672998);
    Vec3fInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100672999);
    Vec3fInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673000);
    Vec3fInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673001);
    Vec3fInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673002);
    Vec3fInternal.NativeMethodInfoPtr_Set_Public_Void_Vec3f_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673003);
    Vec3fInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673004);
    Vec3fInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, 100673005);
  }

  public unsafe float x
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(43), CachedScanResults(RefRangeStart = 70541, RefRangeEnd = 70584, XrefRangeStart = 70541, XrefRangeEnd = 70584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float y
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(22), CachedScanResults(RefRangeStart = 400905, RefRangeEnd = 400927, XrefRangeStart = 400905, XrefRangeEnd = 400927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float z
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 400927, RefRangeEnd = 400940, XrefRangeStart = 400927, XrefRangeEnd = 400940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(Vec3f other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_Set_Public_Void_Vec3f_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 401072, XrefRangeEnd = 401074, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(Vec3fInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vec3fInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
