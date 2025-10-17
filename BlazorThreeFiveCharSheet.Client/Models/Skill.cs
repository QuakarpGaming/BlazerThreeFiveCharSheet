namespace BlazorThreeFiveCharSheet.Client.Models
{
    public class Skill
    {
        public Skill(string name = "Appraise", string keyAbility = "STR", bool armorCheck = false, bool useUntrained = true, bool classSkill = false, string subName = "", bool showSubName = false)
        {
            this.name = name;
            this.keyAbility = keyAbility;
            this.total = 0;
            this.ranks = 0;
            this.misc = 0;
            this.armorCheck = armorCheck;
            this.useUntrained = useUntrained;
            this.classSkill = classSkill;
            this.subName = subName;
            this.showSubName = showSubName;
        }
        public string name { get; set; }
        public string keyAbility { get; set; }

        public int total {  get; set; }
        public int ranks { get; set; }
        public int misc { get; set; }
        public bool armorCheck {  get; set; }
        public bool useUntrained { get; set; }
        public bool classSkill { get; set; }
        public string subName { get; set; }
        public bool showSubName { get; set; }

    }

}
