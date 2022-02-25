using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoGuy
{
    class Guy
    {
        public string name;
        public int cash;

        ///<summary>
        ///Wyświetla w konsoli imie i posiadaną kwotę.
        ///</summary>
        public void WriteMyInfo()
        {
            Console.WriteLine("{0} ma {1} zł", name, cash);
        }

        ///<summary>
        ///Przekazuje pieniądze i usuwa je z portfela (lub wyświetk
        ///w konsoli komunikat o braku środków).
        ///</summary>
        ///<param name="amount">Przekazana kwota.</param>
        ///<returns>
        ///Ilość pieniędzy wyjmowanych z portfela lub 0, jeśli dostępne
        ///środki są za małe (lub parametr amount jest nieprawidłowy).
        ///</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("{0} mówi: {1} nie jest właściwą kwotą", name, cash);
                return 0;
            }
            if (amount > cash)
            {
                Console.WriteLine("{0} mówi: nie mam wystarczających środków, aby dać Ci {1} zł", name, amount);
                return 0;
            }
            cash -= amount;
            return amount;
        }

        /// <summary>
        /// Przyjmuje pieniądze i dodaje je do porfela (lub wyświetla
        /// w konsoli komunikat o nieprawidłowej kwocie).
        /// </summary>
        /// <param name="amount">Przyjmowana kwota.</param>
        public void ReceiveCash(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("{0} mówi: nie przyjmę {1} zł", name, amount);
            }
            else
            {
                cash += amount;
            }

        }
    }
}
