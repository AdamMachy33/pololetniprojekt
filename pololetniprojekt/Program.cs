
using pololetniprojekt;

Random generátor = new Random();
Hra hráči = new Hra();
string[] knp = { "kámen", "papír", "nůžky" };

while (true)
{
reset:
    int náhodněPočítač = generátor.Next(0, 3);
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine($"Tvoje scóre: {hráči.já}");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Počítač scóre {hráči.počítač}");
    Console.ResetColor();
    Console.WriteLine($"1. Kámen\n2. Papír\n3. Nůžky");
    int volba = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (volba > 3)
    {
        Console.WriteLine("neplatná volba ");
        goto reset;
    }
    if (knp[náhodněPočítač] == "papír" && knp[volba - 1] == "kámen")
    {
        hráči.počítač++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nProhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (knp[náhodněPočítač] == "nůžky" && knp[volba - 1] == "kámen")
    {
        hráči.já++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nVyhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (knp[náhodněPočítač] == "nůžky" && knp[volba - 1] == "papír")
    {
        hráči.počítač++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nProhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (knp[náhodněPočítač] == "kámen" && knp[volba - 1] == "papír")
    {
        hráči.já++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nVyhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (knp[náhodněPočítač] == "kámen" && knp[volba - 1] == "nůžky")
    {
        hráči.počítač++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nProhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else if (knp[náhodněPočítač] == "papír" && knp[volba - 1] == "nůžky")
    {
        hráči.já++;
        Console.WriteLine($"Vybral jsi {knp[volba - 1]}\nPočítač vybral {knp[náhodněPočítač]}\nVyhrál jsi tohle kolo");
        Thread.Sleep(2500);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"Oba jste si vybrali {knp[volba - 1]}");
        Thread.Sleep(2000);
        Console.Clear();
    }
    if (hráči.já >= 5 || hráči.počítač >= 5)
    {
        break;
    }
}
if (hráči.já > hráči.počítač)
{
    Console.WriteLine("Vyhrál jsi");
}
else
{
    Console.WriteLine("Prohrál jsi");
}