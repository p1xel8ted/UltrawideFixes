// Decompiled with JetBrains decompiler
// Type: UnityEngine.TextureMipmapLimitGroups
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Bindings;

#nullable disable
namespace UnityEngine;

public static class TextureMipmapLimitGroups
{
  private static readonly TextureMipmapLimitGroups.GetGroupsDelegate GetGroupsDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.GetGroupsDelegate>("UnityEngine.TextureMipmapLimitGroups::GetGroups");
  private static readonly TextureMipmapLimitGroups.HasGroup_InjectedDelegate HasGroup_InjectedDelegateField = IL2CPP.ResolveICall<TextureMipmapLimitGroups.HasGroup_InjectedDelegate>("UnityEngine.TextureMipmapLimitGroups::HasGroup_Injected");

  public static Il2CppStringArray GetGroups()
  {
    System.IntPtr num = TextureMipmapLimitGroups.GetGroupsDelegateField();
    return num == System.IntPtr.Zero ? (Il2CppStringArray) null : Il2CppObjectPool.Get<Il2CppStringArray>(num);
  }

  public static unsafe bool HasGroup(string groupName)
  {
    if (groupName == null)
      UnityEngine.Bindings.ThrowHelper.ThrowArgumentNullException((Il2CppSystem.Object) groupName, nameof (groupName));
    try
    {
      ManagedSpanWrapper managedSpanWrapper;
      if (!StringMarshaller.TryMarshalEmptyOrNullString(groupName, ref managedSpanWrapper))
      {
        Il2CppSystem.ReadOnlySpan<char> readOnlySpan = groupName.AsSpan();
        fixed (char* begin = &((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).GetPinnableReference())
          managedSpanWrapper = new ManagedSpanWrapper((void*) begin, ((Il2CppSystem.ReadOnlySpan<char>) ref readOnlySpan).Length);
      }
      return TextureMipmapLimitGroups.HasGroup_Injected(ref managedSpanWrapper);
    }
    finally
    {
      // ISSUE: fixed variable is out of scope
      // ISSUE: __unpin statement
      __unpin(begin);
    }
  }

  public static bool HasGroup_Injected(ref ManagedSpanWrapper groupName)
  {
    return TextureMipmapLimitGroups.HasGroup_InjectedDelegateField((System.IntPtr) ref groupName);
  }

  private delegate System.IntPtr GetGroupsDelegate();

  private delegate bool HasGroup_InjectedDelegate(System.IntPtr groupName);
}
