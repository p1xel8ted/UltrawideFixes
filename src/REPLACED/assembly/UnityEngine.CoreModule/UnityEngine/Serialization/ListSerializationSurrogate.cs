// Decompiled with JetBrains decompiler
// Type: UnityEngine.Serialization.ListSerializationSurrogate
// Assembly: UnityEngine.CoreModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E159F43B-803F-461A-9433-870981D20FB6
// Assembly location: G:\SteamLibrary\steamapps\common\REPLACED Demo\BepInEx\interop\UnityEngine.CoreModule.dll

using Il2CppInterop.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Serialization;

#nullable disable
namespace UnityEngine.Serialization;

public class ListSerializationSurrogate
{
  public void GetObjectData(Il2CppSystem.Object obj, SerializationInfo info, StreamingContext context)
  {
    IList list = obj.Cast<IList>();
    info.AddValue("_size", ((ICollection) list).Count);
    info.AddValue("_items", (Il2CppSystem.Object) ListSerializationSurrogate.ArrayFromGenericList(list));
    info.AddValue("_version", 0);
  }

  public Il2CppSystem.Object SetObjectData(
    Il2CppSystem.Object obj,
    SerializationInfo info,
    StreamingContext context,
    ISurrogateSelector selector)
  {
    IList ilist = Il2CppSystem.Activator.CreateInstance(obj.GetType()).Cast<IList>();
    int int32 = info.GetInt32("_size");
    if (int32 == 0)
      return (Il2CppSystem.Object) ilist;
    IEnumerator enumerator = info.GetValue("_items", Il2CppSystem.Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<IEnumerable>())).Cast<IEnumerable>().GetEnumerator();
    for (int index = 0; index < int32; ++index)
    {
      if (!enumerator.MoveNext())
        throw new Il2CppSystem.InvalidOperationException();
      ilist.Add(enumerator.Current);
    }
    return (Il2CppSystem.Object) ilist;
  }

  public static Il2CppSystem.Array ArrayFromGenericList(IList list)
  {
    throw new System.NotSupportedException("Method unstripping failed");
  }
}
