using Examples.ConsoleAppExample.Data.Model;
using Examples.ConsoleAppExample.Data.Repositories;
using Examples.ConsoleAppExample.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ConsoleAppExample.Services
{
    class ItemService
    {

        private readonly ICrdRepository<Item, int> itemRepository;

        public ItemService(ICrdRepository<Item, int> itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        internal Item Create(Item toCreate)
        {
            Item newItem = itemRepository.Create(toCreate);
            return newItem;
        }

        internal IEnumerable<Item> Read()
        {
            return itemRepository.Read();
        }

        internal void Delete(int id)
        {
            itemRepository.Delete(id);
        }
    }
}
