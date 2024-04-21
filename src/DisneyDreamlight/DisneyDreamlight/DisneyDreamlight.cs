using DisneyDreamlight;
using MelonLoader;
using UnityEngine;



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