namespace h1ddengames.twodrpg.statistics
{
    using UnityEngine;
    using UnityEditor;
    using System.Collections;
    using System.Collections.Generic;
    using Malee;
    using RotaryHeart.Lib.SerializableDictionary;

    public class EntityStats : MonoBehaviour {
        #region Variables
        [Reorderable, SerializeField] private StatsList _listOfStats;
        [SerializeField] private int _strength, _intelligence, _dexterity, _luck;
        [SerializeField] private int _currentHealthPoints, _maxHealthPoints, _currentManaPoints, _maxManaPoints;
        [SerializeField] private int _attackPoints, _magicAttackPoints;    
        [SerializeField] private int _currentExperience;
        [SerializeField] private AnimationCurve _experienceCurve; 
        #endregion

        #region Getters and Setters
        public StatsList ListOfStats { get => _listOfStats; set => _listOfStats = value; }
        public int CurrentHealthPoints { get => _currentHealthPoints; set => _currentHealthPoints = value; }
        public int MaxHealthPoints { get => _maxHealthPoints; set => _maxHealthPoints = value; }
        public int CurrentManaPoints { get => _currentManaPoints; set => _currentManaPoints = value; }
        public int MaxManaPoints { get => _maxManaPoints; set => _maxManaPoints = value; }
        public int CurrentExperience { get => _currentExperience; set => _currentExperience = value; }
        public AnimationCurve ExperienceCurve { get => _experienceCurve; set => _experienceCurve = value; }
        public int AttackPoints { get => _attackPoints; set => _attackPoints = value; }
        public int MagicAttackPoints { get => _magicAttackPoints; set => _magicAttackPoints = value; }
        public int Strength { get => _strength; set => _strength = value; }
        public int Intelligence { get => _intelligence; set => _intelligence = value; }
        public int Dexterity { get => _dexterity; set => _dexterity = value; }
        public int Luck { get => _luck; set => _luck = value; }
        #endregion
        
        private void OnEnable() {
            Stats.statsHaveChangedEvent += OnStatsChanged;
            ResetStatsToZero();
            CalculateStats();
        }

        public void OnStatsChanged() {
            // When calculating stats, we must first set them to zero so we can't the same stat source twice.
            ResetStatsToZero();
            CalculateStats();
        }

        // Called when the object might be destroyed in response to Object.Destroy 
        // or at the closure of a scene (ending playmode as well!)
        private void OnDestroy() {
            // This is done to prevent memory leaks since: 
            // "As long as the publishing object holds that reference, your subscriber object will not be garbage collected." 
            Stats.statsHaveChangedEvent -= OnStatsChanged;
        }
        
        [ContextMenu("Calculate Starting Stats")]
        public void CalculateStats() {
            // Save the current hp and mp prior to stat change.
            // Unless the player levels up, no stat changes should change the current hp/mp.
            var _unchangedHealth = CurrentHealthPoints;
            var _unchangedMana = CurrentManaPoints; 

            // Iterate through all the stats while adding and subtracting where detailed.
            foreach (var item in ListOfStats)
            {
                CurrentHealthPoints += item.HealthPoints;
                CurrentManaPoints += item.ManaPoints;
                CurrentExperience += item.Experience;
                AttackPoints += item.AttackPoints;
                MagicAttackPoints += item.MagicAttackPoints;
                Strength += item.Strength;
                Intelligence += item.Intelligence;
                Dexterity += item.Dexterity;
                Luck += item.Luck;
            }

            // If the total is greater than the prvious max then update the max.
            if(CurrentHealthPoints > MaxHealthPoints) {
                MaxHealthPoints = CurrentHealthPoints;
            }
            // Same thing with mp.
            if(CurrentManaPoints > MaxManaPoints) {
                MaxManaPoints = CurrentManaPoints;
            }

            // Apply the previous values to the entity's stats.
            CurrentHealthPoints = _unchangedHealth;
            CurrentManaPoints = _unchangedMana;
        }

        [ContextMenu("Reset to Zero Stats")]
        public void ResetStatsToZero() {
            CurrentHealthPoints = 0;
            MaxHealthPoints = 0;
            CurrentManaPoints = 0;
            MaxManaPoints = 0;
            CurrentExperience = 0;
            AttackPoints = 0;
            MagicAttackPoints = 0;
            Strength = 0;
            Intelligence = 0;
            Dexterity = 0;
            Luck = 0;
        }

        #region Helper Classes
        [System.Serializable]
        public class StringStatsDictionary : SerializableDictionaryBase<string, Stats> { }

        [System.Serializable]
        public class StatsList : ReorderableArray<Stats> { }
        #endregion

        #region Unused - Remove later
        //[SerializeField] private StringStatsDictionary statsDictionary;
        //public StringStatsDictionary StatsDictionary { get => statsDictionary; set => statsDictionary = value; }

        // [ContextMenu("Generate Dictionary")]
        // public void GenerateDictionary() {
        //     StatsDictionary.Add("entity", null);
        //     StatsDictionary.Add("items", null);
        //     StatsDictionary.Add("equips", null);
        //     StatsDictionary.Add("skills", null);
        //     StatsDictionary.Add("buffs", null);
        //     StatsDictionary.Add("debuffs", null);
        // }

        // [ContextMenu("Calculate Starting Stats")]
        // public void CalculateStats() {
        //     foreach (var item in StatsDictionary)
        //     {
        //         if(item.Value != null) {
        //             CurrentHealthPoints += item.Value.HealthPoints;
        //             CurrentManaPoints += item.Value.ManaPoints;
        //             CurrentExperience += item.Value.Experience;
        //             AttackPoints += item.Value.AttackPoints;
        //             MagicAttackPoints += item.Value.MagicAttackPoints;
        //             Strength += item.Value.Strength;
        //             Intelligence += item.Value.Intelligence;
        //             Dexterity += item.Value.Dexterity;
        //             Luck += item.Value.Luck;
        //         }
        //     }

        //     MaxHealthPoints = CurrentHealthPoints;
        //     MaxManaPoints = CurrentManaPoints;
        // }
        #endregion
    }
}