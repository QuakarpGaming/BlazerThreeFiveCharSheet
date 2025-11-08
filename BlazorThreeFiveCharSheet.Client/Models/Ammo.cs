namespace BlazorThreeFiveCharSheet.Client.Models
{
    public class Ammo
    {
        public Ammo()
        {
            Name = string.Empty;
            Qty = 0;
            Notes = string.Empty;
        }
        public string Name { get; set; }
        public int Qty { get; set; }
        public string Notes { get; set; }
    }
}
