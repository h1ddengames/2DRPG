namespace h1ddengames.twodrpg.managers
{
    using UnityEngine;
    using TMPro;
    using h1ddengames.twodrpg.ui;
    using h1ddengames.twodrpg.statistics;
    
    public class UIManager : MonoBehaviour {
        [SerializeField] private h1ddengames.twodrpg.ui.Slider _healthSlider; 
        [SerializeField] private h1ddengames.twodrpg.ui.Slider _manaSlider; 
        [SerializeField] private h1ddengames.twodrpg.ui.Slider _expSlider;
        [SerializeField] private TextMeshProUGUI _playerName;
        [SerializeField] private EntityStats playerStats; 

        public Slider HealthSlider { get => _healthSlider; set => _healthSlider = value; }
        public Slider ManaSlider { get => _manaSlider; set => _manaSlider = value; }
        public Slider ExperienceSlider { get => _expSlider; set => _expSlider = value; }
        public EntityStats PlayerStats { get => playerStats; set => playerStats = value; }
        
        private void OnEnable() {
            EntityStats.entityStatsHaveChangedEvent += OnStatsChanged;
            UpdateUI();
        }

        public void OnStatsChanged() {
            UpdateUI();
        }

        public void UpdateUI() {
            if(PlayerStats.CurrentHealthPoints > 0) {
                HealthSlider.FillAmount = (float) PlayerStats.CurrentHealthPoints/PlayerStats.MaxHealthPoints;   
            } else if(PlayerStats.CurrentHealthPoints <= 0) { HealthSlider.FillAmount = 0; }

            HealthSlider.ValueText = PlayerStats.CurrentHealthPoints.ToString() + "/" + PlayerStats.MaxHealthPoints.ToString();

            if(PlayerStats.CurrentManaPoints > 0) {
                ManaSlider.FillAmount = (float) PlayerStats.CurrentManaPoints/PlayerStats.MaxManaPoints;
            } else if (PlayerStats.CurrentManaPoints <= 0) { ManaSlider.FillAmount = 0; }
            
            ManaSlider.ValueText = PlayerStats.CurrentManaPoints.ToString() + "/" + PlayerStats.MaxManaPoints.ToString();

            if(PlayerStats.CurrentExperience > 0) {
                // ExpSlider.FillAmount = (float) PlayerStats.CurrentExperience/PlayerStats.ExperienceCurve.Evaluate(PlayerStats.Level);
            } else if (PlayerStats.CurrentExperience <= 0) { ExperienceSlider.FillAmount = 0; }
        }
    }
}