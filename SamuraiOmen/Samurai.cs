using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamuraiOmen
{
    class Samurai
    {
        public int health { get; set; }
        public int maxHealth { get; set; }

        public int mana { get; set; }
        public int maxMana { get; set; }

        public int power { get; set; }
        public int maxPower { get; set; }

        public List<string> items { get; set; }
    }
}
