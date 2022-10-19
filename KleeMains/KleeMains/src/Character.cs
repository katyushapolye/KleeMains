using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KleeMains
{
    class Character
    {
        //static shit
        enum Elements{ Cryo,Pyro,Hydro,Eletro,Anemo,Geo,Dendro }
        enum Stats { HealthFlat,HealthPercent,ATKFlat,ATKPercent,DEFFlat,DEFPercent,CritRate,CritDMG,EM,EnergyRecharge}

        enum AscensionBonus {ElementalDMG,ATK,DEF,PhysicalDMG,EnergyRecharge,EM,Healing,CritRate,CritDMG}

        static double[] ascensionSumValues = {0.208791, 0.35714,0.55494,0.70329,0.85164,1.0};
        static double[] fourstarMultiplier =
        {

        };

        static double[] fivestarMultiplier =
        {

        };
        enum CollectablesMaterials
        {
            AmakumoFruit, CallaLily, Cecilia, CorLapis, CrystalMarrow, DandelionSeed, Dendrobium, FluorescentFungus, GlazeLily, JueyunChili, KalpalataLotus,
            NakuWeed, NilotpalaLotus, NoctilucousJade, Onikabuto, Padisarah, PhilanemoMushroom, Qingxin, Redcrest, RukkhashavaMushrooms, SakuraBloom, SangoPearl, Scarab,
            SeaGanoderma, SilkFlower, SmallLampGrass, Starconch, Valberry, Violetgrass, WindwheelAster, Wolfhook
        }
        enum FarmableMaterials
        {
            HurricaneSeed, LightningPrism, BasaltPillar, HoarfrostCore, EverflameSeed, CleansingHeart, JuvenileJade, CrystallineBloom, MarionetteCore,
            PerpetualHeart, SmolderingPearl, DewOfRepudiation, RiftbornRegalia, DragonheirsFalseFin, RunicFang, MajesticHookedBeak, ThunderclapFruitcore,
            PerpetualCaliber, LightGuidingTetrahedron
        }

        //base stats and
        private string name;
        private string title;
        private Elements elementalAlignment;
        private bool rarity;  //true = 5 star, false = 4 star;
        private int baseATK;
        private int baseDEF;
        private int baseHealth;
        private float critRate;
        private float critDMG;

        //ascension materials




        //Control

        private float maxATKMultiplier;
        private float maxATKBoostMultiplier;

        private float maxAscensionHealthMultiplier;
        private float maxAscensionATKMultiplier;
        private float maxAscensionDEFMultiplier;

        private AscensionBonus ascensionBonus;
        private Stats bestStatinSubstat;



        //UI

        private string portraitFilePath;
        private string spriteFilePath;





        //methods

        int getBaseHealthAtLevel(int level)
        {
            return 0;
        }
        int getBaseATKAtLevel(int level)
        {
            return 0;
        }
        int getBaseDEFAtLevel(int level)
        {
            return 0;
        }
        int getBaseCritDMGAtLevel(int level)
        {
            return 0;
        }
        int getBaseCritRateAtLevel(int level)
        {
            return 0;
        }






    }
}
