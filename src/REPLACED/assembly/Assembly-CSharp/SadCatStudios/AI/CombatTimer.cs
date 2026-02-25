// Decompiled with JetBrains decompiler
// Type: SadCatStudios.AI.CombatTimer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.AI;

public class CombatTimer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_enable;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CountdownTime_Public_Single_Single_Single_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static CombatTimer()
  {
    Il2CppClassPointerStore<CombatTimer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.AI", nameof (CombatTimer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr);
    CombatTimer.NativeFieldInfoPtr_enable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, nameof (enable));
    CombatTimer.NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, 100677905);
    CombatTimer.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, 100677906);
    CombatTimer.NativeMethodInfoPtr_Enable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, 100677907);
    CombatTimer.NativeMethodInfoPtr_CountdownTime_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, 100677908);
    CombatTimer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr, 100677909);
  }

  public unsafe float DeltaTime
  {
    [CallerCount(4), CachedScanResults(RefRangeStart = 132505, RefRangeEnd = 132509, XrefRangeStart = 132504, XrefRangeEnd = 132505, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatTimer.NativeMethodInfoPtr_get_DeltaTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(float*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  public unsafe bool IsEnabled
  {
    [CallerCount(0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatTimer.NativeMethodInfoPtr_get_IsEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 22332, RefRangeEnd = 22333, XrefRangeStart = 22332, XrefRangeEnd = 22333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Enable(bool enable)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &enable
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatTimer.NativeMethodInfoPtr_Enable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(4)]
  [CachedScanResults(RefRangeStart = 132512, RefRangeEnd = 132516, XrefRangeStart = 132509, XrefRangeEnd = 132512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe float CountdownTime(float timer, float maxTime)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &timer;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxTime;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(CombatTimer.NativeMethodInfoPtr_CountdownTime_Public_Single_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(float*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 132517, RefRangeEnd = 132519, XrefRangeStart = 132516, XrefRangeEnd = 132517, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe CombatTimer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CombatTimer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(CombatTimer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe bool enable
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatTimer.NativeFieldInfoPtr_enable));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CombatTimer.NativeFieldInfoPtr_enable)) = value;
    }
  }
}
