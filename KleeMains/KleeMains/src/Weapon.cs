using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleeMains
{

    class Weapon
    {
        enum WeaponType { Catalyst,LongSword,Claymore,Bow,Polearm};
        enum WeaponBonusType { PhysicalDMGBonus,ATKPercent,CritRate,CritDMG,HealthPercentage,EM,EnergyRecharge,DEFPercent}

        private string name;
        private int baseDMG;

        private WeaponBonusType secondStatType;
        private float secondStatPoints; //can be both flat and percent, careful


    }
}
