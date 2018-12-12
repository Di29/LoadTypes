using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LoadTypesLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = null;
            using(var context = new ShopContext())
            {
                //items = context.Items.Include(item => item.Carts)ToList(); жадная загрузка

                Guid id = Guid.Parse("6098d4be-acab-4d69-bb8d-47b6d9c74f0a");
                var result = context.Items.FirstOrDefault(i => i.Id == id);
                context.Entry(result).Collection<Cart>("Carts").Load();


                /*
                * Существует і вида загрузки:
                * 1. Ленивая (lazy loading) - virtual
                * 2. Жадная (eager loading) - include
                * 3. Явная (explicit loading) - context.Entry(result).Reference<Cart>("Carts").Load();

                */
            }
        }
    }
}
