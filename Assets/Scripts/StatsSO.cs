namespace h1ddengames.twodrpg.statistics
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    [CreateAssetMenu(fileName = "Stats", menuName = "2DRPG/Stats", order = 0)]
    public class StatsSO : ScriptableObject
    {
        [SerializeField] private Stats _stats;
        [SerializeField, Header("Randomized Stats")] private int _strengthMin = 0; 
        [SerializeField] private int _strengthMax = 0, _intelligenceMin = 0, _intelligenceMax = 0, _dexterityMin = 0, 
        _dexterityMax = 0, _luckMin = 0, _luckMax = 0;
        [SerializeField] private int _healthPointsMin = 0, _healthPointsMax = 0, _manaPointsMin = 0, _manaPointsMax = 0;
        [SerializeField] private int _attackPointsMin = 0, _attackPointsMax = 0, _magicAttackPointsMin = 0, _magicAttackPointsMax = 0;
        [SerializeField] private int _experienceMin = 0, _experienceMax = 0;

        public Stats GetSetStats { get => _stats; set => _stats = value; }

        #region Constructor
        public StatsSO() { GetSetStats = new Stats(); }
        public StatsSO(Stats stats) { GetSetStats = stats; }
        #endregion


        public void UpdateDatabase() {
            // Open the connection to the database.

            // Check that the current stats have not already been added.
            // Create the query.

            // Send the query.

            // If the resultset states no entry matches the query then
                // Create the statement.

                // Send the statement.

            // Close the connection to the database.

        }

        public void CreateJSONBackup() {
            // Use JSONify to create a JSON object.

            // Save the JSON object to a file where users expect their game data to be saved.
        }

        [ContextMenu("Randomize Stats")]
        public void RandomizeStats() {
            GetSetStats.Strength = Random.Range(_strengthMin, _strengthMax);
            GetSetStats.Intelligence = Random.Range(_intelligenceMin, _intelligenceMax);
            GetSetStats.Dexterity = Random.Range(_dexterityMin, _dexterityMax);
            GetSetStats.Luck = Random.Range(_luckMin, _luckMax);
            GetSetStats.HealthPoints = Random.Range(_healthPointsMin, _healthPointsMax);
            GetSetStats.ManaPoints = Random.Range(_manaPointsMin, _manaPointsMax);
            GetSetStats.AttackPoints = Random.Range(_attackPointsMin, _attackPointsMax);
            GetSetStats.MagicAttackPoints = Random.Range(_magicAttackPointsMin, _magicAttackPointsMax);
            GetSetStats.Experience = Random.Range(_experienceMin, _experienceMax);
        }
    }
}