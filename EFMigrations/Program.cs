using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrations
{
    class Program
    {
        static void Main(string[] args)
        {
            LojaContext db = new LojaContext();

            db.Clientes.ToList().ForEach(c => Console.WriteLine(c.Nome));

            db.SaveChanges();
        }
    }
}
