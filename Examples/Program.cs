using Examples.ConsoleAppExample.Controllers;
using Examples.ConsoleAppExample.Menus;
using Examples.ConsoleAppExample.Repositories;
using Examples.ConsoleAppExample.Services;
using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemMenu menu = new ItemMenu(
                new ItemController(
                    new ItemService(
                        new ItemRepository())));
            menu.InteractiveLoop();
        }
    }
}
