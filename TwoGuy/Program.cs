using System;

namespace TwoGuy
{
    class Program
    {
        static void Main(string[] args)
        {
            Guy jacek = new Guy() {cash = 50, name = "Jacek" };
            Guy bartek = new Guy() {cash = 100, name = "Bartek"};

            while (true)
            {
                jacek.WriteMyInfo();
                bartek.WriteMyInfo();

                Console.Write("Podaj kwotę: ");
                string howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if (int.TryParse(howMuch, out int amount))
                {
                    Console.WriteLine("Pieniądze ma przekazać ");
                    string whichGuy = Console.ReadLine();
                    if (whichGuy == "Jacek")
                    {
                        jacek.GiveCash(amount);
                        bartek.ReceiveCash(amount);
                        Console.WriteLine("osobie {0} ma {1} zł", jacek.name, jacek.cash);
                        Console.WriteLine("osobie {0} ma {1} zł", bartek.name, bartek.cash);
                    }
                    else if (whichGuy == "Bartek")
                    {
                        bartek.GiveCash(amount);
                        jacek.ReceiveCash(amount);
                        Console.WriteLine("osobie {0} ma {1} zł", jacek.name, jacek.cash);
                        Console.WriteLine("osobie {0} ma {1} zł", bartek.name, bartek.cash);
                    }
                    else
                    {
                        Console.WriteLine("Wpisz kwotę (lub pusty wiersz aby zakończyć)");
                    }
                }
            }
            
        }
    }
}
