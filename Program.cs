using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            var drinkMachine = new DrinkMachine();

            while (!drinkMachine.checkTotal())
            {
                Console.WriteLine("Please deposit money for a drink: (5, 10, 25, 100)");
                drinkMachine.depositCoin(Convert.ToInt32(Console.ReadLine()));
                drinkMachine.displayDrinkMenu();
            }
        }
    }
}
