namespace PastaPizza.Gerechten;

public class Pasta : Gerecht
{

    public string Omschrijving { get; set; }

    public Pasta(string omschrijving, double prijs)
    {
        Omschrijving = omschrijving;
        Prijs = prijs;
    }

    public Pasta(string omschrijving, List<string> onderdelen)
    {
        
        Omschrijving = omschrijving;
    }

    public override string ToString()
    {
        return $"{Omschrijving} ({BerekenBedrag()} euro)";
    }

    public override double BerekenBedrag()
    {
        return Prijs;
    }
}