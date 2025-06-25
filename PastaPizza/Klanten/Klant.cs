namespace PastaPizza.Klanten;

public class Klant
{
    public string Naam  { get; set; }
    public int KlantID { get;}

    public Klant()
    {
        Naam = "Onbekende Klant";
        KlantID++;
    }

    public Klant(string naam)
    {
        Naam = naam;
        KlantID++;
    }
}