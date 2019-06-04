namespace h1ddengames.twodrpg.statistics
{
    using System;
    using UnityEngine;
       
    [Serializable]
    public class Stats {
        #region Variables
        // Due to the constraints of having presentable UI, this number is the hard limit until UI can be updated.
        // In other words, if there are too many numbers, the text will overflow on the UI and that looks terrible.
        public const int MAX_NUMBER_ALLOWABLE = 9999999;
        public delegate void StatDelegate();
        public static event StatDelegate statsHaveChangedEvent;

        [SerializeField, Tooltip("What is the source of these stats")] private StatEffectors _effector;
        [SerializeField] private int _strength, _intelligence, _dexterity, _luck;
        [SerializeField] private int _healthPoints, _manaPoints;
        [SerializeField] private int _attackPoints, _magicAttackPoints;
        [SerializeField] private int _experience;
        #endregion

        #region Getters and Setters
        public StatEffectors Effector { get => _effector; set => _effector = value; }
        public int Strength { 
            get => _strength; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _strength) { 
                    _strength = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent(); 
                } else { return; }
            } 
        }

        public int Intelligence { 
            get => _intelligence; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _intelligence) {
                    _intelligence = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Dexterity { 
            get => _dexterity; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _dexterity) {
                    _dexterity = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Luck { 
            get => _luck; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _luck) {
                    _luck = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int HealthPoints { 
            get => _healthPoints; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _healthPoints) {
                    _healthPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int ManaPoints { 
            get => _manaPoints; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _manaPoints) {
                    _manaPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int AttackPoints { 
            get => _attackPoints; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _attackPoints) {
                    _attackPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int MagicAttackPoints { 
            get => _magicAttackPoints; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _magicAttackPoints) {
                    _magicAttackPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Experience { 
            get => _experience; 
            set {
                if(value < MAX_NUMBER_ALLOWABLE && value != _experience) {
                    _experience = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }
        #endregion

        #region Constructors
        public Stats() {
            Effector = StatEffectors.BaseStats;
            Strength = 0;
            Intelligence = 0;
            Dexterity = 0;
            Luck = 0;
            HealthPoints = 0;
            ManaPoints = 0;
            AttackPoints = 0;
            MagicAttackPoints = 0;
            Experience = 0;
        }

        public Stats(StatEffectors eff, int str, int intel, int dex, int luk, int hp, int mp, int atk, int matk, int exp) {
            Effector = eff;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Luck = luk;
            HealthPoints = hp;
            ManaPoints = mp;
            AttackPoints = atk;
            MagicAttackPoints = matk;
            Experience = exp;
        }
        #endregion
    }

    public enum StatEffectors {
            BaseStats,
            ItemStats,
            EquipmentStats,
            SkillStats,
            QuestStats
        }
}