using Il2CppInterop.Runtime;
using UnityEngine;

namespace SeaOfStars;

public static class Utils
{
    public static List<T> FindIl2CppType<T>() where T : UnityEngine.Object
    {
        List<T> list = [];
        list.AddRange(Resources.FindObjectsOfTypeAll( Il2CppType.Of<T>()).Select(obj => obj.TryCast<T>()).Where(o => o != null));
        return list;
    }

}