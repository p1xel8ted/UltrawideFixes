using DisneyDreamlight;
using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(DisneyDreamlightMod), "Disney Dreamlight Ultra-wide Fix", "0.1.0", "p1xel8ted")]

namespace DisneyDreamlight
{
    public class DisneyDreamlightMod : MelonMod
    {
        public static DisneyDreamlightMod Instance { get; set; }

        public override void OnEarlyInitializeMelon()
        {
            Instance = this;
          
        }


    }
}