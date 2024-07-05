using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Switch
    {
        static void Main()
        {
            Console.WriteLine("1: Burger\n2: CocoCola\n3: Salad\n4: French Fries\n5: Softy\n6: Veg Pizza\n7: Paneer Pizza\n8: Cheese Pizza");
            Console.Write("Select any one food number to know price: ");
            int UserFoodChoice = Convert.ToInt32(Console.ReadLine());
            switch (UserFoodChoice)
            {
                case 1:
                    Console.WriteLine("\nBurger only for RS49");
                    break;
                case 2:
                    Console.WriteLine("\nBurger only for RS19");
                    break;
                case 32:
                    Console.WriteLine("\nSalad only for RS49");
                    break;
                case 4:
                    Console.WriteLine("\nFrench Fries only for RS79");
                    break;
                case 5:
                    Console.WriteLine("\nSofty only for RS15");
                    break;
                case 6:
                    Console.WriteLine("\nVeg Pizza only for RS99");
                    break;
                case 7:
                    Console.WriteLine("\nPaneer Pizza only for RS119");
                    break;
                case 8:
                    Console.WriteLine("\nCheese Pizza only for RS129");
                    break;
                default:
                    Console.WriteLine("\nPlease enter valid food number!");
                    break;
            }
        }
    }
}
