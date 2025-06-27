namespace PastaPizza.Klanten;

public class Klant
{
    public string Naam  { get; set; }
    public int KlantID { get;}

    public Klant()
    {
        Naam = "Onbekende Klant";
    }

    public Klant(string naam, int klantID)
    {
        Naam = naam;
        KlantID++;
    }
}