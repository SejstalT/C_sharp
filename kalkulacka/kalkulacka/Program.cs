Console.WriteLine("výtejte v kalkulačce!");
Console.WriteLine("Zadej první číslo: ");
string scislo1 = Console.ReadLine();
Console.WriteLine("Zadej druhé číslo :");
string scislo2 = Console.ReadLine();

float fcislo1 = float.Parse(scislo1);
float fcislo2 = float.Parse(scislo2);

float vysledek;
vysledek = fcislo1 + fcislo2;
Console.WriteLine("výsledek součtu je : " + vysledek);
vysledek = fcislo1 - fcislo2;
Console.WriteLine("výsledek rozdílu je : " + vysledek);
vysledek = fcislo1 * fcislo2;
Console.WriteLine("výsledek součinu je : " + vysledek);
vysledek = fcislo1 / fcislo2;
Console.WriteLine("výsledek podílu je : " + vysledek);

Console.WriteLine("Aplikaci ukončíte libovolným tlačítkem.");
Console.ReadLine();