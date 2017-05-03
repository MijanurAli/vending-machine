using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpPractice
{
    class DrinkMachine
    {
        const int COST_OF_DRINK = 150;
        public int runningTotal { get; set; }

        public DrinkMachine()
        {
            runningTotal = 0;
        }

        public void depositCoin(int money)
        {
            //Only valid entries are 5, 10, 25, and 100
            switch(money)
            {
                case (5):
                    runningTotal += 5;
                    break;
                case (10):
                    runningTotal += 10;
                    break;
                case (25):
                    runningTotal += 25;
                    break;
                case (100):
                    runningTotal += 100;
                    break;
                default:
                    Console.WriteLine("Invalid Entry!");
                    break;
            }
        }

        public bool checkTotal()
        {
            if (runningTotal >= COST_OF_DRINK)
                return true;
            else
                return false;
        }

        public void displayDrinkMenu()
        {
            Console.WriteLine("********************");
            Console.WriteLine("* C - Coke         *");
            Console.WriteLine("* P - Pepsi        *");
            Console.WriteLine("* S - Sprite       *");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("Please make a selection: ");

            makeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void makeDrinkSelection(char selection)
        {
            bool validSelection = false;
            while (!validSelection)
            {
                switch (selection)
                {
                    case ('C'):
                        Console.WriteLine("Thank you for choosing Coke!");
                        returnChange();
                        validSelection = true;
                        break;
                    case ('P'):
                        Console.WriteLine("Thank you for choosing Pepsi!");
                        returnChange();
                        validSelection = true;
                        break;
                    case ('S'):
                        Console.WriteLine("Thank you for choosing Sprite!");
                        returnChange();
                        validSelection = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice; please re-enter your selection: ");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        validSelection = false;
                        break;
                }
            }
        }

        private void returnChange()
        {
            if (runningTotal > COST_OF_DRINK)
            {
                Console.WriteLine("Your change is {0:C}", runningTotal - COST_OF_DRINK);
            }
        }
    }
}
