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

            db.Produtos.Add(new Produto
            {
                Nome = "Smartphone",
                Preco = 2000,
                DataCadastro = DateTime.Today
            });

            db.SaveChanges();
        }
    }
}
