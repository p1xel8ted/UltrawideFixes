// Decompiled with JetBrains decompiler
// Type: UnityEngine.AssemblyVersion
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
public struct AssemblyVersion
{
  private static readonly System.IntPtr NativeFieldInfoPtr_major;
  private static readonly System.IntPtr NativeFieldInfoPtr_minor;
  private static readonly System.IntPtr NativeFieldInfoPtr_build;
  private static readonly System.IntPtr NativeFieldInfoPtr_revision;
  private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
  [FieldOffset(0)]
  public ushort major;
  [FieldOffset(2)]
  public ushort minor;
  [FieldOffset(4)]
  public ushort build;
  [FieldOffset(6)]
  public ushort revision;

  static AssemblyVersion()
  {
    Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (AssemblyVersion));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr);
    AssemblyVersion.NativeFieldInfoPtr_major = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, nameof (major));
    AssemblyVersion.NativeFieldInfoPtr_minor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, nameof (minor));
    AssemblyVersion.NativeFieldInfoPtr_build = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, nameof (build));
    AssemblyVersion.NativeFieldInfoPtr_revision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, nameof (revision));
    AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100667958);
    AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100667959);
    AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100667960);
    AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, 100667961);
  }

  [CallerCount(0)]
  public static unsafe bool operator ==(AssemblyVersion lhs, AssemblyVersion rhs)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &lhs;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &rhs;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssemblyVersion_AssemblyVersion_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444580, XrefRangeEnd = 444598, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe string ToString()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return IL2CPP.Il2CppStringToManaged(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 444598, XrefRangeEnd = 444601, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Equals(Il2CppSystem.Object other)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) other)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 444607, RefRangeEnd = 444608, XrefRangeStart = 444601, XrefRangeEnd = 444607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe int GetHashCode()
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(AssemblyVersion.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssemblyVersion>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public static bool operator !=(AssemblyVersion lhs, AssemblyVersion rhs) => !(lhs == rhs);

  public static bool operator <(AssemblyVersion lhs, AssemblyVersion rhs)
  {
    if ((int) lhs.major != (int) rhs.major)
      return (int) lhs.major < (int) rhs.major;
    if ((int) lhs.minor != (int) rhs.minor)
      return (int) lhs.minor < (int) rhs.minor;
    if ((int) lhs.build != (int) rhs.build)
      return (int) lhs.build < (int) rhs.build;
    return (int) lhs.revision != (int) rhs.revision && (int) lhs.revision < (int) rhs.revision;
  }

  public static bool operator >(AssemblyVersion lhs, AssemblyVersion rhs)
  {
    if ((int) lhs.major != (int) rhs.major)
      return (int) lhs.major > (int) rhs.major;
    if ((int) lhs.minor != (int) rhs.minor)
      return (int) lhs.minor > (int) rhs.minor;
    if ((int) lhs.build != (int) rhs.build)
      return (int) lhs.build > (int) rhs.build;
    return (int) lhs.revision != (int) rhs.revision && (int) lhs.revision > (int) rhs.revision;
  }
}
