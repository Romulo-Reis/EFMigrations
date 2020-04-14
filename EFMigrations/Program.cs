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
            Cliente cliente = new Cliente
            {
                Nome = "Maria",
                CPF = "111122233344",
                TelefoneContato = "77776666",
                Email = "maria@email.com.br"
            };
            db.Clientes.Add(cliente);
            db.SaveChanges();
        }
    }
}
