// Decompiled with JetBrains decompiler
// Type: UnityEngine.U2D.SpriteAtlas
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine.U2D;

public class SpriteAtlas(System.IntPtr pointer) : UnityEngine.Object(pointer)
{
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0;
  private static readonly SpriteAtlas.get_isVariant_InjectedDelegate get_isVariant_InjectedDelegateField;
  private static readonly SpriteAtlas.get_tag_InjectedDelegate get_tag_InjectedDelegateField;
  private static readonly SpriteAtlas.get_spriteCount_InjectedDelegate get_spriteCount_InjectedDelegateField;
  private static readonly SpriteAtlas.GetSpritesScripting_InjectedDelegate GetSpritesScripting_InjectedDelegateField;
  private static readonly SpriteAtlas.GetSpritesWithNameScripting_InjectedDelegate GetSpritesWithNameScripting_InjectedDelegateField;

  static SpriteAtlas()
  {
    Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.U2D", nameof (SpriteAtlas));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr);
    SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100670792);
    SpriteAtlas.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100670793);
    SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100670794);
    SpriteAtlas.NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpriteAtlas>.NativeClassPtr, 100670795);
    SpriteAtlas.get_isVariant_InjectedDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_isVariant_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::get_isVariant_Injected");
    SpriteAtlas.get_tag_InjectedDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_tag_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::get_tag_Injected");
    SpriteAtlas.get_spriteCount_InjectedDelegateField = IL2CPP.ResolveICall<SpriteAtlas.get_spriteCount_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::get_spriteCount_Injected");
    SpriteAtlas.GetSpritesScripting_InjectedDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesScripting_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesScripting_Injected");
    SpriteAtlas.GetSpritesWithNameScripting_InjectedDelegateField = IL2CPP.ResolveICall<SpriteAtlas.GetSpritesWithNameScripting_InjectedDelegate>("UnityEngine.U2D.SpriteAtlas::GetSpritesWithNameScripting_Injected");
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 489981, RefRangeEnd = 489982, XrefRangeStart = 489970, XrefRangeEnd = 489981, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe bool CanBindTo(Sprite sprite)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprite)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Public_Boolean_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 490001, RefRangeEnd = 490002, XrefRangeStart = 489982, XrefRangeEnd = 490001, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe Sprite GetSprite(string name)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1]
    {
      IL2CPP.ManagedStringToIl2Cpp(name)
    };
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSprite_Public_Sprite_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    System.IntPtr num3 = num2;
    return num3 == System.IntPtr.Zero ? (Sprite) null : Il2CppObjectPool.Get<Sprite>(num3);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490002, XrefRangeEnd = 490004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe bool CanBindTo_Injected(System.IntPtr _unity_self, System.IntPtr sprite)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &sprite;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_CanBindTo_Injected_Private_Static_Boolean_IntPtr_IntPtr_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(bool*) IL2CPP.il2cpp_object_unbox(num2);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 490004, XrefRangeEnd = 490006, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe System.IntPtr GetSprite_Injected(
    System.IntPtr _unity_self,
    ref ManagedSpanWrapper name)
  {
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = (System.IntPtr) &_unity_self;
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref name;
    System.IntPtr num1;
    System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(SpriteAtlas.NativeMethodInfoPtr_GetSprite_Injected_Private_Static_IntPtr_IntPtr_byref_ManagedSpanWrapper_0, System.IntPtr.Zero, (void**) numPtr, ref num1);
    Il2CppException.RaiseExceptionIfNecessary(num1);
    return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num2);
  }

  public bool isVariant
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteAtlas>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SpriteAtlas.get_isVariant_Injected(_unity_self);
    }
  }

  public string tag
  {
    get
    {
      ManagedSpanWrapper ret;
      string stringAndDispose;
      try
      {
        System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteAtlas>(this);
        if (_unity_self == System.IntPtr.Zero)
          UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
        SpriteAtlas.get_tag_Injected(_unity_self, out ret);
      }
      finally
      {
        stringAndDispose = OutStringMarshaller.GetStringAndDispose(ret);
      }
      return stringAndDispose;
    }
  }

  public int spriteCount
  {
    get
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteAtlas>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      return SpriteAtlas.get_spriteCount_Injected(_unity_self);
    }
  }

  public int GetSprites(Il2CppReferenceArray<Sprite> sprites) => this.GetSpritesScripting(sprites);

  public int GetSprites(Il2CppReferenceArray<Sprite> sprites, string name)
  {
    return this.GetSpritesWithNameScripting(sprites, name);
  }

  public int GetSpritesScripting(Il2CppReferenceArray<Sprite> sprites)
  {
    System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteAtlas>(this);
    if (_unity_self == System.IntPtr.Zero)
      UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
    return SpriteAtlas.GetSpritesScripting_Injected(_unity_self, sprites);
  }

  public unsafe int GetSpritesWithNameScripting(Il2CppReferenceArray<Sprite> sprites, string name)
  {
    try
    {
      System.IntPtr _unity_self = UnityEngine.Object.MarshalledUnityObject.MarshalNotNull<SpriteAtlas>(this);
      if (_unity_self == System.IntPtr.Zero)
        UnityEngine.Bindings.ThrowHelper.ThrowNullReferenceException((Il2CppSystem.Object) this);
      Il2CppReferenceArray<Sprite> sprites1 = sprites;
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(name, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = name.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      ref ManagedSpanWrapper local = ref managedSpanWrapper;
      return SpriteAtlas.GetSpritesWithNameScripting_Injected(_unity_self, sprites1, ref local);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool get_isVariant_Injected(System.IntPtr _unity_self)
  {
    return SpriteAtlas.get_isVariant_InjectedDelegateField(_unity_self);
  }

  public static void get_tag_Injected(System.IntPtr _unity_self, out ManagedSpanWrapper ret)
  {
    SpriteAtlas.get_tag_InjectedDelegateField(_unity_self, (System.IntPtr) ref ret);
  }

  public static int get_spriteCount_Injected(System.IntPtr _unity_self)
  {
    return SpriteAtlas.get_spriteCount_InjectedDelegateField(_unity_self);
  }

  public static int GetSpritesScripting_Injected(
    System.IntPtr _unity_self,
    Il2CppReferenceArray<Sprite> sprites)
  {
    return SpriteAtlas.GetSpritesScripting_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites));
  }

  public static int GetSpritesWithNameScripting_Injected(
    System.IntPtr _unity_self,
    Il2CppReferenceArray<Sprite> sprites,
    ref ManagedSpanWrapper name)
  {
    return SpriteAtlas.GetSpritesWithNameScripting_InjectedDelegateField(_unity_self, IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sprites), (System.IntPtr) ref name);
  }

  private delegate bool get_isVariant_InjectedDelegate(System.IntPtr _unity_self);

  private delegate void get_tag_InjectedDelegate(System.IntPtr _unity_self, [Out] System.IntPtr ret);

  private delegate int get_spriteCount_InjectedDelegate(System.IntPtr _unity_self);

  private delegate int GetSpritesScripting_InjectedDelegate(System.IntPtr _unity_self, System.IntPtr sprites);

  private delegate int GetSpritesWithNameScripting_InjectedDelegate(
    System.IntPtr _unity_self,
    System.IntPtr sprites,
    System.IntPtr name);
}
