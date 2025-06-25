namespace PastaPizza.Bestellingen;
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

    
    
    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank dranken, Dessert dessert, int aantal = 1)
    {
        Klant = klant;
        BesteldGerecht = besteldGerecht;
        Dranken = dranken;
        Dessert = dessert;
        Aantal = aantal;
    }

    public override string ToString()
    {
        return $"Klant: {Klant.Naam}\n" +
               $"Gerecht: {BesteldGerecht} \n" +
               $"Drank: {Dranken.NaamDrank} ({Dranken.Prijs} euro)\n" +
               $"Dessert: {Dessert.Dessertje} ({Dessert.Prijs} euro)\n" +
               $"Aantal: {Aantal}\n" +
               $"Bedrag van deze bestelling: {BerekenBedrag()} euro";
    }

    public double BerekenBedrag()
    {
        double totaal = 0;
        totaal += Dranken.Prijs+Dessert.Prijs+ BesteldGerecht.BerekenBedrag();
        totaal*= Aantal;

        if (Dranken.Prijs > 0|| Dessert.Prijs > 0|| BesteldGerecht.BerekenBedrag() > 0)
        {
            totaal *= 0.9;
        }
        
        return Math.Round(totaal, 2); 
    }
    
    
}