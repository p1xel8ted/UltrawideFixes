using UnityEngine;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class VolumeToggler : MonoBehaviour
{
    private void Start()
    {
        Plugin.LOG.LogInfo($"Volume Toggler started on {gameObject.name}");
    }

    private void Update()
    {
        if (gameObject)
        {
            gameObject.SetActive(!Plugin.DisableColorOverlay.Value);
        }
    }

}