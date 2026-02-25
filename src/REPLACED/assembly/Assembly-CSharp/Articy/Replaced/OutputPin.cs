// Decompiled with JetBrains decompiler
// Type: Articy.Replaced.OutputPin
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
public class OutputPin(System.IntPtr pointer) : ArticyPrimitive(pointer)
{
  private static readonly System.IntPtr NativeFieldInfoPtr_mText;
  private static readonly System.IntPtr NativeFieldInfoPtr_mOwner;
  private static readonly System.IntPtr NativeFieldInfoPtr_mConnections;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptInstruction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptInstruction_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_IBaseScriptMethodProvider_IGlobalVariables_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  static OutputPin()
  {
    Il2CppClassPointerStore<OutputPin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Articy.Replaced", nameof (OutputPin));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutputPin>.NativeClassPtr);
    OutputPin.NativeFieldInfoPtr_mText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, nameof (mText));
    OutputPin.NativeFieldInfoPtr_mOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, nameof (mOwner));
    OutputPin.NativeFieldInfoPtr_mConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, nameof (mConnections));
    OutputPin.NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678447);
    OutputPin.NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptInstruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678448);
    OutputPin.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678449);
    OutputPin.NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678450);
    OutputPin.NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678451);
    OutputPin.NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678452);
    OutputPin.NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678453);
    OutputPin.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_IBaseScriptMethodProvider_IGlobalVariables_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678454);
    OutputPin.NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678455);
    OutputPin.NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678456);
    OutputPin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutputPin>.NativeClassPtr, 100678457);
  }

  public unsafe ArticyScriptInstruction Text
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 136254, RefRangeEnd = 136257, XrefRangeStart = 136254, XrefRangeEnd = 136257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_get_Text_Public_get_ArticyScriptInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyScriptInstruction) null : Il2CppObjectPool.Get<ArticyScriptInstruction>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_set_Text_Public_set_Void_ArticyScriptInstruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public virtual unsafe ArticyObject Owner
  {
    [CallerCount(3), CachedScanResults(RefRangeStart = 136260, RefRangeEnd = 136263, XrefRangeStart = 136260, XrefRangeEnd = 136263, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_get_Owner_Public_Virtual_Final_New_get_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (ArticyObject) null : Il2CppObjectPool.Get<ArticyObject>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_set_Owner_Public_set_Void_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  public unsafe List<OutgoingConnection> Connections
  {
    [CallerCount(5), CachedScanResults(RefRangeStart = 136266, RefRangeEnd = 136271, XrefRangeStart = 136266, XrefRangeEnd = 136271, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_get_Connections_Public_get_List_1_OutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      System.IntPtr num3 = num2;
      return num3 == System.IntPtr.Zero ? (List<OutgoingConnection>) null : Il2CppObjectPool.Get<List<OutgoingConnection>>(num3);
    }
    [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_set_Connections_Public_set_Void_List_1_OutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137111, XrefRangeEnd = 137118, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe List<IOutgoingConnection> GetOutgoingConnections()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_GetOutgoingConnections_Public_Virtual_Final_New_List_1_IOutgoingConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (List<IOutgoingConnection>) null : Il2CppObjectPool.Get<List<IOutgoingConnection>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137118, XrefRangeEnd = 137120, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe void Evaluate(
    [Optional] IBaseScriptMethodProvider aMethodProvider,
    [Optional] IGlobalVariables aGlobalVariables)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aMethodProvider);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aGlobalVariables);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_Evaluate_Public_Virtual_Final_New_Void_IBaseScriptMethodProvider_IGlobalVariables_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 137149, RefRangeEnd = 137150, XrefRangeStart = 137120, XrefRangeEnd = 137149, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void CloneProperties(Il2CppSystem.Object aClone, ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aClone);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr_CloneProperties_Protected_Void_Object_ArticyObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137150, XrefRangeEnd = 137169, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe Il2CppSystem.Object CloneObject(
    Il2CppSystem.Object aParent,
    ArticyObject aFirstClassParent)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aParent);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) aFirstClassParent);
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), OutputPin.NativeMethodInfoPtr_CloneObject_Public_Virtual_Object_Object_ArticyObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137169, XrefRangeEnd = 137184, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe OutputPin()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutputPin>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(OutputPin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  public unsafe ArticyValueArticyScriptInstruction mText
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mText));
      return num == System.IntPtr.Zero ? (ArticyValueArticyScriptInstruction) null : Il2CppObjectPool.Get<ArticyValueArticyScriptInstruction>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueArticyObject mOwner
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mOwner));
      return num == System.IntPtr.Zero ? (ArticyValueArticyObject) null : Il2CppObjectPool.Get<ArticyValueArticyObject>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mOwner), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe ArticyValueListOutgoingConnection mConnections
  {
    get
    {
      System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mConnections));
      return num == System.IntPtr.Zero ? (ArticyValueListOutgoingConnection) null : Il2CppObjectPool.Get<ArticyValueListOutgoingConnection>(num);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(OutputPin.NativeFieldInfoPtr_mConnections), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }
}
