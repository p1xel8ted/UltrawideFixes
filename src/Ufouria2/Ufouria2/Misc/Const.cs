namespace Ufouria2.Misc;

internal static class Const
{
    internal const string PluginGuid = "p1xel8ted.ufouria2.ultrawide";
    internal const string PluginName = "Ufouria: The Saga 2 Ultra-Wide";
    internal const string PluginVersion = "0.1.1";


    internal static string GetPath(this GameObject tr)
    {
        var path = tr.name;
        while (tr.transform.parent != null)
        {
            tr = tr.transform.parent.gameObject;
            path = tr.name + "/" + path;
        }
    
        return path;
    }
}