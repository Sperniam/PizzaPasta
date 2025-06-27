using System.Text;

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

    public Bestelling(Klant klant, Dessert dessert, int aantal = 1): this(klant,null,null,dessert,aantal)
    {
        
    }
    
    public Bestelling(Klant klant, Drank dranken, int aantal = 1) : this(klant,null,dranken,null,aantal)
    {
      
    }
    public Bestelling(BesteldGerecht besteldGerecht, int aantal = 1) : this (null,besteldGerecht,null,null,aantal)
    {
        Klant = new Klant("Onbekende Klant");
    }

    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank dranken, int aantal = 1) : this(klant,besteldGerecht,dranken,null,aantal)
    {
       
    }
  
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
        var sb = new StringBuilder();
        sb.AppendLine($"Klant: {Klant.Naam}");

        if (BesteldGerecht != null)
            sb.AppendLine($"Gerecht: {BesteldGerecht}");

        if (Dranken != null)
            sb.AppendLine($"Drank: {Dranken.NaamDrank} ({Dranken.BerekenBedrag().ToString("#.0")} euro)");

        if (Dessert != null)
            sb.AppendLine($"Dessert: {Dessert.Dessertje} ({Dessert.BerekenBedrag().ToString("#.0")} euro)");

        sb.AppendLine($"Aantal: {Aantal}");
        sb.AppendLine($"Bedrag van deze bestelling: {BerekenBedrag().ToString("#.00")} euro");

        return sb.ToString().TrimEnd();
    }

    

    public double BerekenBedrag()
    {
        double totaal = 0;
        
        double gerechtBedrag = BesteldGerecht?.BerekenBedrag() ?? 0;
        double drankBedrag = Dranken?.BerekenBedrag() ?? 0;
        double dessertBedrag = Dessert?.BerekenBedrag() ?? 0;
        
        totaal += gerechtBedrag+drankBedrag+dessertBedrag;
        totaal *= Aantal;
        

        if (dessertBedrag > 0 && gerechtBedrag > 0 && drankBedrag > 0 && dessertBedrag > 0)
        {
            totaal *= 0.9;

        }
        return Math.Round(totaal, 2); 

    }
    
    
    
}