using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.ConsoleAppExample.Data.Repositories
{
    // T would be the type of data being stored
    // U would be the type of the id on the model
    public interface ICrdRepository<T, U>
    {
        T Create(T t);
        public IList<T> Read();
        //T ReadyById(U u);
        public void Delete(U u);
        bool Exists(U u);
    }
}
