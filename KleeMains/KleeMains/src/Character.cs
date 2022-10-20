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
        enum Roles { MainDPS,SubDPS,Support,Healer}

        enum AscensionBonus {ElementalDMG,ATK,DEF,PhysicalDMG,EnergyRecharge,EM,Healing,CritRate,CritDMG}



        static double[] ascensionSumValues = {0.208791, 0.35714,0.55494,0.70329,0.85164,1.0};
        static double[] fourstarMultiplier =
        {
        1.000,1.083,1.165,1.248,1.330,1.413,1.495,1.578,1.661,1.743,1.826,1.908,1.991,2.073,2.156,2.239,2.321,2.404,2.486,2.569,2.651,2.734,2.817,2.899,2.982,3.064,3.147,3.229,3.312,3.394,
        3.477,3.560,3.642,3.725,3.807,3.890,3.972,4.055,4.138,4.220,4.303,4.385,4.468,4.550,4.633,4.716,4.798,4.881,4.963,5.046,5.128,5.211,5.294,5.376,5.459,5.541,5.624,5.706,5.789,5.872,
        5.954,6.037,6.119,6.202,6.284,6.367,6.450,6.532,6.615,6.697,6.780,6.862,6.945,7.028,7.110,7.193,7.275,7.358,7.440,7.523,7.606,7.688,7.771,7.853,7.936,8.018,8.101,8.183,8.266,8.349
        };

        static double[] fivestarMultiplier =
        {
        1.000,1.083,1.166,1.250,1.333,1.417,1.500,1.584,1.668,1.751,1.835,1.919,2.003,2.088,2.172,2.256,2.341,2.425,2.510,2.594,2.679,2.764,2.849,2.934,3.019,3.105,3.190,3.275,3.361,3.446,
        3.532,3.618,3.704,3.789,3.875,3.962,4.048,4.134,4.220,4.307,4.393,4.480,4.567,4.653,4.740,4.827,4.914,5.001,5.089,5.176,5.263,5.351,5.438,5.526,5.614,5.702,5.790,5.878,5.966,6.054,
        6.142,6.230,6.319,6.407,6.496,6.585,6.673,6.762,6.851,6.940,7.029,7.119,7.208,7.297,7.387,7.476,7.566,7.656,7.746,7.836,7.926,8.016,8.106,8.196,8.286,8.377,8.467,8.558,8.649,8.739
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
        enum CommonMaterialT1 { SlimeCondensate, DamagedMask, DiviningScroll, FirmArrowhead, RecruitsInsignia, TreasureHoarderInsignia, WhopperFlowerNectar, OldHandguard, SpectralHusk, FungalSpores, FadedRedSatin }
        enum CommonMaterialT2 { SlimeSecretions, StainedMask, SealedScroll, SharpArrowhead, SergeantsInsignia, SilverRavenInsignia, ShimmeringNectar, KageuchiHandguard, SpectralHeart, LuminescentPollen, TrimmedRedSilk }
        enum CommonMaterialT3 { SlimeConcentrate, OminousMask, ForbiddenCurseScroll, WeatheredArrowhead, LieutenantsInsignia, GoldenRavenInsignia, EnergyNectar, FamedHandguard, SpectralNucleus, CrystallineCystDust, RichRedBrocade }


        enum TalentMaterials
        {
            Freedom,Resistence,Ballad,Prosperity,Diligence,Gold,Transience,Elegance,Light,Admonition,Ingenuity,Praxis
        }

        enum TalentAscensionMaterial
        {
            DvalinsPlume,DvalinsClaw,DvalinsSigh,TailOfBoreas,RingOfBoreas,SpiritLocketOfBoreas,TuskOfMonocerosCaeli,ShardOfAFoulLegacy,ShadowOfTheWarrior,
            DragonLordsCrown,BloodjadeBranch,GildedScale,MoltenMoment,HellfireButterfly,AshenHeart,MudraOfTheMaleficGeneral,TearsOfTheCalamitousGod,TheMeaningOfAeons
        }

        //base stats and
        private string name;
        private string title;
        private Elements elementalAlignment;
        private Weapon characterWeapon;
        private bool rarity;  //true = 5 star, false = 4 star;
        private int baseATK;
        private int baseDEF;
        private int baseHealth;
        private float critRate;
        private float critDMG;
        private Roles role;

        //ascension materials

        CollectablesMaterials collectableMaterial;
        FarmableMaterials farmableMaterial;
        CommonMaterialT1 commonMaterialT1;
        CommonMaterialT1 commonMaterialT2;
        CommonMaterialT1 commonMaterialT3;


        TalentAscensionMaterial talentAscensionMaterial;
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
