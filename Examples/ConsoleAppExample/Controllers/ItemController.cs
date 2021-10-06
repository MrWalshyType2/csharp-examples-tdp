﻿using Examples.ConsoleAppExample.Data.Model;
using Examples.ConsoleAppExample.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ConsoleAppExample.Controllers
{
    class ItemController
    {

        private readonly ItemService itemService;

        public ItemController(ItemService itemService)
        {
            this.itemService = itemService;
        }

        internal void Create()
        {
            Console.WriteLine("What is the name of the item?");
            Console.Write("> ");
            string itemName = Console.ReadLine();

            Item toCreate = new Item() { Name = itemName };

            Item newItem = itemService.Create(toCreate);
            Console.WriteLine($"New item created: {newItem}");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        internal void Read()
        {
            IEnumerable<Item> itemsInDb = itemService.Read();
            
            foreach (var item in itemsInDb)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        internal void Delete()
        {
            Console.WriteLine("Enter item id");
            Console.Write("> ");
            string input = Console.ReadLine();
            bool b = int.TryParse(input, out int id);

            if (b)
            {
                itemService.Delete(id); 
            }
        }
    }
}
