﻿namespace BAKERU;

internal class LayoutController : MonoBehaviour
{
    public Patches.Size Size { get; set; }
    private LayoutElement LayoutElement { get; set; }
    private ContentSizeFitter ContentSizeFitter { get; set; }

    private void Awake()
    {
        AddUpdateFitters();
    }

    private void Start()
    {
        AddUpdateFitters();
    }

    private void OnEnable()
    {
        AddUpdateFitters();
    }

    private void AddUpdateFitters()
    {
        LayoutElement = gameObject.TryAddComponent<LayoutElement>();
        ContentSizeFitter = gameObject.TryAddComponent<ContentSizeFitter>();

        UpdateAspect();
    }

    internal void UpdateAspect()
    {
        if (LayoutElement)
        {
            var height = Screen.currentResolution.height;
            var width = Size switch
            {
                Patches.Size.ConfigBased => Utils.GetHudRes(height),
                Patches.Size.ForceFullScreen => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                Patches.Size.ForceSixteenNine => Mathf.RoundToInt(height * Plugin.CurrentAspect),
                _ => Utils.GetHudRes(height)
            };

            LayoutElement.preferredWidth = width;
        }

        if (ContentSizeFitter)
        {
            ContentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
        }
    }
}