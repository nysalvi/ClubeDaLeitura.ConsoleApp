using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class CategoriaMenu
    {
        List<Categoria> categorias;
        int id = 0;
        public CategoriaMenu()
        {
            categorias = new List<Categoria>();
        }
        public bool Menu()
        {
            int numero;
            string input;
            Console.WriteLine("Digite 1 Para Adicionar uma Categoria : ");
            Console.WriteLine("Digite 2 Para Editar uma Categoria : ");
            Console.WriteLine("Digite 3 Para Excluir uma Categoria : ");
            Console.WriteLine("Digite 4 Para Visualizar uma Categoria : ");
            Console.WriteLine("\tDigite quit - Para Sair");
            input = Console.ReadLine();
            if (input == "quit")
                return false;
            int.TryParse(input, out numero);
            if (numero == 1)
                AdicionarCategoria();
            else if (numero == 2)
                EditarCategoria();
            else if (numero == 3)
                ExcluirCategoria();
            else if (numero == 4)
                VisualizarCategoria();
            return true;
        }
        public void AdicionarCategoria()
        {
            string input, nome;
            int dias;
            Console.WriteLine("Digite o Nome Da Categoria : ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite Os Dias Da Categoria : ");
            input = Console.ReadLine();
            id++;
            int.TryParse(input, out dias);
            categorias.Add(new Categoria(dias, id));
        }
        public  void EditarCategoria()
        {
            Console.WriteLine();
        }
        public void ExcluirCategoria()
        {
            Console.WriteLine();
        }
        public void VisualizarCategoria()
        {
            categorias.ForEach(x => { Console.WriteLine("\t ID {0} - Nome : {1} | Dias : {2}" +
            "\n\t Revistas : {3} ", x.ToString());
            });
        }
        public Categoria GetCategoria(int idCategoria)
        {
            foreach (Categoria c in categorias)
            {
                if (c.id == idCategoria)
                    return c;
            }
            return null;
        }
        public Revista GetCategoria(Revista revista)
        {
            foreach (Categoria c in categorias)
            {
                foreach (Revista r in c.revistas)
                {
                    if (r == revista)
                        return r;
                }                      
            }
            return null;
        }
    }
}
