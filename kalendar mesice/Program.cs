// See https://aka.ms/new-console-template for more information
DateTime cas = DateTime.Now;
int gingerMonster = cas.Month;
string[] pole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Zaří", "Říjen", "Listopad", "Prosinec" };


Console.WriteLine($"Teď je: {pole[gingerMonster - 1]}, další měsíc: {pole[gingerMonster]}, předchozí měsíc: {pole[gingerMonster - 2]}");
Console.WriteLine("Napiš číslo měsíce (1-12)");


int mesic = Convert.ToInt32(Console.ReadLine());
int downgrade = mesic = 1;
int upgrade = mesic + 1;


if (mesic >= 2 && mesic <= 11)
{
    Console.WriteLine($"Teď je: {pole[mesic - 1]}, další měsíc: {pole[upgrade - 1]}, předchozí měsíc: {pole[upgrade - 1]} (zmačni ENTER pro všechny měsíce)");
    Console.ReadLine();
}
else if (mesic == 1)
{
    Console.WriteLine($"Teď je: {pole[0]}, další měsíc: {pole[1]}, předchozí měsíc: {pole[11]} (zmačni ENTER pro všechny měsíce)");
    Console.ReadLine();
}
else if (mesic == 12)
{
    Console.WriteLine($"Teď je: {pole[11]}, další měsíc: {pole[0]}, předchozí měsíc: {pole[10]} (zmačni ENTER pro všechny měsíce)");
    Console.ReadLine();
}
Console.WriteLine("Vypsat všechny měsíce, Y/N?");
string rehabMonster = Console.ReadLine();
if (rehabMonster == "Y")
{
    foreach (string fialovejMonster in pole)
    {
        Console.WriteLine(fialovejMonster);
        
    }
}
else if (rehabMonster == "N")
{
    Console.WriteLine("černochu tak proč jsi mačkal ENTER?");
    Console.ReadLine();
    System.Environment.Exit(0);
}
