using System.ComponentModel;

namespace BlazorThreeFiveCharSheet.Client.Models
{
    public class Gear
    {
        public Gear()
        {
            name = string.Empty;
            type = string.Empty;
            bonus = 0;
            checkPen = 0;
            spellFailure = 0;
            speed = 30;
            weight = 0;
            specialProps = string.Empty;
            maxDexMod = null;
            acType = ACType.Armor;
        }
        public string name { get; set; }
        public string type { get; set; }
        public int bonus { get; set; }
        public int checkPen { get; set; }
        public int spellFailure { get; set; }
        public int speed { get; set; }
        public int weight { get; set; }
        public string specialProps { get; set; }
        public int? maxDexMod { get; set; }
        public ACType acType { get; set; }

    }

    public class OtherPosession
    {
        public OtherPosession()
        {
            name = string.Empty;
            amount = 0;
            weight = 0;
        }
        public string name { get; set; }
        public int amount { get; set; }
        public decimal weight { get; set; }
    }
    public enum GearType
    {
        Armor,
        Shield,
        Neck,
        Ring,
        Head,
        Eye,
        Shirt,
        Shoulders,
        Arms,
        Hands,
        Boots
    }
    public enum ACType
    {
        Armor,
        Shield,
        Natural,
        Deflection
    }
}
