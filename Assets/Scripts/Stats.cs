namespace h1ddengames.twodrpg.statistics
{
    using System;
    using UnityEngine;
       
    [CreateAssetMenu(fileName = "Stats", menuName = "2DRPG/Stats", order = 0)]
    public class Stats : ScriptableObject {
           [SerializeField] private int strength;
           [SerializeField] private int intelligence;
           [SerializeField] private int dexterity;
           [SerializeField] private int luck;
           [SerializeField] private int healthPoints;
           [SerializeField] private int manaPoints;
           [SerializeField] private int attackPoints;
           [SerializeField] private int magicAttackPoints;
           [SerializeField] private int experience;

            public int Strength { get => strength; set => strength = value; }
            public int Intelligence { get => intelligence; set => intelligence = value; }
            public int Dexterity { get => dexterity; set => dexterity = value; }
            public int Luck { get => luck; set => luck = value; }
            public int HealthPoints { get => healthPoints; set => healthPoints = value; }
            public int ManaPoints { get => manaPoints; set => manaPoints = value; }
            public int AttackPoints { get => attackPoints; set => attackPoints = value; }
            public int MagicAttackPoints { get => magicAttackPoints; set => magicAttackPoints = value; }
            public int Experience { get => experience; set => experience = value; }
    }
}