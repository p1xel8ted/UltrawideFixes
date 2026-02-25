// Decompiled with JetBrains decompiler
// Type: SadCatStudios.Foundation.MessageBroker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6A27E87B-AC5C-4A27-8A7D-32D5113812FB
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\Assembly-CSharp.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using MessagePipe;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace SadCatStudios.Foundation;

public class MessageBroker(System.IntPtr pointer) : GlobalSingletonBehaviour<MessageBroker>(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSubscriber_Public_ISubscriber_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetPublisher_Public_IPublisher_1_T_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass0_0_0;

  static MessageBroker()
  {
    Il2CppClassPointerStore<MessageBroker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "SadCatStudios.Foundation", nameof (MessageBroker));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr);
    MessageBroker.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, 100671250);
    MessageBroker.NativeMethodInfoPtr_GetSubscriber_Public_ISubscriber_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, 100671251);
    MessageBroker.NativeMethodInfoPtr_GetPublisher_Public_IPublisher_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, 100671252);
    MessageBroker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, 100671253);
    MessageBroker.NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass0_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, 100671254);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92313, XrefRangeEnd = 92393, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public override unsafe void DoAwake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MessageBroker.NativeMethodInfoPtr_DoAwake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(75)]
  [CachedScanResults(RefRangeStart = 92396, RefRangeEnd = 92471, XrefRangeStart = 92393, XrefRangeEnd = 92396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ISubscriber<T> GetSubscriber<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MessageBroker.MethodInfoStoreGeneric_GetSubscriber_Public_ISubscriber_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (ISubscriber<T>) null : Il2CppObjectPool.Get<ISubscriber<T>>(num3);
  }

  [CallerCount(75)]
  [CachedScanResults(RefRangeStart = 92396, RefRangeEnd = 92471, XrefRangeStart = 92396, XrefRangeEnd = 92471, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe IPublisher<T> GetPublisher<T>()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(MessageBroker.MethodInfoStoreGeneric_GetPublisher_Public_IPublisher_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (IPublisher<T>) null : Il2CppObjectPool.Get<IPublisher<T>>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92471, XrefRangeEnd = 92474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe MessageBroker()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MessageBroker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [CallerCount(20)]
  [CachedScanResults(RefRangeStart = 92479, RefRangeEnd = 92499, XrefRangeStart = 92474, XrefRangeEnd = 92479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void Method_Internal_Static_Void_byref___c__DisplayClass0_0_0<T>(
    ref MessageBroker.__c__DisplayClass0_0 _param0)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) _param0)
    };
    System.IntPtr num;
    IL2CPP.il2cpp_runtime_invoke(MessageBroker.MethodInfoStoreGeneric_Method_Internal_Static_Void_byref___c__DisplayClass0_0_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref num);
    Il2CppException.RaiseExceptionIfNecessary(num);
  }

  [ObfuscatedName("SadCatStudios.Foundation.MessageBroker+<>c")]
  [Serializable]
  public sealed class __c(System.IntPtr pointer) : Il2CppSystem.Object(pointer)
  {
    private static readonly System.IntPtr NativeFieldInfoPtr___9;
    private static readonly System.IntPtr NativeFieldInfoPtr___9__0_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__DoAwake_b__0_0_Internal_Void_MessagePipeOptions_0;

    static __c()
    {
      Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, "<>c");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr);
      MessageBroker.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr, "<>9");
      MessageBroker.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr, "<>9__0_0");
      MessageBroker.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr, 100671256);
      MessageBroker.__c.NativeMethodInfoPtr__DoAwake_b__0_0_Internal_Void_MessagePipeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr, 100671257);
    }

    [CallerCount(3004)]
    [CachedScanResults(RefRangeStart = 16712, RefRangeEnd = 19716, XrefRangeStart = 16712, XrefRangeEnd = 19716, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe __c()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBroker.__c>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MessageBroker.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    [CallerCount(15159)]
    [CachedScanResults(RefRangeStart = 817, RefRangeEnd = 15976, XrefRangeStart = 817, XrefRangeEnd = 15976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void _DoAwake_b__0_0(MessagePipeOptions options)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1]
      {
        IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) options)
      };
      System.IntPtr num;
      IL2CPP.il2cpp_runtime_invoke(MessageBroker.__c.NativeMethodInfoPtr__DoAwake_b__0_0_Internal_Void_MessagePipeOptions_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num);
      Il2CppException.RaiseExceptionIfNecessary(num);
    }

    public static unsafe MessageBroker.__c __9
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(MessageBroker.__c.NativeFieldInfoPtr___9, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (MessageBroker.__c) null : Il2CppObjectPool.Get<MessageBroker.__c>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MessageBroker.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Il2CppSystem.Action<MessagePipeOptions> __9__0_0
    {
      get
      {
        System.IntPtr num1;
        IL2CPP.il2cpp_field_static_get_value(MessageBroker.__c.NativeFieldInfoPtr___9__0_0, (void*) &num1);
        System.IntPtr num2 = num1;
        return num2 == System.IntPtr.Zero ? (Il2CppSystem.Action<MessagePipeOptions>) null : Il2CppObjectPool.Get<Il2CppSystem.Action<MessagePipeOptions>>(num2);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MessageBroker.__c.NativeFieldInfoPtr___9__0_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  [ObfuscatedName("SadCatStudios.Foundation.MessageBroker+<>c__DisplayClass0_0")]
  public sealed class __c__DisplayClass0_0 : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_builder;

    static __c__DisplayClass0_0()
    {
      Il2CppClassPointerStore<MessageBroker.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MessageBroker>.NativeClassPtr, "<>c__DisplayClass0_0");
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MessageBroker.__c__DisplayClass0_0>.NativeClassPtr);
      MessageBroker.__c__DisplayClass0_0.NativeFieldInfoPtr_builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MessageBroker.__c__DisplayClass0_0>.NativeClassPtr, nameof (builder));
    }

    public __c__DisplayClass0_0(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public __c__DisplayClass0_0()
      : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MessageBroker.__c__DisplayClass0_0>.NativeClassPtr))
    {
    }

    public unsafe BuiltinContainerBuilder builder
    {
      get
      {
        System.IntPtr num = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MessageBroker.__c__DisplayClass0_0.NativeFieldInfoPtr_builder));
        return num == System.IntPtr.Zero ? (BuiltinContainerBuilder) null : Il2CppObjectPool.Get<BuiltinContainerBuilder>(num);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MessageBroker.__c__DisplayClass0_0.NativeFieldInfoPtr_builder), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }

  private sealed class MethodInfoStoreGeneric_GetSubscriber_Public_ISubscriber_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MessageBroker.NativeMethodInfoPtr_GetSubscriber_Public_ISubscriber_1_T_0, Il2CppClassPointerStore<MessageBroker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_GetPublisher_Public_IPublisher_1_T_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MessageBroker.NativeMethodInfoPtr_GetPublisher_Public_IPublisher_1_T_0, Il2CppClassPointerStore<MessageBroker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }

  private sealed class MethodInfoStoreGeneric_Method_Internal_Static_Void_byref___c__DisplayClass0_0_0<T>
  {
    internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(MessageBroker.NativeMethodInfoPtr_Method_Internal_Static_Void_byref___c__DisplayClass0_0_0, Il2CppClassPointerStore<MessageBroker>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
    {
      Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
    }))));
  }
}
