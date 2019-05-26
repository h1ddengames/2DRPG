namespace h1ddengames.twodrpg.managers
{
    using UnityEngine;
    using h1ddengames.twodrpg.ui;
    using h1ddengames.twodrpg.statistics;
    
    public class UIManager : MonoBehaviour {
        [SerializeField] private Slider healthSlider; 
        [SerializeField] private Slider manaSlider; 
        [SerializeField] private EntityStats playerStats; 

        public Slider HealthSlider { get => healthSlider; set => healthSlider = value; }
        public Slider ManaSlider { get => manaSlider; set => manaSlider = value; }
        public EntityStats PlayerStats { get => playerStats; set => playerStats = value; }
        
        private void OnEnable() {
            //HealthSlider.Text.text = PlayerStats.
        }

        private void Update() {
            //HealthSlider.Fill.fillAmount = 0; // Some amount given by game logic
            //HealthSlider.Text.text = ValueText;
            //ManaSlider.Fill.fillAmount = FillAmount;
            //ManaSlider.Text.text = ValueText;
        }
    }
}