namespace PastaPizza.Bestellingen;
using Gerechten;
using Dranken;
using Klanten;
using Desserten;

public class Bestelling : IBedrag
{
    public Klant Klant { get; set; }

    public BesteldGerecht BesteldGerecht { get; set; }

    public Drank Dranken { get; set; }

    public Dessert Dessert { get; set; }

    public int Aantal { get; }


    public Bestelling(BesteldGerecht besteldGerecht, int aantal = 1) // Als er geen Dranken of Desserts zijn = Null
    {
        Klant = new Klant("Onbekend");
        BesteldGerecht = besteldGerecht;
        Dranken = null;
        Dessert = null;
        Aantal = aantal;
    }

    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank dranken, int aantal = 1)
    {
        Klant = klant;
        BesteldGerecht = besteldGerecht;
        Dranken = dranken;
        Aantal = aantal;
    }

    public Bestelling(Klant klant, Dessert dessert, int aantal = 1)
    {
        Klant = klant;
        Dessert = dessert;
        Aantal = aantal;
    }


    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank dranken, Dessert dessert, int aantal = 1)
    {
        Klant = klant;
        BesteldGerecht = besteldGerecht;
        Dranken = dranken;
        Dessert = dessert;
        Aantal = aantal;
    }

    public Bestelling(Klant klant, Drank dranken, Dessert dessert, int aantal = 1)
    {
        Klant = klant;
        Dranken = dranken;
        Dessert = dessert;
        Aantal = aantal;
    }

    public Bestelling(Klant klant, Drank dranken, int aantal = 1)
    {
        Klant = klant;
        Dranken = dranken;
        Aantal = aantal;
    }

    public override string ToString()
    {
        //Waarom kunnen ze niet Null zijn ookal dat ik ze in de andere constructor op Null zet? (Meer opzoeken)
        if (Dranken != null && Dessert != null)
        {
            return $"Klant: {Klant.Naam}\n" +
                   $"Gerecht: {BesteldGerecht} \n" +
                   $"Drank: {Dranken.NaamDrank} ({Dranken.BerekenBedrag()} euro)\n"  +
                   $"Dessert: {Dessert.Dessertje} ({Dessert.BerekenBedrag()} euro)\n" +
                   $"Aantal: {Aantal}\n" +
                   $"Bedrag van deze bestelling: {BerekenBedrag()} euro";
        } else if (Dessert != null)
        {
            return $"Klant: {Klant.Naam}\n" +
                   $"Gerecht: {BesteldGerecht} \n" +
                   $"Dessert: {Dessert.Dessertje} ({Dranken.BerekenBedrag()} euro)\n" +
                   $"Aantal: {Aantal}\n" +
                   $"Bedrag van deze bestelling: {BerekenBedrag()} euro";
        } else if (Dranken != null)
        {
            return $"Klant: {Klant.Naam}\n" +
                   $"Gerecht: {BesteldGerecht} \n" +
                   $"Drank: {Dranken.NaamDrank} ({Dranken.BerekenBedrag()} euro)\n" +
                   $"Aantal: {Aantal}\n" +
                   $"Bedrag van deze bestelling: {BerekenBedrag()} euro";
        }
        
        return $"Klant: {Klant.Naam}\n" +
                 $"Gerecht:{BesteldGerecht} \n" +
                 $"Aantal: {Aantal}\n" +
                 $"Bedrag van deze bestelling: {BerekenBedrag()} euro";
    }
    

    public double BerekenBedrag()
    {
        double totaal = 0;
        
        double gerechtBedrag = BesteldGerecht?.BerekenBedrag() ?? 0;
        double drankBedrag = Dranken?.BerekenBedrag() ?? 0;
        double dessertBedrag = Dessert?.BerekenBedrag() ?? 0;
        
        totaal += gerechtBedrag+drankBedrag+dessertBedrag;
        

        if (dessertBedrag > 0 && gerechtBedrag > 0 && drankBedrag > 0 && dessertBedrag > 0)
        {
            totaal *= Aantal;
            totaal *= 0.9;

        }
        return Math.Round(totaal, 2); 

    }
    
    
    
}