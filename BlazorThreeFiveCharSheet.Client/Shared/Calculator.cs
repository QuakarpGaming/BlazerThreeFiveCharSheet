using BlazorThreeFiveCharSheet.Client.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Linq;

namespace BlazorThreeFiveCharSheet.Client.Shared
{
    public static class Calculator
    {
        public static int CalcModValue(int value)
        {
            return (value - 10) / 2;
        }
        public static Dictionary<int, int> lightLoads35 = new Dictionary<int, int>
        {
            {1,3},
            {2,6},
            {3,10},
            {4,13},
            {5,16},
            {6,20},
            {7,23},
            {8,26},
            {9,30},
            {10,33},
            {11,38},
            {12,43},
            {13,50},
            {14,58},
            {15,66},
            {16,76},
            {17,86},
            {18,100},
            {19,116},
            {20,133},
            {21,153},
            {22,173},
            {23,200},
            {24,233},
            {25,266},
            {26,306},
            {27,346},
            {28,400},
            {29,466},
        };
        public static Dictionary<int, int> medLoads35 = new Dictionary<int, int>
        {
            {1,6},
            {2, 13},
            {3, 20},
            {4, 26},
            {5, 33},
            {6, 40},
            {7, 46},
            {8, 53},
            {9, 60},
            {10,66 },
            {11,76 },
            {12,86 },
            {13,100},
            {14,116},
            {15,133},
            {16,153},
            {17,173},
            {18,200},
            {19,233},
            {20,266},
            {21,306},
            {22,346},
            {23,400},
            {24,466},
            {25,533},
            {26,613},
            {27,693},
            {28,800},
            {29,933},
        };
        public static Dictionary<int, int> heavyLoads35 = new Dictionary<int, int>
        {
            {1, 10  },
            {2, 20  },
            {3, 30  },
            {4, 40  },
            {5, 50  },
            {6, 60  },
            {7, 70  },
            {8, 80  },
            {9, 90  },
            {10,100 },
            {11,115 },
            {12,130 },
            {13,150 },
            {14,175 },
            {15,200 },
            {16,230 },
            {17,260 },
            {18,300 },
            {19,350 },
            {20,400 },
            {21,460 },
            {22,520 },
            {23,600 },
            {24,700 },
            {25,800 },
            {26,920 },
            {27,1040},
            {28,1200},
            {29,1400},
        };
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
            foreach (var skill in model.skillList)
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
                case "INT":
                    save += model.intMod;
                    break;
                case "CHA":
                    save += model.chaMod;
                    break;
                default:
                    break;
            }

            return save;
        }
        public static void CalcWightLoads(ThreeFiveSheet model)
        {
            if (model.str <= 29)
            {
                model.loads["Light Load"] = lightLoads35[model.str];
                model.loads["Medium Load"] = medLoads35[model.str];
                model.loads["Heavy Load"] = heavyLoads35[model.str];
            }
            else
            {
                var multiplier = (decimal)Math.Pow(4, ((model.str - 30) / 10) + 1) ;
                var baseload = 20 + GetDigits(model.str).FirstOrDefault();
                model.loads["Light Load"] = lightLoads35[baseload] * multiplier;
                model.loads["Medium Load"] = medLoads35[baseload] * multiplier;
                model.loads["Heavy Load"] = heavyLoads35[baseload] * multiplier;

            }
            //finish the boxes
            var maxLoad = model.loads["Heavy Load"];
            model.loads["Lift Over Head"] = maxLoad;
            model.loads["Lift Off Ground"] = maxLoad * 2;
            model.loads["Push Or Drag"] = maxLoad * 5;
            //then size time
            var sizeMult = 1M;
            switch (model.size)
            {
                case "S":
                    sizeMult = 0.75M;
                    break;
                case "L":
                    sizeMult = 2M;
                    break;
                default:
                    break;
            }
            foreach (var key in model.loads.Keys)
            {
                model.loads[key] *= sizeMult;
            }
        }

        public static string FormatLoad(ThreeFiveSheet model,string load)
        {
            var returnString = string.Empty;
            switch (load)
            {
                case "Light Load":
                    returnString = $"{model.loads[load]} lb. or less";
                    break;
                case "Medium Load":
                    returnString = $"{model.loads["Light Load"] + 1}-{model.loads[load]} lb.";
                    break;
                case "Heavy Load":
                    returnString = $"{model.loads["Medium Load"] + 1}-{model.loads[load]} lb.";
                    break;
                default:
                    returnString = $"{model.loads[load]} lb.";
                    break;
            }
            return returnString;
        }
        private static IEnumerable<int> GetDigits(int source)
        {
            while (source > 0)
            {
                var digit = source % 10;
                source /= 10;
                yield return digit;
            }
        }
    }
}
