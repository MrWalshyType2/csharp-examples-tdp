using Examples.ConsoleAppExample.Controllers;
using Examples.ConsoleAppExample.Menus;
using Examples.ConsoleAppExample.Repositories;
using Examples.ConsoleAppExample.Services;
using Examples.Utils;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Reflection;

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
            ItemMenu menu = new ItemMenu(
                new ItemController(
                    new ItemService(
                        new ItemRepository(MySqlUtils.GetConnection()))));
            menu.InteractiveLoop();


            //MySqlConnection connection = MySqlUtils.GetConnection();

            // opens the connection with the db
            //connection.Open();

            //MySqlUtils.RunSchema(Environment.CurrentDirectory + @"\static\schema.sql", connection);

            // closes the connection with the db
            //connection.Close();
        }
    }
}
