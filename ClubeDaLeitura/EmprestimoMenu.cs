﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class EmprestimoMenu
    {
        public List<Emprestimo> emprestimos;
        AmigoMenu amigos;
        RevistaMenu revistas;
        int id = 0;
        DateTime inicio;
        public EmprestimoMenu(AmigoMenu amigos, RevistaMenu revistas, DateTime inicio)
        {
            this.amigos = amigos;
            this.revistas = revistas;
            this.inicio = inicio;
            this.emprestimos = new List<Emprestimo>();
        }
        public bool Menu(){
            string opcao;
            int numero;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDigite 1 - Para Adicionar Um Emprestimo");
            Console.WriteLine("\tDigite 2 - Para Editar Um Emprestimo");
            Console.WriteLine("\tDigite 3 - Para Excluir Um Emprestimo");
            Console.WriteLine("\tDigite 4 - Para Visualizar Um Emprestimo");
            Console.WriteLine("\tDigite 5 - Para Verificar Os Emprestimos Criados no Mês");
            Console.WriteLine("\tDigite 6 - Para Verificar Os Emprestimos Em Aberto Em Um Dia");
            Console.WriteLine("\tDigite quit - Para Sair");
            opcao = Console.ReadLine();
            if (opcao == "quit")
                return false;
            int.TryParse(opcao, out numero);
            if (numero == 1)
                AdicionarEmprestimo();
            else if (numero == 2)
                EditarEmprestimo();
            else if (numero == 3)
                ExcluirEmprestimo();
            else if (numero == 4)
                VisualizarEmprestimo();
            else if (numero == 5)
                VerificaMes();
            else if (numero == 6)
                VerificaDia();
            Console.ReadLine();
            Console.Clear();
            return true;
        }
        public void AdicionarEmprestimo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int idAmigo, idRevista;
            Amigo amigo = null;
            Revista revista = null;
            DateTime emprestimo, devolucao;
            string input;

            Console.WriteLine("Digite a ID do Amigo que fez o empréstimo : ");
                input = Console.ReadLine();
                int.TryParse(input, out idAmigo);
            Console.WriteLine("Digite a ID da revista emprestada : ");
                input = Console.ReadLine();
                int.TryParse(input, out idRevista);
            Console.WriteLine("Digite a Data do Empréstimo : ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out emprestimo);
            Console.WriteLine("Digite a Data de Devolução : ");
                input = Console.ReadLine();
                DateTime.TryParse(input, out devolucao);

            revista = revistas.GetRevista(idRevista);
            amigo = amigos.GetAmigo(idAmigo);
            id++;
            Emprestimo e = new Emprestimo(amigo, revista, emprestimo, devolucao, id);
            emprestimos.Add(e);
        }
        public void ExcluirEmprestimo()
        {

        }
        public void EditarEmprestimo()
        {

        }
        public void VisualizarEmprestimo()
        {
            emprestimos.ForEach(x => { Console.WriteLine("\t ID {0} - Amigo : {1} | Revista : {2}" +
                " | Data Empréstimo : {3} | Devolução : {4}", x.ToString());});
        }
        public void VerificaMes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            DateTime mes;
            Console.WriteLine("Digite o mês que deseja verificar : ");
            DateTime.TryParse(Console.ReadLine(), out mes);

            if (mes < inicio)
                return;
            else
            {
                List<Emprestimo> empresta = new List<Emprestimo>();
                emprestimos.ForEach(e => {
                    if ((e.GetEmprestimo().Month, e.GetEmprestimo().Year) == (mes.Month, mes.Year))
                        empresta.Add(e);
                });
                empresta.ForEach(x => {
                    Console.WriteLine("\t ID {0} - Amigo : {1} | Revista : {2}" +
                        " | Data Empréstimo : {3} | Devolução : {4}", x.ToString());
                });
            }
        }
        public void VerificaDia()
        {
            DateTime dia;
            Console.WriteLine("Digite o dia que deseja verificar : ");
            DateTime.TryParse(Console.ReadLine(), out dia);
            if (dia < inicio)
                return;
            else
            {
                List<Emprestimo> empresta = new List<Emprestimo>();
                emprestimos.ForEach(e => {
                    if (e.GetEmprestimo() == dia && e.emAberto())
                        empresta.Add(e);
                });
                empresta.ForEach(x => {
                    Console.WriteLine("\t ID {0} - Amigo : {1} | Revista : {2}" +
                        " | Data Empréstimo : {3} | Devolução : {4}", x.ToString());
                });                
            }
        }
    }
}
