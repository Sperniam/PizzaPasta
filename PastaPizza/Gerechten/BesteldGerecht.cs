using PastaPizza.Bestellingen;
using PastaPizza.Gerechten.GerechtEnums;
namespace PastaPizza.Gerechten;

public class BesteldGerecht : IBedrag
{
    private Gerecht Gerecht {get;}

    private List <Extras> Extras { get; }
    
    private Grootte Grootte { get; }

    public BesteldGerecht(Gerecht gerecht, Grootte grootte)
    {
        Gerecht = gerecht;
        Grootte = grootte;
        Extras = new List <Extras>();
    }

    public BesteldGerecht(Gerecht gerecht, List<Extras> extras, Grootte grootte)
    {
        Gerecht = gerecht;
        Extras = extras;
        Grootte = grootte;
    }
    
    

    public override string ToString()
    {
        string extrasStr=" ";

        if (Extras.Count > 0)
        {
            foreach (Extras extra in Extras)
            {
                extrasStr += extra + " ";
            }  
            return $"{Gerecht} ({Grootte}) extra:{extrasStr} (bedrag: {BerekenBedrag()} euro)";
        } 
        return $"{Gerecht} ({Grootte}) (bedrag: {BerekenBedrag()} euro)";
    }

    public double BerekenBedrag()
    {
        double prijs = Gerecht.BerekenBedrag();

        foreach (var v in Extras)
        {
            prijs += 1;
        }

        if (Grootte == Grootte.Groot)
        {
            prijs += 3;
        }

        return prijs;
    }

}