using Examples.ConsoleAppExample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ConsoleAppExample.Menus
{
    class ItemMenu
    {
        // composition is a "has-a" relationship
        private readonly ItemController itemController;

        public ItemMenu(ItemController itemController)
        {
            this.itemController = itemController;
        }

        public enum MenuOptions
        {
            CREATE, READ, DELETE, QUIT
        }

        public void PrintMenu()
        {
            Array values = Enum.GetValues(typeof(MenuOptions));

            Console.WriteLine("=== MENU ===");
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("=== ==== ===");
        }

        public void InteractiveLoop()
        {
            bool inMenu = true;

            while (inMenu)
            {
                // clear the screen
                Console.Clear();
                // print the menu
                PrintMenu();
                // get input from user
                string input = Console.ReadLine();
                // convert input to MenuOptions enum
                bool b = Enum.TryParse(input, true, out MenuOptions menuOption);

                // choose relevant option based on the input
                if (b == false)
                {
                    Console.WriteLine("Invalid input");
                    continue; // goes to next iteration of the loop
                }

                switch (menuOption)
                {
                    case MenuOptions.CREATE:
                        itemController.Create();
                        break;
                    case MenuOptions.READ:
                        itemController.Read();
                        break;
                    case MenuOptions.DELETE:
                        itemController.Delete();
                        break;
                    case MenuOptions.QUIT:
                        inMenu = false;
                        break;
                }
            }
        }
    }
}
