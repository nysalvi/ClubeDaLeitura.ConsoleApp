using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class ReservaMenu
    {
        List<Reserva> reservas;
        EmprestimoMenu emprestimos;
        AmigoMenu amigos;
        RevistaMenu revistas;
        int id = 0;
        public ReservaMenu(EmprestimoMenu emprestimos, AmigoMenu amigos, RevistaMenu revistas){
            this.reservas = new List<Reserva>();
            this.emprestimos = emprestimos;
            this.amigos = amigos;
            this.revistas = revistas;
        }
        public bool Menu()
        {
            int numero;
            string input;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDigite 1 - Para Adicionar Uma Reserva");
            Console.WriteLine("\tDigite 2 - Para Editar Uma Reserva");
            Console.WriteLine("\tDigite 3 - Para Remover Uma Reserva");
            Console.WriteLine("\tDigite 4 - Para Visualizar as Reservas");
            Console.WriteLine("\n\tDigite 5 - Para Adicionar Um Empréstimo");
            Console.WriteLine("\tDigite quit - Para Sair");
            input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (input == "quit")
                return false;
            int.TryParse(input, out numero);
            if (numero == 1)
                AdicionarReserva();
            if (numero == 2)
                EditarReserva();
            if (numero == 3)
                RemoverReserva();
            if (numero == 4)
                VisualizarReserva();
            if (numero == 5)
                emprestimos.AdicionarEmprestimo();
            Console.ReadLine();
            Console.Clear();
            return true;
        }
        public void AdicionarReserva()
        {

            int idAmigo, idRevista;
            Amigo amigo = null;
            Revista revista = null;
            DateTime emprestimo;
            string input;

            Console.WriteLine("Digite a ID do Amigo : ");
            input = Console.ReadLine();
            int.TryParse(input, out idAmigo);
            Console.WriteLine("Digite a ID da Revista");
            input = Console.ReadLine();
            int.TryParse(input, out idRevista);
            Console.WriteLine("Digite a Data da Reserva : ");
            input = Console.ReadLine();
            DateTime.TryParse(input, out emprestimo);

            amigo = amigos.GetAmigo(idAmigo);
            revista = revistas.GetRevista(idRevista);
            id++;
            Reserva r = new Reserva(amigo, revista, emprestimo, id);
            reservas.Add(r);
        }
        public void EditarReserva()
        {

        }
        public void RemoverReserva()
        {

        }
        public void VisualizarReserva()
        {
            reservas.ForEach(x => { Console.WriteLine("\t ID {0} - Amigo : {1} | Revista : {2}" +
                " | Data Empréstimo : {3} | Devolução : {4}", x.ToString());
            });
        }
        public Revista GetRevista(int idRevista)
        {
            foreach (Reserva r in reservas)
            {
                if (r.GetRevista().id == idRevista)
                    return r.GetRevista();
            }
            return null;
        }
        public Reserva ProcuraReserva(int idRevista)
        {
            foreach (Reserva r in reservas)
            {
                if (r.GetRevista().id == idRevista)
                    return r;
            }
            return null;
        }
        public bool PossuiRevista(Revista revista)
        {
            foreach (Reserva r in reservas)
            {
                if (r.GetRevista() == revista)
                    return true;
            }
            return false;
        }
        public Reserva GetReserva(int idReserva)
        {
            foreach (Reserva r in reservas)
            {
                if (r.id == idReserva)
                    return r;
            }
            return null;
        }
    }
}
