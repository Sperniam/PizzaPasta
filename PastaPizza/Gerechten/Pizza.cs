namespace PastaPizza.Gerechten;

public class Pizza : Gerecht
{
    public List<string> Onderdelen { get; set; }
    
    public Pizza(List<string> onderdelen, string naam, double prijs)
    {
        Onderdelen = onderdelen;
        Naam = naam;
        Prijs = (prijs < 0) ? 0 : prijs;
    }

    public override string ToString()
    {
        string onderdelenLijst = "";
        foreach (string s in Onderdelen)
        {
            onderdelenLijst += s;
            onderdelenLijst += " - ";
        }

        onderdelenLijst = onderdelenLijst.Remove(onderdelenLijst.Length - 2);        
        return $"{Naam} ({BerekenBedrag()} euro) {onderdelenLijst}";
    }

    public override double BerekenBedrag()
    {
        return Prijs;
    }
}