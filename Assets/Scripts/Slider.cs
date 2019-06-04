namespace h1ddengames.twodrpg.ui
{
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    [ExecuteInEditMode]
    public class Slider : MonoBehaviour
    {
        public delegate void SliderDelegate();
        public static event SliderDelegate sliderHasChangedEvent;
        [SerializeField, Range(0f, 1f)] private float _fillAmount;
        [SerializeField] private string _valueText;

        [SerializeField] private Image fill; 
        [SerializeField] private TextMeshProUGUI text; 
        
        public float FillAmount { 
            get => _fillAmount; 
            set {
                if(value != _fillAmount && value >= 0 && value <= 1) { 
                    _fillAmount = value;
                    if(sliderHasChangedEvent != null) sliderHasChangedEvent(); 
                } else { return; }
            }  
        }

        public string ValueText { 
            get => _valueText; 
            set {
                if(value != _valueText) { 
                    _valueText = value;
                    if(sliderHasChangedEvent != null) sliderHasChangedEvent(); 
                } else { return; }
            }
        }

        public Image Fill { get => fill; set => fill = value; }
        public TextMeshProUGUI Text { get => text; set => text = value; }

        private void OnEnable() {
            sliderHasChangedEvent += OnSliderChanged;
            UpdateSlider();
        }

        private void OnValidate() {
            UpdateSlider();
        }

        public void OnSliderChanged() {
            UpdateSlider();
        }

        public void UpdateSlider() {
            if(Fill != null) {
                Fill.fillAmount = FillAmount;
            }
            if(Text != null) {
                Text.text = ValueText;
            }
        }
    }
}