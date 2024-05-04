using UnityEngine;

namespace KazeWildMasks;

[Harmony]
public class BonusCompleteScaler : MonoBehaviour
{
    private Transform bg;
    private float x, y;

    private void Start()
    {
        bg = transform.FindChild("CutsceneBonus/Losangos");
        if (bg)
        {
            x = bg.localScale.x;
            y = bg.localScale.y;
        }
    }

    private void LateUpdate()
    {
        if (bg)
        {
            bg.transform.localScale = bg.transform.localScale with {x = x * Plugin.PositiveScaleFactor * 1.25f, y = y * Plugin.PositiveScaleFactor * 1.25f};
        }
    }

}