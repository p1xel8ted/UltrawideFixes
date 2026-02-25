// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.InputPin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Articy.Unity;
using Articy.Unity.Interfaces;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace Articy.Replaced;

[Serializable]
public class InputPin(System.IntPtr pointer) : ArticyPrimitive(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConnections;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptCondition_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static InputPin()
  {
    Il2CppClassPointerStore<InputPin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (InputPin));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputPin>.NativeClassPtr);
    InputPin.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPin>.NativeClassPtr, nameof (mText));
    InputPin.NativeFieldInfoPtr_mOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPin>.NativeClassPtr, nameof (mOwner));
    InputPin.NativeFieldInfoPtr_mConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputPin>.NativeClassPtr, nameof (mConnections));
    InputPin.NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678337);
    InputPin.NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678338);
    InputPin.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678339);
    InputPin.NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678340);
    InputPin.NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678341);
    InputPin.NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678342);
    InputPin.NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678343);
    InputPin.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678344);
    InputPin.NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678345);
    InputPin.NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678346);
    InputPin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputPin>.NativeClassPtr, 100678347);
  }

  public unsafe ArticyScriptCondition Text
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 136254, RefRangeEnd = 136257, XrefRangeStart = 136253, XrefRangeEnd = 136254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyScriptCondition>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136257, XrefRangeEnd = 136258, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptCondition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyObject Owner
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 136260, RefRangeEnd = 136263, XrefRangeStart = 136258, XrefRangeEnd = 136260, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136263, XrefRangeEnd = 136265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<OutgoingConnection> Connections
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 136266, RefRangeEnd = 136271, XrefRangeStart = 136265, XrefRangeEnd = 136266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<OutgoingConnection>) null : Il2CppObjectPool.Get<List<OutgoingConnection>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136271, XrefRangeEnd = 136272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136272, XrefRangeEnd = 136279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IOutgoingConnection> GetOutgoingConnections()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IOutgoingConnection>) null : Il2CppObjectPool.Get<List<IOutgoingConnection>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136279, XrefRangeEnd = 136281, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe bool Evaluate(
    [Optional] IBaseScriptMethodProvider aMethodProvider,
    [Optional] IGlobalVariables aGlobalVariables)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Boolean_IBaseScriptMethodProvider_IGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 136310, RefRangeEnd = 136311, XrefRangeStart = 136281, XrefRangeEnd = 136310, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136311, XrefRangeEnd = 136330, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InputPin.NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136330, XrefRangeEnd = 136345, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe InputPin()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputPin>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(InputPin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyScriptCondition mText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptCondition) null : Il2CppObjectPool.Get<ArticyValueArticyScriptCondition>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyObject mOwner
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mOwner));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueListOutgoingConnection mConnections
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mConnections));
      return num == System.IntPtr.Zero ? (ArticyValueListOutgoingConnection) null : Il2CppObjectPool.Get<ArticyValueListOutgoingConnection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputPin.NativeFieldInfoPtr_mConnections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
