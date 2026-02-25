// Decompiled with JetBrains decompiler
// Type: OrdinalStringComparer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
public class OrdinalStringComparer(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr__ignoreCase;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0;

  static OrdinalStringComparer()
  {
    Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", nameof (OrdinalStringComparer));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr);
    OrdinalStringComparer.NativeFieldInfoPtr__ignoreCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr, nameof (_ignoreCase));
    OrdinalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr, 100663659);
    OrdinalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr, 100663660);
    OrdinalStringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr, 100663661);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22150, XrefRangeEnd = 22151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OrdinalStringComparer()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OrdinalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22151, XrefRangeEnd = 22152, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OrdinalStringComparer(bool ignoreCase)
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrdinalStringComparer>.NativeClassPtr))
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &ignoreCase
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OrdinalStringComparer.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22152, XrefRangeEnd = 22156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe int Compare(string x, string y)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(x);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(y);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OrdinalStringComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(int*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public unsafe bool _ignoreCase
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrdinalStringComparer.NativeFieldInfoPtr__ignoreCase));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OrdinalStringComparer.NativeFieldInfoPtr__ignoreCase)) = value;
    }
  }
}
