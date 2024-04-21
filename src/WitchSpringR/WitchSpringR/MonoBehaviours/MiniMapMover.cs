using UnityEngine;

namespace WitchSpringR.MonoBehaviours;

public class MiniMapMover : MonoBehaviour
{
    private RectTransform _rectTransform;
    private Transform _parent;
    private Transform _key;

    private void Start()
    {
        Plugin.Logger.LogInfo($"Mini Map Mover started on {gameObject.name}");
        _rectTransform = GetComponent<RectTransform>();
        _parent = transform.parent;
        _key = _parent.Find("Key");
    }

    private void LateUpdate()
    {
        var newX = _rectTransform.sizeDelta.x;
        float newY = 30;

        if (!HandlePositionAdjustment(ref newX, ref newY)) return;
            
        var xPosition = Plugin.SpanHud.Value ? newX : Plugin.MainWidth - Plugin.BlackBarSize;
        UpdatePosition(xPosition, newY, 75);
    }

    private static bool HandlePositionAdjustment(ref float newX, ref float newY)
    {
        switch (newX)
        {
            case 380:
                newX = Plugin.MainWidth;
                return true;
            case 570:
                newX = Plugin.MainWidth - 100;
                newY += 95;
                return true;
            case 760:
                newX = Plugin.MainWidth - 200;
                newY += 190;
                return true;
            case 950:
                newX = Plugin.MainWidth - 300;
                newY += 285;
                return true;
            default:
                return false;
        }
    }

    private void UpdatePosition(float x, float y, float keyY)
    {
        if (!Mathf.Approximately(_parent.position.x, x) || !Mathf.Approximately(_parent.position.y, y))
        {
            _parent.position = new Vector3(x, y, _parent.position.z);
            
        }

        if (!Mathf.Approximately(_key.position.y, keyY))
        {
            _key.position = new Vector3(_key.position.x, keyY, _key.position.z);
        }
    }
}