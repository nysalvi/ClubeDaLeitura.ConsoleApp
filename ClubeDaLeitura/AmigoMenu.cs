using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class AmigoMenu
    {
        public List<Amigo> amigos;
        int id = 0;
        public AmigoMenu()
        {
            this.amigos = new List<Amigo>();
        }
        public bool Menu() {
            string input;
            int numero;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDigite 1 - Para Adicionar Um Amigo");
            Console.WriteLine("\tDigite 2 - Para Editar Um Amigo");
            Console.WriteLine("\tDigite 3 - Para Excluir Um Amigo");
            Console.WriteLine("\tDigite 4 - Para Visualizar Um Amigo");
            Console.WriteLine("\tDigite quit - Para Sair");
            input = Console.ReadLine();
            if (input == "quit")
                return false;
            int.TryParse(input, out numero);
            if (numero == 1)
                AdicionarAmigo();
            if (numero == 2)
                EditarAmigo();
            if (numero == 3)
                RemoverAmigo();
            if (numero == 4)
                VisualizarAmigo();

            Console.ReadLine();
            Console.Clear();
            return true;
        }
        public void AdicionarAmigo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string nome, responsavel, telefone, endereco;
            string input;

            Console.WriteLine("Digite o nome do Amigo : ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o nome do Responsável do Amigo: ");
            responsavel = Console.ReadLine();
            Console.WriteLine("Digite o telefone do Amigo : ");
            telefone = Console.ReadLine();
            Console.WriteLine("Digite o Endereço do Amigo : ");
            endereco = Console.ReadLine();
            id++;
            Amigo amigo = new Amigo(nome, responsavel, telefone, endereco, id);
            amigos.Add(amigo);
        }
        public void RemoverAmigo()
        {

        }
        public void EditarAmigo()
        {

        }
        public void VisualizarAmigo() {
            amigos.ForEach(x => Console.WriteLine("\tID {0} - Nome : {1} | Responsável : {2} | " +
                "Telefone : {3} | Endereço : {4}", x.ToString()));
        }
        public Amigo GetAmigo(int idAmigo)
        {
            Amigo amigo = null;
            foreach (Amigo a in amigos)
            {
                if (a.id == idAmigo)
                {
                    amigo = a;
                    break;
                }
            }
            return amigo;
        }
    }
}
