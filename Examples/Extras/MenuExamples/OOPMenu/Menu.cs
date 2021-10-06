using Examples.ConsoleAppExample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Examples.ConsoleAppExample.Menus.ItemMenu;

namespace Examples.Extras.MenuExamples.OOPMenu
{
    // T is the enum
    // C is the controller
    abstract class Menu<T, C> where T : Enum
    {
        protected readonly C controller;

        public Menu(C controller)
        {
            this.controller = controller;
        }

        public virtual void PrintMenu()
        {
            Array values = Enum.GetValues(typeof(T));

            Console.WriteLine("=== MENU ===");
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("=== ==== ===");
        }

        public abstract void InteractiveLoop();
    }

    class MenuImplementation : Menu<MenuOptions, ItemController>
    {
        public MenuImplementation(ItemController controller) : base(controller)
        {
        }

        public override void InteractiveLoop()
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
                        controller.Create();
                        break;
                    case MenuOptions.READ:
                        controller.Read();
                        break;
                    case MenuOptions.DELETE:
                        controller.Delete();
                        break;
                    case MenuOptions.QUIT:
                        inMenu = false;
                        break;
                }
            }
        }
    }
}
