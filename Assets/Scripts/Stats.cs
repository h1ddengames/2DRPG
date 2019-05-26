namespace h1ddengames.twodrpg.statistics
{
    using System;
    using UnityEngine;
       
    //[CreateAssetMenu(fileName = "Stats", menuName = "2DRPG/Stats", order = 0)]
    [Serializable]
    public class Stats {
        #region Variables
        public delegate void StatDelegate();
        public static event StatDelegate statsHaveChangedEvent;

        [SerializeField, Tooltip("What is causing this stat change")] private string _effector;
        [SerializeField] private int _strength, _intelligence, _dexterity, _luck;
        [SerializeField] private int _healthPoints, _manaPoints;
        [SerializeField] private int _attackPoints, _magicAttackPoints;
        [SerializeField] private int _experience;
        #endregion

        #region Getters and Setters
        public string Effector { get => _effector; set => _effector = value; }
        public int Strength { 
            get => _strength; 
            set {
                if(value != _strength) { 
                    _strength = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent(); 
                } else { return; }
            } 
        }

        public int Intelligence { 
            get => _intelligence; 
            set {
                if(value != _intelligence) {
                    _intelligence = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Dexterity { 
            get => _dexterity; 
            set {
                if(value != _dexterity) {
                    _dexterity = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Luck { 
            get => _luck; 
            set {
                if(value != _luck) {
                    _luck = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int HealthPoints { 
            get => _healthPoints; 
            set {
                if(value != _healthPoints) {
                    _healthPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int ManaPoints { 
            get => _manaPoints; 
            set {
                if(value != _manaPoints) {
                    _manaPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int AttackPoints { 
            get => _attackPoints; 
            set {
                if(value != _attackPoints) {
                    _attackPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int MagicAttackPoints { 
            get => _magicAttackPoints; 
            set {
                if(value != _magicAttackPoints) {
                    _magicAttackPoints = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }

        public int Experience { 
            get => _experience; 
            set {
                if(value != _experience) {
                    _experience = value;
                    if(statsHaveChangedEvent != null) statsHaveChangedEvent();
                } else { return; }  
            } 
        }
        #endregion

        #region Constructors and Methods
        public Stats() {
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

        public Stats(int str, int intel, int dex, int luk, int hp, int mp, int atk, int matk, int exp) {
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
}