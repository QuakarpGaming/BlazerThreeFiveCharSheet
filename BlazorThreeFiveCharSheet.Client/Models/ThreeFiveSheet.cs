using BlazorThreeFiveCharSheet.Client.Shared;
using System.Threading.Tasks.Dataflow;

namespace BlazorThreeFiveCharSheet.Client.Models
{
    public class ThreeFiveSheet
    {
        public ThreeFiveSheet()
        {
            characterName = string.Empty;
            player = string.Empty;

            classLvlString = string.Empty;
            race = string.Empty;
            lastRace = string.Empty;

            alignment = string.Empty;
            deity = string.Empty;
            size = string.Empty;
            age = 18;
            gender = string.Empty;
            height = string.Empty;
            eyes = string.Empty;
            hair = string.Empty;
            skin = string.Empty;

            str = 10;
            strMod = 0;
            dex = 10;
            dexMod = 0;
            con = 10;
            conMod = 0;
            wis = 10;
            wisMod = 0;
            intel = 10;
            intMod = 0;
            cha = 10;
            chaMod = 0;

            tempStr = 10;
            tempStrMod = 0;
            tempDex = 10;
            tempDexMod = 0;
            tempCon = 10;
            tempConMod = 0;
            tempWis = 10;
            tempWisMod = 0;
            tempIntel = 10;
            tempIntMod = 0;
            tempCha = 10;
            tempChaMod = 0;

            maxHP = 10;
            currentHP = 10;
            nonLethalDmg = 0;

            acTotal = 10;
            acTouch = 10;
            acFF = 10;
            acArmor = 0;
            acShield = 0;
            acNat = 0;
            acDeflection = 0;
            acSizeMod = 0;

            init = 0;
            speed = "30FT";
            dmgRedutions = string.Empty;

            fortTotal = 0;
            fortBase = 0;
            fortAbilityMod = 0;
            fortMagicMod = 0;
            fortMiscMod = 0;
            fortTempMod = 0;

            reflexTotal = 0;
            reflexBase = 0;
            reflexAbilityMod = 0;
            reflexMagicMod = 0;
            reflexMiscMod = 0;
            reflexTempMod = 0;

            willTotal = 0;
            willBase = 0;
            willAbilityMod = 0;
            willMagicMod = 0;
            willMiscMod = 0;
            willTempMod = 0;

            skillList = new List<Skill>()
            {
                new(name:"Appraise",keyAbility:"INT"),
                new(name:"Balance",keyAbility:"DEX",armorCheck:true),
                new(name:"Bluff",keyAbility:"CHA"),
                new(name:"Climb",keyAbility:"STR",armorCheck:true),
                new(name:"Concentration",keyAbility:"CON"),
                new(name:"Craft1",keyAbility:"INT",showSubName:true),
                new(name:"Craft2",keyAbility:"INT",showSubName:true),
                new(name:"Craft3",keyAbility:"INT",showSubName:true),
                new(name:"Decipher Script",keyAbility:"INT",useUntrained:false),
                new(name:"Diplomacy",keyAbility:"CHA"),
                new(name:"Disable Device",keyAbility:"INT",useUntrained:false),
                new(name:"Disguise",keyAbility:"CHA"),
                new(name:"Escape Artist",keyAbility:"DEX",armorCheck:true),
                new(name:"Forgery",keyAbility:"INT"),
                new(name:"Gather Info",keyAbility:"CHA"),
                new(name:"Handle Animal",keyAbility:"CHA"),
                new(name:"Heal",keyAbility:"WIS"),
                new(name:"Hide",keyAbility:"DEX",armorCheck:true),
                new(name:"Intimidate",keyAbility:"CHA"),
                new(name:"Jump",keyAbility:"STR",armorCheck:true),
                new(name:"Knowledge1",keyAbility:"INT",showSubName:true),
                new(name:"Knowledge2",keyAbility:"INT",showSubName:true),
                new(name:"Knowledge3",keyAbility:"INT",showSubName:true),
                new(name:"Knowledge4",keyAbility:"INT",showSubName:true),
                new(name:"Knowledge5",keyAbility:"INT",showSubName:true),
                new(name:"Listen",keyAbility:"WIS"),
                new(name:"Move Silently",keyAbility:"CHA",armorCheck:true),
                new(name:"Open Lock",keyAbility:"DEX",useUntrained:false),
                new(name:"Perform1",keyAbility:"CHA",useUntrained:false,showSubName:true),
                new(name:"Perform2",keyAbility:"CHA",useUntrained:false,showSubName:true),
                new(name:"Perform3",keyAbility:"CHA",useUntrained:false,showSubName:true),
                new(name:"Profession1",keyAbility:"WIS",useUntrained:false,showSubName:true),
                new(name:"Profession2",keyAbility:"WIS",useUntrained:false,showSubName:true),
                new(name:"Ride",keyAbility:"DEX"),
                new(name:"Search",keyAbility:"INT"),
                new(name:"Sense Motive",keyAbility:"WIS"),
                new(name:"Sleight of Hand",keyAbility:"DEX",armorCheck:true),
                new(name:"Spellcraft",keyAbility:"INT",useUntrained:false),
                new(name:"Spot",keyAbility:"WIS"),
                new(name:"Swim",keyAbility:"STR",armorCheck:true),
                new(name:"Tumble",keyAbility:"DEX",armorCheck:true),
                new(name:"Use Magic Device",keyAbility:"CHA",useUntrained:false),
                new(name:"Use Rope",keyAbility:"DEX"),
            };

            showInfoValues = new Dictionary<string, bool>()
            {
                
                {"Top Info",true },
                {"Stats", true},
                { "HP/AC", true },
                { "Saves", true },
                { "Skills", true },
                { "Attacks", true },
                { "Gear", true },
                { "Feats/Abilities/Langauge", true },
                { "Spells", true },
                {"Money" ,true}
            };
            bab = string.Empty;
            SpellRes = 0;
            attacks = [];
            campaign = string.Empty;
            exp = 0;
            characterLvl = 1;

            armor = new Gear
            {
                acType = ACType.Armor
            };
            shield = new Gear
            {
                acType = ACType.Shield
            };
            protectionItems = [];
            otherPosessions = [];
            feats = [];
            specialAbilities = [];
            languages = [];
            casterLvl = 0;
            baseSpellSave = 0;
            spellcastingStat = string.Empty;
            spellsKnown = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, };
            spellSaveDcs = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, };
            spellsPerDay = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, };
            bonusSpells = new Dictionary<int, int>() { { 0, 0 }, { 1, 0 }, { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 }, { 6, 0 }, { 7, 0 }, { 8, 0 }, { 9, 0 }, };
            spells = new Dictionary<int, List<string>>() { { 0, [] }, { 1, [] }, { 2, [] }, { 3, [] }, { 4, [] }, { 5, [] }, { 6, [] }, { 7, [] }, { 8, [] }, { 9, [] }, };
            money = new Dictionary<string, int>()
            {
                {"CP", 0},
                {"SP", 0},
                {"GP", 0},
                {"PP", 0}
            };

            loads = new Dictionary<string, decimal>()
            {
                { "Light Load", 0 },
                { "Medium Load", 0 },
                { "Heavy Load", 0 },
                { "Lift Over Head", 0 },
                { "Lift Off Ground", 0 },
                { "Push Or Drag", 0 }
            };
            loadFormated = new Dictionary<string, string>()
            {
                { "Light Load",      Calculator.FormatLoad(this,"Light Load") },
                { "Medium Load"    , Calculator.FormatLoad(this,"Medium Load")},
                { "Heavy Load"     , Calculator.FormatLoad(this,"Heavy Load")},
                { "Lift Over Head" , Calculator.FormatLoad(this,"Lift Over Head")},
                { "Lift Off Ground", Calculator.FormatLoad(this,"Lift Off Ground")},
                { "Push Or Drag"   , Calculator.FormatLoad(this,"Push Or Drag")}
            };
        }


        public string characterName { get; set; }
        public string player { get; set; }
        public string classLvlString { get; set; }
        public string race { get; set; }
        public string lastRace { get; set; }
        public string alignment { get; set; }
        public string deity { get; set; }
        public string size { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public string height { get; set; }
        public string eyes { get; set; }
        public string hair { get; set; }
        public string skin { get; set; }
        public int str { get; set; }
        public int strMod { get; set; }
        public int dex { get; set; }
        public int dexMod { get; set; }
        public int con { get; set; }
        public int conMod { get; set; }
        public int wis { get; set; }
        public int wisMod { get; set; }
        public int intel { get; set; }
        public int intMod { get; set; }
        public int cha { get; set; }
        public int chaMod { get; set; }
        public int tempStr { get; set; }
        public int tempStrMod { get; set; }
        public int tempDex { get; set; }
        public int tempDexMod { get; set; }
        public int tempCon { get; set; }
        public int tempConMod { get; set; }
        public int tempWis { get; set; }
        public int tempWisMod { get; set; }
        public int tempIntel { get; set; }
        public int tempIntMod { get; set; }
        public int tempCha { get; set; }
        public int tempChaMod { get; set; }
        public int maxHP { get; set; }
        public int currentHP { get; set; }
        public int nonLethalDmg { get; set; }
        public int acTotal { get; set; }
        public int acTouch { get; set; }
        public int acFF { get; set; }
        public int acArmor { get; set; }
        public int acShield { get; set; }
        public int acSizeMod { get; set; }
        public int acNat { get; set; }
        public int acDeflection { get; set; }
        public int acDex => CalcArmorDexMod();
        public int init { get; set; }
        public string speed { get; set; }
        public string dmgRedutions { get; set; }

        public int fortTotal { get; set; }
        public int fortBase { get; set; }
        public int fortAbilityMod { get; set; }
        public int fortMagicMod { get; set; }
        public int fortMiscMod { get; set; }
        public int fortTempMod { get; set; }

        public int reflexTotal { get; set; }
        public int reflexBase { get; set; }
        public int reflexAbilityMod { get; set; }
        public int reflexMagicMod { get; set; }
        public int reflexMiscMod { get; set; }
        public int reflexTempMod { get; set; }

        public int willTotal { get; set; }
        public int willBase { get; set; }
        public int willAbilityMod { get; set; }
        public int willMagicMod { get; set; }
        public int willMiscMod { get; set; }
        public int willTempMod { get; set; }
        public List<Skill> skillList { get; set; }
        public Dictionary<string, bool> showInfoValues { get; set; }
        public string bab { get; set; }
        public int SpellRes { get; set; }
        public List<AttackData> attacks { get; set; }
        public string campaign { get; set; }
        public int exp { get; set; }
        public int characterLvl { get; set; }
        public Gear armor { get; set; }
        public Gear shield { get; set; }
        public List<Gear> protectionItems { get; set; }
        public int spellFailure => armor.spellFailure + shield.spellFailure;
        public int armorCheckPent => armor.checkPen + shield.checkPen;
        public List<OtherPosession> otherPosessions { get; set; }
        public decimal totalWeightCarried => otherPosessions.Sum(x => x.amount * x.weight);
        public List<string> feats { get; set; }
        public List<string> specialAbilities { get; set; }
        public List<string> languages { get; set; }

        public int casterLvl { get; set; }
        public int baseSpellSave { get; set; }
        public string spellcastingStat { get; set; }
        public Dictionary<int, int> spellsKnown { get; set; }
        public Dictionary<int, int> spellSaveDcs { get; set; }
        public Dictionary<int, int> spellsPerDay { get; set; }
        public Dictionary<int, int> bonusSpells { get; set; }
        public Dictionary<int, List<string>> spells { get; set; }
        public Dictionary<string, int> money { get; set; }
        public Dictionary<string, decimal> loads { get; set; }
        public Dictionary<string, string> loadFormated { get; set; }


        private int CalcArmorDexMod()
        {
            var returnValue = dexMod;
            if (armor.maxDexMod.HasValue)
            {
                if (dexMod > armor.maxDexMod.Value)
                    returnValue = armor.maxDexMod.Value;
            }

            return returnValue;
        }
    }
}
