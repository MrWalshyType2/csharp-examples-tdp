using Examples.ConsoleAppExample.Data.Model;
using Examples.ConsoleAppExample.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Examples.ConsoleAppExample.Repositories
{
    internal class ItemRepository : ICrdRepository<Item, int>
    {
        private IList<Item> items;
        private static int counter = 0;

        public ItemRepository()
        {
            items = new List<Item>();
        }

        public Item Create(Item toCreate)
        {
            toCreate.ID = counter;
            counter++;
            items.Add(toCreate);

            return toCreate;
        }

        public IList<Item> Read()
        {
            return items;
        }

        public void Delete(int id)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].ID == id)
                {
                    items.RemoveAt(i);
                    break;
                }
            }
        }
    }
}