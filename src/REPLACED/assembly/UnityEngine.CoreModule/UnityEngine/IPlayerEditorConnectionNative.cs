// Decompiled with JetBrains decompiler
// Type: UnityEngine.IPlayerEditorConnectionNative
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

#nullable disable
namespace UnityEngine;

public class IPlayerEditorConnectionNative(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0;

  static IPlayerEditorConnectionNative()
  {
    Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", nameof (IPlayerEditorConnectionNative));
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667682);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667683);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667684);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667685);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667686);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667687);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667688);
    IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100667689);
  }

  [CallerCount(0)]
  public virtual unsafe void Initialize()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void DisconnectAll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void SendMessage(
    Il2CppSystem.Guid messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool TrySendMessage(
    Il2CppSystem.Guid messageId,
    Il2CppStructArray<byte> data,
    int playerId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[3];
    numPtr[0] = (System.IntPtr) &messageId;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playerId;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  public virtual unsafe void Poll()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void RegisterInternal(Il2CppSystem.Guid messageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe void UnregisterInternal(Il2CppSystem.Guid messageId)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      (System.IntPtr) &messageId
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(0)]
  public virtual unsafe bool IsConnected()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }
}
