namespace h1ddengames.twodrpg.managers
{
    using UnityEngine;
    using h1ddengames.twodrpg.ui;
    
    public class UIManager : MonoBehaviour {
        [SerializeField] private Slider healthSlider; 
        [SerializeField] private Slider manaSlider; 

        public Slider HealthSlider { get => healthSlider; set => healthSlider = value; }
        public Slider ManaSlider { get => manaSlider; set => manaSlider = value; }
        
        private void Update() {
            //HealthSlider.Fill.fillAmount = 0; // Some amount given by game logic
            //HealthSlider.Text.text = ValueText;
            //ManaSlider.Fill.fillAmount = FillAmount;
            //ManaSlider.Text.text = ValueText;
        }
    }
}