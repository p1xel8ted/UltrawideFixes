namespace ButtKnight;

public class CutInUIEnforcer : MonoBehaviour
{
    private CutInUI _cutInUi;
    private Vector3 _hSceneOffscreenPos;
    private Vector3 _kissOffscreenPos;
    private float _lastScaleFactor;

    private void Start()
    {
        _cutInUi = GetComponent<CutInUI>();
        UpdateOffscreenPositions();
    }

    private void UpdateOffscreenPositions()
    {
        var offscreenX = 15f * Resolutions.PositiveScaleFactor;
        _hSceneOffscreenPos = new Vector3(offscreenX, 3.57f, 0.0f);
        _kissOffscreenPos = new Vector3(offscreenX, 3.4886f, 0.0f);
        _lastScaleFactor = Resolutions.PositiveScaleFactor;
    }

    private void LateUpdate()
    {
        if (!_cutInUi) return;

        // Check if resolution changed
        if (!Mathf.Approximately(_lastScaleFactor, Resolutions.PositiveScaleFactor))
        {
            UpdateOffscreenPositions();
        }

        // Cache tween checks for better performance
        var hSceneTweening = LeanTween.isTweening(_cutInUi.HSceneCutInImage);
        var kissTweening = LeanTween.isTweening(_cutInUi.KissCutInImage);

        // Check H-Scene independently
        var isHSceneInactive = !_cutInUi.isHShowing &&
                               !_cutInUi.isHWait &&
                               !hSceneTweening;

        if (isHSceneInactive)
        {
            _cutInUi.HSceneCutInImage.transform.position = _hSceneOffscreenPos;
        }

        // Check Kiss independently
        var isKissInactive = !_cutInUi.isKissShowing &&
                             !_cutInUi.isKissWait &&
                             !kissTweening;

        if (isKissInactive)
        {
            _cutInUi.KissCutInImage.transform.position = _kissOffscreenPos;
        }
    }
}