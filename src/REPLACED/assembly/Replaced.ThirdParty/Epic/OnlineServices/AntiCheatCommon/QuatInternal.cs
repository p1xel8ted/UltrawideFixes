// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.QuatInternal
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
public struct QuatInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_w;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_x;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_y;
  private static readonly System.IntPtr NativeFieldInfoPtr_m_z;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_w_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_w_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_z_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_z_Public_set_Void_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_Quat_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public float m_w;
  [FieldOffset(4)]
  public float m_x;
  [FieldOffset(8)]
  public float m_y;
  [FieldOffset(12)]
  public float m_z;

  static QuatInternal()
  {
    Il2CppClassPointerStore<QuatInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (QuatInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr);
    QuatInternal.NativeFieldInfoPtr_m_w = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_w));
    QuatInternal.NativeFieldInfoPtr_m_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_x));
    QuatInternal.NativeFieldInfoPtr_m_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_y));
    QuatInternal.NativeFieldInfoPtr_m_z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, nameof (m_z));
    QuatInternal.NativeMethodInfoPtr_get_w_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672927);
    QuatInternal.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672928);
    QuatInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672929);
    QuatInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672930);
    QuatInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672931);
    QuatInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672932);
    QuatInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672933);
    QuatInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672934);
    QuatInternal.NativeMethodInfoPtr_Set_Public_Void_Quat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672935);
    QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672936);
    QuatInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, 100672937);
  }

  public unsafe float w
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_w_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
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
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_w_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float x
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_x_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(22), CachedScanResults(RefRangeStart = 400905, RefRangeEnd = 400927, XrefRangeStart = 400905, XrefRangeEnd = 400905, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float y
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_y_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(13), CachedScanResults(RefRangeStart = 400927, RefRangeEnd = 400940, XrefRangeStart = 400927, XrefRangeEnd = 400927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe float z
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_get_z_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
    [CallerCount(11), CachedScanResults(RefRangeStart = 400940, RefRangeEnd = 400951, XrefRangeStart = 400940, XrefRangeEnd = 400940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        (System.IntPtr) &value
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_set_z_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  public unsafe void Set(Quat other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Set_Public_Void_Quat_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 400951, XrefRangeEnd = 400953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(QuatInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<QuatInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
