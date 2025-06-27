using PastaPizza.Bestellingen;
namespace PastaPizza.Desserten;

public class Dessert : IBedrag
{
    public DessertenEnum.Dessert Naam { get; set; }

    public Dessert(DessertenEnum.Dessert naam)
    {
        Naam = naam;
    }

    public double Prijs
    {
        get {
            if (Naam == DessertenEnum.Dessert.Tiramisu || Naam == DessertenEnum.Dessert.Ijs)
            {
                return 3;
            } if (Naam == DessertenEnum.Dessert.Cake)
            {
                return 2;
            }

            return 0;
        }
    }
    
    


    public double BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return $"Dessert: {Naam} ({Prijs.ToString("#.0")} euro)";
    }
}