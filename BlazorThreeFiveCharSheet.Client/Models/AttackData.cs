namespace BlazorThreeFiveCharSheet.Client.Models
{
    public class AttackData
    {
        public AttackData()
        {
            this.name = string.Empty;
            this.attackBonus = string.Empty;
            this.dmg = string.Empty;
            this.crit = string.Empty;
            this.range = 5;
            this.type = string.Empty;
            this.notes = string.Empty;
            this.ammo = string.Empty;
        }

        public string name { get; set; }
        public string attackBonus { get; set; }
        public string dmg { get; set; }
        public string crit { get; set; }
        public int range { get; set; }
        public string type { get; set; }
        public string notes {  get; set; }
        public string ammo { get; set; }
    }
}
