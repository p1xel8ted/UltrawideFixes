// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.IGameFlowSerializable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

#nullable disable
namespace SadCatStudios.Foundation;

public class IGameFlowSerializable(System.IntPtr pointer) : Il2CppObjectBase(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_get_SerializablePriority_Public_Virtual_New_get_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetId_Public_Virtual_New_Type_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Object_ICheckpointSender_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_Object_0;

  static IGameFlowSerializable()
  {
    Il2CppClassPointerStore<IGameFlowSerializable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (IGameFlowSerializable));
    IGameFlowSerializable.NativeMethodInfoPtr_get_SerializablePriority_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameFlowSerializable>.NativeClassPtr, 100671318);
    IGameFlowSerializable.NativeMethodInfoPtr_GetId_Public_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameFlowSerializable>.NativeClassPtr, 100671319);
    IGameFlowSerializable.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Object_ICheckpointSender_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameFlowSerializable>.NativeClassPtr, 100671320);
    IGameFlowSerializable.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IGameFlowSerializable>.NativeClassPtr, 100671321);
  }

  public virtual unsafe int SerializablePriority
  {
    [CallerCount(193), CachedScanResults(RefRangeStart = 65039, RefRangeEnd = 65232, XrefRangeStart = 65039, XrefRangeEnd = 65232, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num1;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameFlowSerializable.NativeMethodInfoPtr_get_SerializablePriority_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
      Il2CppException.RaiseExceptionIfNecessary(num1);
      return *(int*) IL2CPP.il2cpp_object_unbox(num2);
    }
  }

  [CallerCount(15)]
  [CachedScanResults(RefRangeStart = 89593, RefRangeEnd = 89608, XrefRangeStart = 89593, XrefRangeEnd = 89608, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public virtual unsafe Il2CppSystem.Type GetId()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameFlowSerializable.NativeMethodInfoPtr_GetId_Public_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Type) null : Il2CppObjectPool.Get<Il2CppSystem.Type>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe Il2CppSystem.Object Serialize(ICheckpointSender checkpointSender)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) checkpointSender)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameFlowSerializable.NativeMethodInfoPtr_Serialize_Public_Abstract_Virtual_New_Object_ICheckpointSender_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Il2CppSystem.Object) null : Il2CppObjectPool.Get<Il2CppSystem.Object>(num3);
  }

  [CallerCount(0)]
  public virtual unsafe void Deserialize(Il2CppSystem.Object data)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), IGameFlowSerializable.NativeMethodInfoPtr_Deserialize_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }
}
