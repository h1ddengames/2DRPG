namespace h1ddengames.twodrpg.ui
{
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    [ExecuteInEditMode]
    public class Slider : MonoBehaviour
    {
        [SerializeField, Range(0f, 1f)] private float fillAmount;
        [SerializeField] private string valueText;

        [SerializeField] private Image fill; 
        [SerializeField] private TextMeshProUGUI text; 
        
        public float FillAmount { get => fillAmount; set => fillAmount = value; }
        public string ValueText { get => valueText; set => valueText = value; }
        public Image Fill { get => fill; set => fill = value; }
        public TextMeshProUGUI Text { get => text; set => text = value; }

        private void OnValidate() {
            Fill.fillAmount = FillAmount;
            Text.text = ValueText;
        }
    }
}