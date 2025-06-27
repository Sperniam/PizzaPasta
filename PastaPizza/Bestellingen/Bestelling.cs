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

    public Drank Drank { get; set; }

    public Dessert Dessert { get; set; }

    public int Aantal { get; }

    public Bestelling(Klant klant, Dessert dessert, int aantal = 1): this(klant,null,null,dessert,aantal)
    {
        
    }
    
    public Bestelling(Klant klant, Drank drank, int aantal = 1) : this(klant,null,drank,null,aantal)
    {
      
    }
    public Bestelling(BesteldGerecht besteldGerecht, int aantal = 1) : this (null,besteldGerecht,null,null,aantal)
    {
        Klant = new Klant("Onbekende Klant",0);
    }

    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank, int aantal = 1) : this(klant,besteldGerecht,drank,null,aantal)
    {
       
    }
  
    public Bestelling(Klant klant, BesteldGerecht besteldGerecht, Drank drank, Dessert dessert, int aantal = 1) 
    {
        Klant = klant;
        BesteldGerecht = besteldGerecht;
        Drank = drank;
        Dessert = dessert;
        Aantal = aantal;
    }


    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Klant: {Klant.Naam}");

        if (BesteldGerecht != null)
            sb.AppendLine($"Gerecht: {BesteldGerecht}");

        if (Drank != null)
            sb.AppendLine($"Drank: {Drank.NaamDrank} ({Drank.BerekenBedrag():#.00)} euro)");

        if (Dessert != null)
            sb.AppendLine($"Dessert: {Dessert.Naam} ({Dessert.BerekenBedrag():#.00} euro)");

        sb.AppendLine($"Aantal: {Aantal}");
        sb.AppendLine($"Bedrag van deze bestelling: {BerekenBedrag():#.00} euro");

        return sb.ToString().TrimEnd();
    }

    

    public double BerekenBedrag()
    {
        double totaal = 0;
        
        double gerechtBedrag = BesteldGerecht?.BerekenBedrag() ?? 0;
        double drankBedrag = Drank?.BerekenBedrag() ?? 0;
        double dessertBedrag = Dessert?.BerekenBedrag() ?? 0;
        
        totaal += gerechtBedrag+drankBedrag+dessertBedrag;
        totaal *= Aantal;
        

        if (dessertBedrag > 0 && gerechtBedrag > 0 && drankBedrag > 0 && dessertBedrag > 0)
        {
            totaal *= 0.9;

        }
        return Math.Round(totaal, 2); 

    }
    
    public static void TekenLijn()
    {
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        
    }

    public static void TekenSter()
    {
            Console.WriteLine("*******************************************************************************************");

    }
}
