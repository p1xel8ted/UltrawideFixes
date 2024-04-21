using System.Linq;
using Assets.Mods.UltraWide;
using HarmonyLib;
using PugMod;
using PugRP;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

namespace Mods.UltraWide
{
    public class UltraWide : IMod
    {
        private static LoadedMod ModInfo { get; set; }
        private static AssetBundle AssetBundle => ModInfo.AssetBundles[0];
        private const string PrefabPath = "Assets/Mods/UltraWide/UIDocument.prefab";
        private const string LeftPillarBoxName = "Left";
        private const string RightPillarBoxName = "Right";
        private const string Version = "0.0.1";
        internal static IConfigEntry<bool> UseCustomMaxWidth { get; set; }
        internal static IConfigEntry<int> CustomMaxWidth { get; set; }

        private static int MaxWidth => Utils.CalculateMaxWidth();
        private static GameObject OptionsGameObject { get; set; }

        public void EarlyInit()
        {
            ModInfo = API.ModLoader.LoadedMods.FirstOrDefault(modInfo => modInfo.Handlers.Contains(this));

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
            var parent = Manager.ui.itemSlotsBar.transform;
           // var parent = GameObject.Find("Global Objects (Main Manager)(Clone)");
            var prefab = AssetBundle.LoadAsset<GameObject>(PrefabPath);
            // OptionsGameObject = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
            OptionsGameObject = Object.Instantiate(prefab, parent);
            OptionsGameObject.transform.SetParent(parent);
            OptionsGameObject.transform.position = parent.position;
            OptionsGameObject.SetActive(false);

            Time.fixedDeltaTime = 1f / 120f;
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
            if (Input.GetKeyUp(KeyCode.F1))
            {
                OptionsGameObject.SetActive(!OptionsGameObject.activeSelf);
                OptionsGameObject.transform.SetParent(Manager.ui.itemSlotsBar.transform);
                OptionsGameObject.transform.position = Manager.ui.itemSlotsBar.transform.position;
                //OptionsGameObject.transform.position = new Vector3(Display.main.systemWidth/2f, Display.main.systemHeight/2f, 1);
                Debug.LogWarning(
                    $"Position: {OptionsGameObject.transform.position}, LocalPosition: {OptionsGameObject.transform.localPosition}");
            }

            if (Input.GetKey(KeyCode.KeypadPlus))
            {
                OptionsGameObject.transform.position += new Vector3(1, 0, 0);
            }
            if (Input.GetKey(KeyCode.KeypadMinus))
            {
                OptionsGameObject.transform.position -= new Vector3(1, 0, 0);
            }
        }


        private static void SceneManagerOnSceneLoaded(Scene arg0, LoadSceneMode arg1)
        {
            UpdateCameras();
            UpdatePugCameras();
            RemovePillars();
        }

        internal static void UpdatePugCameras()
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