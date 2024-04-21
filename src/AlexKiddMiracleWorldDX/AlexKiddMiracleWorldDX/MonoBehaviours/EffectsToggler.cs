using UnityEngine;
using UnityEngine.Rendering;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class EffectsToggler : MonoBehaviour
{
    private Volume Volume { get; set; }
    private Transform GlobalVolume { get; set; }
    private Transform WaterColourVolume { get; set; }
    private void Start()
    {
        Plugin.LOG.LogInfo($"Effects Toggler started on {gameObject.name}");
        GlobalVolume = transform.Find("Global Volume");
        WaterColourVolume = transform.Find("WaterColor");
    }

    private void LateUpdate()
    {
        if (GlobalVolume)
        {
            GlobalVolume.gameObject.SetActive(Plugin.ColorOverlay.Value);
        }
        
        if (WaterColourVolume)
        {
            WaterColourVolume.gameObject.SetActive(Plugin.WaterColour.Value);
        }
    }

}