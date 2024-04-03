using UnityEngine;

namespace AlexKiddMiracleWorldDX.MonoBehaviours;

public class HudScaler : MonoBehaviour
{
    private void Start()
    {
        Plugin.LOG.LogInfo($"HUD Scaler started on {gameObject.name}");
    }

    private void Update()
    {
        if (!transform) return;
        if (!Plugin.KeepUICentered.Value)
        {
            transform.localScale = transform.localScale with {x = Plugin.NegativeScaleFactor};
        }
        else
        {
            transform.localScale = transform.localScale with {x = 1f};
        }
    }

}