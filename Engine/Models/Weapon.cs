using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximimDamage { get; set; }
        public Weapon(int itemTypeID, string name, int price, int minDamage, int maxDamage) 
            : base(itemTypeID, name, price) {
            MinimumDamage = minDamage;
            MaximimDamage = maxDamage;
        }

        public new Weapon Clone() {
            return new Weapon(ItemTypeID, Name, Price, MinimumDamage, MaximimDamage);
        }
    }
}
