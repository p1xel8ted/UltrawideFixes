using PugMod;
using PugRP;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Mods.UltraWide
{
    public class UltraWide : IMod
    {
        private const string LeftPillarBoxName = "Left";
        private const string RightPillarBoxName = "Right";
        private const string Version = "0.0.1";
        private static IConfigEntry<bool> UseCustomMaxWidth { get; set; }
        private static IConfigEntry<int> CustomMaxWidth { get; set; }
        
        private static int MaxWidth =>Utils.CalculateMaxWidth();

        public void EarlyInit()
        {
            SceneManager.sceneLoaded += SceneManagerOnSceneLoaded;
            Debug.Log($"UltraWide v{Version} Loaded!");
            UseCustomMaxWidth = API.Config.Register("UltraWide", "General",
                "At auto, you will see the world spawning/de-spawning. It's not so bad at 21:9, but will be worse at wider resolutions. Adjust this value to your liking.",
                "UseCustomMaxWidth", false);

            CustomMaxWidth = API.Config.Register("UltraWide", "General",
                "This is not the width in screen pixels. For example at 3440x1440 (21:9), a value of 648 expands the viewport entirely.",
                "MaxWidth", MaxWidth);
        }

        public void Init()
        {
        }

        public void Shutdown()
        {
            SceneManager.sceneLoaded -= SceneManagerOnSceneLoaded;
            Debug.Log($"UltraWide v{Version} Shutdown!");
        }

        public void ModObjectLoaded(Object obj)
        {
        }

        public bool CanBeUnloaded()
        {
            return true;
        }

        public void Update()
        {
        }


        private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            UpdateCameras();
            UpdatePugCameras();
            RemovePillars();
        }

        private static void UpdatePugCameras()
        {
            var pugCameras = Resources.FindObjectsOfTypeAll<PugCamera>();
            foreach (var cam in pugCameras)
            {
                if (UseCustomMaxWidth.Value)
                {
                    cam.SetPreferredOutputMode(OutputMode.Fixed);
                    cam.SetValue("m_outputWidth", CustomMaxWidth.Value);
                }
                else
                {
                    cam.SetPreferredOutputMode(OutputMode.MatchAspect);
                }

                if (cam.camera != null)
                {
                    cam.camera.aspect = Display.main.systemWidth / (float) Display.main.systemHeight;
                }
            }
        }

        private static void RemovePillars()
        {
            var spr = Resources.FindObjectsOfTypeAll<SpriteRenderer>();
            foreach (var s in spr)
            {
                if (s.name == LeftPillarBoxName)
                {
                    s.gameObject.SetActive(false);
                }

                if (s.name == RightPillarBoxName)
                {
                    s.gameObject.SetActive(false);
                }
            }
        }

        private static void UpdateCameras()
        {
            var cameras = Resources.FindObjectsOfTypeAll<Camera>();
            foreach (var cam in cameras)
            {
                cam.aspect = Display.main.systemWidth / (float) Display.main.systemHeight;
            }
        }
    }
}