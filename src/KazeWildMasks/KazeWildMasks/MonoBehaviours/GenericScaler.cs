﻿namespace KazeWildMasks.MonoBehaviours;

[Harmony]
public class GenericScaler : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.localScale = transform.localScale with {x = Plugin.PositiveScaleFactor, y = Plugin.PositiveScaleFactor};
    }

}