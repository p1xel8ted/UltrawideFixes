// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionDetailsGetSessionAttributeCountOptionsInternal
// Assembly: Replaced.ThirdParty, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 5BB34CA5-FAE3-498C-9E12-F1D8E27E39D2
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Replaced.ThirdParty.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions;

[StructLayout(LayoutKind.Explicit)]
public struct SessionDetailsGetSessionAttributeCountOptionsInternal
{
  private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Void_SessionDetailsGetSessionAttributeCountOptions_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
  [FieldOffset(0)]
  public int m_ApiVersion;

  static SessionDetailsGetSessionAttributeCountOptionsInternal()
  {
    Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Replaced.ThirdParty.dll", "Epic.OnlineServices.Sessions", nameof (SessionDetailsGetSessionAttributeCountOptionsInternal));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr);
    SessionDetailsGetSessionAttributeCountOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
    SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsGetSessionAttributeCountOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr, 100665770);
    SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr, 100665771);
    SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr, 100665772);
  }

  [CallerCount(0)]
  public unsafe void Set(
    SessionDetailsGetSessionAttributeCountOptions other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Void_SessionDetailsGetSessionAttributeCountOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 378379, XrefRangeEnd = 378381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Set(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(15159)]
  [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Dispose()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(SessionDetailsGetSessionAttributeCountOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionDetailsGetSessionAttributeCountOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
  }
}
