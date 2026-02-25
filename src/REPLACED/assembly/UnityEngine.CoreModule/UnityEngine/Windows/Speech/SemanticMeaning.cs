// Decompiled with JetBrains decompiler
// Type: UnityEngine.Windows.Speech.SemanticMeaning
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace UnityEngine.Windows.Speech;

public sealed class SemanticMeaning : Il2CppSystem.ValueType
{
  private static readonly System.IntPtr NativeFieldInfoPtr_key;
  private static readonly System.IntPtr NativeFieldInfoPtr_values;

  static SemanticMeaning()
  {
    Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", nameof (SemanticMeaning));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr);
    SemanticMeaning.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, nameof (key));
    SemanticMeaning.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, nameof (values));
  }

  public SemanticMeaning(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public SemanticMeaning()
    : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr))
  {
  }

  public unsafe string key
  {
    get
    {
      return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key)));
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
    }
  }

  public unsafe Il2CppStringArray values
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values));
      return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
