using PastaPizza;
using PastaPizza.Bestellingen;
using PastaPizza.Desserten;
using PastaPizza.Dranken;
using PastaPizza.Gerechten;
using PastaPizza.Gerechten.GerechtEnums;
using PastaPizza.Klanten;





int bestelNr = 1;

//Klanten
Klant klant1 = new Klant("Jan Janssen");
Klant klant2 = new Klant("Piet Peeters");



Console.WriteLine("Alle Bestelingen");
Console.WriteLine("******************************************************************************");

//Bestelling 1

List<string> onderdelen = new List<string>();
onderdelen.Add("Tomatensaus");
onderdelen.Add("Mozzarella");

List<Extras> extras = new List<Extras>();
extras.Add(Extras.Kaas);
extras.Add(Extras.Look);


Gerecht pizza = new Pizza("Pizza Margheritta",onderdelen,8);
BesteldGerecht gerecht1 = new BesteldGerecht(pizza,extras,Grootte.Groot);
Drank drank1 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Water);
Dessert dessert1 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Tiramisu);


Bestelling bestelling1 = new Bestelling(klant1,gerecht1,drank1,dessert1,2);

//--------------------------------------------------------------------------------------------



//Bestelling 2

Gerecht gerecht2 = pizza;

BesteldGerecht besteldGerecht2 = new BesteldGerecht(gerecht2,Grootte.Klein);
Drank drank2 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Water);
Dessert dessert2 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Ijs);

Bestelling bestelling2 = new Bestelling(klant2,besteldGerecht2,drank2,dessert2);
//--------------------------------------------------------------------------------------------



//Bestelling 3

List<string> onderdelen3 = new List<string>();
onderdelen3.Add("Tomatensaus");
onderdelen3.Add("Mozzarella");
onderdelen3.Add("Ansjovis");
onderdelen3.Add("Kappers");
onderdelen3.Add("Olijven");

Gerecht gerecht3 = new Pizza("Pizza Napoli",onderdelen3,10);
Drank drank3 = new Warmedrank(PastaPizza.Dranken.DrankEnum.Drank.Thee);
Dessert dessert3 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Ijs);
BesteldGerecht besteldGerecht3 = new BesteldGerecht(gerecht3,Grootte.Groot);

Bestelling bestelling3 = new Bestelling(klant2,besteldGerecht3,drank3,dessert3);
//--------------------------------------------------------------------------------------------



//Bestelling 4

Gerecht gerecht4 = new Pasta("Lasagne",15);
List<Extras> extras4 = new List<Extras>();
extras4.Add(Extras.Look);
BesteldGerecht besteldGerecht4 = new BesteldGerecht(gerecht4,extras4,Grootte.Klein);

Bestelling bestelling4 = new Bestelling(besteldGerecht4);
//--------------------------------------------------------------------------------------------



//Bestelling 5

Gerecht gerecht5 = new Pasta("Spaghetti Carbonara",13,"spek, roomsaus en parmezaanse kaas");
Drank drank5 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Cocacola);
BesteldGerecht besteldGerecht5 = new BesteldGerecht(gerecht5,Grootte.Klein);

Bestelling bestelling5 = new Bestelling(klant1,besteldGerecht5,drank5);
//--------------------------------------------------------------------------------------------


//Bestelling 6

List<Extras> extras6 = new List<Extras>();
extras6.Add(Extras.Kaas);

Gerecht gerecht6 = new Pasta("Spaghetti Bolognese", 12,"met gehaktsaus");
Drank drank6 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Cocacola);
Dessert dessert6 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Cake);
BesteldGerecht besteldGerecht6 = new BesteldGerecht(gerecht6,extras6,Grootte.Groot);

Bestelling bestelling6 = new Bestelling(klant2,besteldGerecht6,drank6,dessert6);
//--------------------------------------------------------------------------------------------


//Bestelling 7

Drank drank7 = new Warmedrank(PastaPizza.Dranken.DrankEnum.Drank.Koffie);
Bestelling bestelling7 = new Bestelling(klant2,drank7,3);
//--------------------------------------------------------------------------------------------


//Bestelling 8
Dessert dessert8 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Tiramisu);
Bestelling bestelling8 = new Bestelling(klant1, dessert8);



// Lijst van Alle bestelling
List<Bestelling> bestellingen = new List<Bestelling>(); 
bestellingen.Add(bestelling1);
bestellingen.Add(bestelling2);
bestellingen.Add(bestelling3);
bestellingen.Add(bestelling4);
bestellingen.Add(bestelling5);
bestellingen.Add(bestelling6);
bestellingen.Add(bestelling7);
bestellingen.Add(bestelling8);

// Alle bestellingen van iedereen
foreach (Bestelling bestelling in bestellingen) 
{
    Console.WriteLine($"Bestelling {bestelNr++}:");
    Console.WriteLine($"{bestelling}\n");
}

Console.WriteLine("-----------------------------------------------------------------------------------------------");
Console.WriteLine("Bestellingen van de klant Jan Janssen"); // Enkel Jan Janssen
Console.WriteLine("******************************************************************************");

//Enkel Jan Janssen
foreach (Bestelling bestelling in bestellingen)
{
    var enkelJan = bestelling.Klant.Naam.Equals("Jan Janssen");
    if (enkelJan)
        Console.WriteLine($"{bestelling}\n");
}


Console.WriteLine("Bestellingen gegroepeerd per klant\n*****************************************************************************\n");

//Grouped Klanten
foreach (var groep in bestellingen.GroupBy(b => b.Klant.Naam))
{
       Console.WriteLine($"Bestellingen van klant: {groep.Key}\n");
    foreach (var bestelling in groep)
    {
        
        Console.WriteLine();
        Console.WriteLine(bestelling);
        Console.WriteLine($"Totaal bedrag van alle bestellingen van klant {bestelling.Klant.Naam}: {bestelling.BerekenBedrag().ToString("#.00")} euro");

    }
    Console.WriteLine("------------------------------------------------------------------------------\n");
}





