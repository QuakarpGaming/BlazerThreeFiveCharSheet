using BlazorThreeFiveCharSheet.Client.Models;

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
            var total = 10 + stats.acArmor + stats.dexMod + stats.acShield + stats.acNat + stats.acDeflection + stats.acSizeMod;
            stats.acTotal = total;
            stats.acFF = total - stats.dexMod;
            stats.acTouch = total - stats.acArmor - stats.acShield;
        }
        public static void CalcSaves(ThreeFiveSheet stats)
        {
            stats.fortTotal = stats.fortBase + stats.fortAbilityMod + stats.fortMagicMod + stats.fortMiscMod + stats.fortTempMod + stats.conMod;
            stats.reflexTotal = stats.reflexBase + stats.reflexAbilityMod + stats.reflexMagicMod + stats.reflexMiscMod + stats.reflexTempMod + stats.dexMod;
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

    }
}
