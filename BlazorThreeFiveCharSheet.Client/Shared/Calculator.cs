using BlazorThreeFiveCharSheet.Client.Models;
using System.Collections.Specialized;

namespace BlazorThreeFiveCharSheet.Client.Shared
{
    public static class Calculator
    {
        public static int CalcModValue(int value)
        {
            return (value - 10) / 2;
        }

        public static void TotalAC(ThreeFiveSheet stats)
        {
            //TO DO, add the max dex mod check when the armor section gets built out
            var total = 10 + stats.acArmor + stats.acDex + stats.acShield + stats.acNat + stats.acDeflection + stats.acSizeMod;
            stats.acTotal = total;
            stats.acFF = total - stats.acDex;
            stats.acTouch = total - stats.acArmor - stats.acShield;
        }
        public static void CalcSaves(ThreeFiveSheet stats)
        {
            stats.fortTotal = stats.fortBase + stats.fortAbilityMod + stats.fortMagicMod + stats.fortMiscMod + stats.fortTempMod + stats.conMod;
            stats.reflexTotal = stats.reflexBase + stats.reflexAbilityMod + stats.reflexMagicMod + stats.reflexMiscMod + stats.reflexTempMod + stats.acDex;
            stats.willTotal = stats.willBase + stats.willAbilityMod + stats.willMagicMod + stats.willMiscMod + stats.willTempMod + stats.wisMod;
        }
        
        public static void TotalSkills(ThreeFiveSheet model)
        {
            foreach(var skill in model.skillList)
            {
                var total = skill.ranks + skill.misc;
                switch (skill.keyAbility)
                {
                    case "STR":
                        total += model.strMod;
                        break;
                    case "DEX":
                        total += model.dexMod;
                        break;
                    case "CON":
                        total += model.conMod;
                        break;
                    case "WIS":
                        total += model.wisMod;
                        break;
                    case "INT":
                        total += model.intMod;
                        break;
                    case "CHA":
                        total += model.chaMod;
                        break;
                    default:
                        break;
                }
                skill.total = total;
            }
        }

        public static int CharacterLvl(int exp)
        {
            var lvl = 1;
            var counter = 1;
            var currentCutOff = 1000;
            while (exp >= currentCutOff)
            {
                currentCutOff += (++counter * 1000);
                lvl++;
            }
            return lvl;
        }
        public static int CalcSpellDcs(ThreeFiveSheet model, int lvl = 0)
        {
            var save = 10 + lvl;
            switch (model.spellcastingStat)
            {
                case "WIS":
                    save += model.wisMod;
                    break;
                case"INT":
                    save += model.intMod;
                    break;
                case"CHA":
                    save += model.chaMod;
                    break;
                default:
                    break;
            }

            return save;
        }
    }
}
