using Examples.ConsoleAppExample.Controllers;
using Examples.ConsoleAppExample.Menus;
using Examples.ConsoleAppExample.Repositories;
using Examples.ConsoleAppExample.Services;
using Examples.Utils;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Reflection;
using Examples.Extensions;
using Examples.ConsoleAppExample.Data.Repositories;
using Examples.ConsoleAppExample.Data.Model;

namespace Examples
{
    class Program
    {
        // To include other resources:
        // - Right click file
        // - set Build Action to Content
        // - set Copy to Output Directory as Copy Always
        // string f2 = File.ReadAllText(Environment.CurrentDirectory + @"\static\test.txt");

        static void Main(string[] args)
        {
            // using statements expand to a try-finally statement that auto disposes
            // of types that implement IDisposable
            /*try
            {
                using MySqlConnection connection = MySqlUtils.GetConnection();

                ItemMenu menu = new ItemMenu(
                new ItemController(
                    new ItemService(
                        new ItemRepository(connection))));
                menu.InteractiveLoop();
            }
            catch (MySqlException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Cannot connect to server.");
            }

            Console.ReadKey();*/

            string s = "Hello world";
            s.Write(); // this extension method is only scope when the namespace is imported
            ICrdRepository<Item, int> repo = new ItemRepository(MySqlUtils.GetConnection());
            repo.ReadById(32);
        }

    }
}
