using PastaPizza.Bestellingen;
namespace PastaPizza.Desserten;

public class Dessert : IBedrag
{
    public DessertenEnum.Dessert Dessertje { get; set; }

    public Dessert(DessertenEnum.Dessert dessertje)
    {
        Dessertje = dessertje;
    }

        public double Prijs { get { if (Dessertje == DessertenEnum.Dessert.Tiramisu || Dessertje == DessertenEnum.Dessert.Ijs)
        {
            return 3;
        }
        else if (Dessertje == DessertenEnum.Dessert.Cake)
        {
            return 2;
        }

        return 0;} }
    
    


    public double BerekenBedrag()
    {
        return Prijs;
    }

    public override string ToString()
    {
        return $"Dessert: {Dessertje} ({Prijs} euro)";
    }
}