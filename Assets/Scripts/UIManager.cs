namespace h1ddengames.twodrpg.managers
{
    using UnityEngine;
    using TMPro;
    using h1ddengames.twodrpg.ui;
    using h1ddengames.twodrpg.statistics;
    
    public class UIManager : MonoBehaviour {
        [SerializeField] private h1ddengames.twodrpg.ui.Slider healthSlider; 
        [SerializeField] private h1ddengames.twodrpg.ui.Slider manaSlider; 
        [SerializeField] private EntityStats playerStats; 

        public Slider HealthSlider { get => healthSlider; set => healthSlider = value; }
        public Slider ManaSlider { get => manaSlider; set => manaSlider = value; }
        public EntityStats PlayerStats { get => playerStats; set => playerStats = value; }
        
        private void OnEnable() {
            EntityStats.entityStatsHaveChangedEvent += OnStatsChanged;
            UpdateUI();
        }

        public void OnStatsChanged() {
            UpdateUI();
        }

        public void UpdateUI() {
            if(!(PlayerStats.MaxHealthPoints == 0)) {
                HealthSlider.FillAmount = (float) PlayerStats.CurrentHealthPoints/PlayerStats.MaxHealthPoints;
                HealthSlider.ValueText = PlayerStats.CurrentHealthPoints.ToString() + "/" + PlayerStats.MaxHealthPoints.ToString();
            }

            if(!(PlayerStats.MaxManaPoints == 0)) {
                ManaSlider.FillAmount = (float) PlayerStats.CurrentManaPoints/PlayerStats.MaxManaPoints;
                ManaSlider.ValueText = PlayerStats.CurrentManaPoints.ToString() + "/" + PlayerStats.MaxManaPoints.ToString();
            }
        }
    }
}