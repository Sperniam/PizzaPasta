using PastaPizza.Gerechten.GerechtEnums;

namespace PastaPizza.Gerechten;

public class Pasta : Gerecht
{

    public string Omschrijving { get; set; }

    


    public Pasta(string naam,double prijs)
    {
        Naam = naam;
        Prijs = prijs;
    }
    
    public Pasta(string naam ,double prijs, string omschrijving)
    {
        Naam = naam;
        Prijs = prijs;
        Omschrijving = omschrijving;
        
    }


    public override string ToString()
    {
        return $"{base.ToString()} {Omschrijving}";
    }

    public override double BerekenBedrag()
    {
        return Prijs;
    }
}