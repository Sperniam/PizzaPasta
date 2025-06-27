namespace PastaPizza.Gerechten;

public class Pizza : Gerecht
{
    public List<string> Onderdelen { get; set; }
    
    public Pizza(string naam,List<string> onderdelen, double prijs)
    {
        Onderdelen = onderdelen;
        Naam = naam;
        Prijs = (prijs < 0) ? 0 : prijs;
    }

    public override string ToString()
    {
        string onderdelenLijst = string.Join(" - ", Onderdelen);
        
        return $"{base.ToString()} {onderdelenLijst}";
    }

    public double BerekenBedrag()
    {
        return base.BerekenBedrag();
    }
}