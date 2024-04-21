using UnityEngine;
using UnityEngine.UIElements;

namespace Assets.Mods.UltraWide
{
    public class SimpleRuntimeUI : MonoBehaviour
    {
        private SliderInt CustomWidthSlider { get; set; }
        private Toggle CustomWidthToggle { get; set; }
        private Button CloseButton { get; set; }


        private void OnEnable()
        {
            var rootElement = GetComponent<UIDocument>().rootVisualElement;

            CustomWidthSlider = rootElement.Q("CustomWidth") as SliderInt;
            CustomWidthToggle = rootElement.Q("CustomMaxWidth") as Toggle;
            CloseButton = rootElement.Q("CloseButton") as Button;

            CloseButton?.RegisterCallback<ClickEvent>(CloseButtonClicked);
            CustomWidthSlider?.RegisterValueChangedCallback(SliderValueChanged);
            CustomWidthToggle?.RegisterValueChangedCallback(ToggleValueChanged);

            if (CustomWidthSlider != null)
                CustomWidthSlider.value = global::Mods.UltraWide.UltraWide.CustomMaxWidth.Value;
            if (CustomWidthToggle != null)
                CustomWidthToggle.value = global::Mods.UltraWide.UltraWide.UseCustomMaxWidth.Value;
        }

        private void OnDisable()
        {
            CloseButton?.UnregisterCallback<ClickEvent>(CloseButtonClicked);
            CustomWidthSlider?.UnregisterValueChangedCallback(SliderValueChanged);
            CustomWidthToggle?.UnregisterValueChangedCallback(ToggleValueChanged);
        }

        private void CloseButtonClicked(ClickEvent _)
        {
            gameObject.SetActive(false);
        }

        private static void SliderValueChanged(ChangeEvent<int> evt)
        {
            Debug.Log($"Slider value changed to: {evt.newValue}");
            global::Mods.UltraWide.UltraWide.CustomMaxWidth.Value = evt.newValue;
            global::Mods.UltraWide.UltraWide.UpdatePugCameras();
        }

        private static void ToggleValueChanged(ChangeEvent<bool> evt)
        {
            Debug.Log($"Toggle value changed to: {evt.newValue}");
            global::Mods.UltraWide.UltraWide.UseCustomMaxWidth.Value = evt.newValue;
            global::Mods.UltraWide.UltraWide.UpdatePugCameras();
        }
    }
}