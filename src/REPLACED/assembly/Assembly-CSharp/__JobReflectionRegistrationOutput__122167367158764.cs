// Decompiled with JetBrains decompiler
// Type: __JobReflectionRegistrationOutput__1221673671587648887
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
public class __JobReflectionRegistrationOutput__1221673671587648887(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0;

  static __JobReflectionRegistrationOutput__1221673671587648887()
  {
    Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1221673671587648887>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (__JobReflectionRegistrationOutput__1221673671587648887));
    __JobReflectionRegistrationOutput__1221673671587648887.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1221673671587648887>.NativeClassPtr, 100679896);
    __JobReflectionRegistrationOutput__1221673671587648887.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__JobReflectionRegistrationOutput__1221673671587648887>.NativeClassPtr, 100679897);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 147355, RefRangeEnd = 147356, XrefRangeStart = 147348, XrefRangeEnd = 147355, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void CreateJobReflectionData()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1221673671587648887.NativeMethodInfoPtr_CreateJobReflectionData_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 147356, XrefRangeEnd = 147359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void EarlyInit()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(__JobReflectionRegistrationOutput__1221673671587648887.NativeMethodInfoPtr_EarlyInit_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
