using DrovaForsakenKin_ML;
using MelonLoader;

[assembly: MelonInfo(typeof(DrovaMlPlugin), "Drova Forsaken Kin Ultra-Wide (MelonLoader)", "0.1.2", "p1xel8ted")]
namespace DrovaForsakenKin_ML;

public class DrovaMlPlugin : MelonMod
{
    
    public override void OnInitializeMelon()
    {
        HelloWorld();
    }
    
    public static void HelloWorld()
    {
        Melon<MelonMod>.Logger.Msg("Hello World from a static method!");
    }
}