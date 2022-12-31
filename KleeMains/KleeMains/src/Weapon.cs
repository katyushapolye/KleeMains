using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleeMains
{

    public class Weapon
    {
        public enum WeaponType { Catalyst,LongSword,Claymore,Bow,Polearm};
        public enum WeaponBonusType { PhysicalDMGBonus,ATKPercent,CritRate,CritDMG,HealthPercentage,EM,EnergyRecharge,DEFPercent}

        private string name;
        private int baseDMG;
        private WeaponType type;

        private WeaponBonusType secondStatType;
        private float secondStatPoints; //can be both flat and percent, careful

        public Weapon(string name,int baseDMG,WeaponType type,WeaponBonusType bType,float secondStatP)
        {
            this.name = name;
            this.baseDMG = baseDMG;
            this.type = type;
            this.secondStatType = bType;
            this.secondStatPoints = secondStatP;
            

        }

        public void printValues()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.baseDMG);
            Console.WriteLine(this.type);
            Console.WriteLine(this.secondStatType);
            Console.WriteLine(this.secondStatPoints);
        }

        public string getName() { return this.name; }
        


    }
}
