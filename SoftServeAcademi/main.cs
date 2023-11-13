using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Slava Ukranjini!");

        Thread.Sleep(3000);
        Console.Clear();
        Thread.Sleep(1000);

        Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░█░░░░░█░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░_░░░░░_░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░█░░░░░█░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░_░░░░░_░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
        Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
        Console.WriteLine("────█░░█░░░░░█░░█────");
        Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
        Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        Thread.Sleep(1000);
        Console.Clear();

        Console.WriteLine("Is bear sleeping?");
        string userInput = Console.ReadLine();

        if (userInput == "y" || userInput == "Y")
        {
            Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
            Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
            Console.WriteLine("────█░░_░░░░░_░░█────");
            Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
            Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        }
        else if (userInput == "n" || userInput == "N")
        {
            Console.WriteLine("-──▄▀▀▀▄▄▄▄▄▄▄▀▀▀▄───");
            Console.WriteLine("───█▒▒░░░░░░░░░▒▒█───");
            Console.WriteLine("────█░░█░░░░░█░░█────");
            Console.WriteLine("─▄▄──█░░░▀█▀░░░█──▄▄─");
            Console.WriteLine("█░░█─▀▄░░░░░░░▄▀─█░░█");
        }
        int value = int.Parse(Console.ReadLine());
        for (int i = 0; i < value; ++i)
        {
            Console.WriteLine($"Iteration {i + 1}");
        }
    }
}