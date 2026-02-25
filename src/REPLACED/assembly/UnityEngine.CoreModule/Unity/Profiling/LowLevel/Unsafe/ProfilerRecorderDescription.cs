// Decompiled with JetBrains decompiler
// Type: Unity.Profiling.LowLevel.Unsafe.ProfilerRecorderDescription
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace Unity.Profiling.LowLevel.Unsafe;

[StructLayout(LayoutKind.Explicit)]
public struct ProfilerRecorderDescription
{
  private static readonly System.IntPtr NativeFieldInfoPtr_category;
  private static readonly System.IntPtr NativeFieldInfoPtr_flags;
  private static readonly System.IntPtr NativeFieldInfoPtr_dataType;
  private static readonly System.IntPtr NativeFieldInfoPtr_unitType;
  private static readonly System.IntPtr NativeFieldInfoPtr_reserved0;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameUtf8Len;
  private static readonly System.IntPtr NativeFieldInfoPtr_nameUtf8;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0;
  [FieldOffset(0)]
  public readonly ProfilerCategory category;
  [FieldOffset(2)]
  public readonly MarkerFlags flags;
  [FieldOffset(4)]
  public readonly ProfilerMarkerDataType dataType;
  [FieldOffset(5)]
  public readonly ProfilerMarkerDataUnit unitType;
  [FieldOffset(8)]
  public readonly int reserved0;
  [FieldOffset(12)]
  public readonly int nameUtf8Len;
  [FieldOffset(16 /*0x10*/)]
  public readonly System.IntPtr nameUtf8;

  static ProfilerRecorderDescription()
  {
    Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "Unity.Profiling.LowLevel.Unsafe", nameof (ProfilerRecorderDescription));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr);
    ProfilerRecorderDescription.NativeFieldInfoPtr_category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (category));
    ProfilerRecorderDescription.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (flags));
    ProfilerRecorderDescription.NativeFieldInfoPtr_dataType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (dataType));
    ProfilerRecorderDescription.NativeFieldInfoPtr_unitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (unitType));
    ProfilerRecorderDescription.NativeFieldInfoPtr_reserved0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (reserved0));
    ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8Len = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (nameUtf8Len));
    ProfilerRecorderDescription.NativeFieldInfoPtr_nameUtf8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, nameof (nameUtf8));
    ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, 100663418 /*0x0600007A*/);
  }

  public unsafe MarkerFlags Flags
  {
    [CallerCount(0)] get
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ProfilerRecorderDescription.NativeMethodInfoPtr_get_Flags_Public_get_MarkerFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(MarkerFlags*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public Il2CppSystem.Object BoxIl2CppObject()
  {
    return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ProfilerRecorderDescription>.NativeClassPtr, (System.IntPtr) ref this));
  }

  public ProfilerCategory Category => this.category;

  public ProfilerMarkerDataType DataType => this.dataType;

  public ProfilerMarkerDataUnit UnitType => this.unitType;

  public int NameUtf8Len => this.nameUtf8Len;

  public unsafe byte* NameUtf8 => (byte*) this.nameUtf8;

  public unsafe string Name
  {
    get => ProfilerUnsafeUtility.Utf8ToString((byte*) this.nameUtf8, this.nameUtf8Len);
  }
}
