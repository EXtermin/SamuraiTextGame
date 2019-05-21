using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Samurai
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public int Stamina { get; set; }
        public int MaxStamina { get; set; }

        public int power { get; set; }
        public int MaxPower { get; set; }

        public int BasicDamage { get; set; }
        public int MaxBasicDamage { get; set; }

        public string HeldItem { get; set; }
        public int ArmourStats { get; set; }

        public int GoldCoins { get; set; }

        public List<string> Items { get; set; }



        public void CreateSamurai(string name)
        {
            Items = new List<string>();

            Name = name;

            Health = 100;
            MaxHealth = 100;

            Stamina = 20;
            MaxStamina = 20;

            power = 1;
            MaxPower = 10;

            BasicDamage = 2;
            MaxBasicDamage = 100;

            HeldItem = "Basic Fists";
            ArmourStats = 10;
            GoldCoins = 0;

        }
    }
}
