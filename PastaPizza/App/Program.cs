using PastaPizza;
using PastaPizza.Bestellingen;
using PastaPizza.Desserten;
using PastaPizza.Dranken;
using PastaPizza.Gerechten;
using PastaPizza.Gerechten.GerechtEnums;
using PastaPizza.Klanten;



Console.WriteLine("Alle Bestelingen");
Console.WriteLine("******************************************************************************");

int bestelNr = 1;

//Bestelling 1
List<string> onderdelen = new List<string>();
onderdelen.Add("Tomatensaus");
onderdelen.Add("Mozzarella");

List<Extras> extras = new List<Extras>();
extras.Add(Extras.Kaas);
extras.Add(Extras.Look);

Klant klant1 = new Klant("Jan Janssen");
Gerecht pizza = new Pizza(onderdelen,naam:"Pizza Margheritta",8);
BesteldGerecht gerecht1 = new BesteldGerecht(pizza,extras,Grootte.Groot);
Drank drank1 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Water);
Dessert dessert1 = new Dessert(PastaPizza.Desserten.DessertenEnum.Dessert.Tiramisu);


Bestelling bestelling1 = new Bestelling(klant1,gerecht1,drank1,dessert1,2);

//--------------------------------------------------------------------------------------------



//Bestelling 2

Klant klant2 = new Klant("Piet Peeters");

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

Gerecht gerecht3 = new Pizza(onderdelen3,naam:"Pizza Napoli",10);
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
Gerecht gerecht5 = new Pasta("Spaghetti Carbonara",13);
Drank drank5 = new Frisdrank(PastaPizza.Dranken.DrankEnum.Drank.Cocacola);

List<string> onderdelen5 = new List<string>();
onderdelen5.Add("Spek");
onderdelen5.Add("Roomsaus");
onderdelen5.Add("Parmezaanse kaas");

BesteldGerecht besteldGerecht5 = new BesteldGerecht(gerecht5,Grootte.Klein); // Onderdelen nog toevoegen, kan er niet bij want er zit geen Constructor met Onderdelen in BesteldGerecht
Bestelling bestelling5 = new Bestelling(klant1,besteldGerecht5,drank5);
//--------------------------------------------------------------------------------------------


//Bestelling 6


List<Bestelling> bestellingen = new List<Bestelling>(); // Lijst van Alle bestelling (moet nog testdata toevoegen)
bestellingen.Add(bestelling1);
bestellingen.Add(bestelling2);
bestellingen.Add(bestelling3);
bestellingen.Add(bestelling4);
bestellingen.Add(bestelling5);

foreach (Bestelling bestelling in bestellingen) // Alle bestellingen van iedereen
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