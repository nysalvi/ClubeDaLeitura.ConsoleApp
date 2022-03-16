using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Gustavo
    {
        AmigoMenu amigoMenu;
        CaixaMenu caixaMenu;
        EmprestimoMenu emprestimoMenu;
        RevistaMenu revistaMenu;

        //List<Emprestimo> emprestimos;
        //List<Amigo> amigos;
        //List<Caixa> caixas;
        DateTime inicio;
        //List<Revista> revistas;
        public Gustavo(DateTime inicio)
        {
            this.inicio = inicio;

            amigoMenu = new AmigoMenu();
            caixaMenu = new CaixaMenu();
            revistaMenu = new RevistaMenu(caixaMenu);
            emprestimoMenu = new EmprestimoMenu(amigoMenu, revistaMenu);
        }
        public List<Emprestimo> VerificaMes(DateTime mes)
        {
            if (mes < inicio)
                return null;
            else 
            {
                List<Emprestimo> empresta = new List<Emprestimo>();
                emprestimoMenu.emprestimos.ForEach(e => { 
                    if ((e.GetEmprestimo().Month, e.GetEmprestimo().Year) == (mes.Month, mes.Year))
                        empresta.Add(e);                                            
                });
                return empresta;
            }
        }
        public List<Emprestimo> VerificaDia(DateTime dia)
        {
            if (dia < inicio)
                return null;
            else
            {
                List<Emprestimo> empresta = new List<Emprestimo>();
                emprestimoMenu.emprestimos.ForEach(e => {
                    if (e.GetEmprestimo() == dia && e.emAberto())
                        empresta.Add(e);
                });
                return empresta;
            }
        }
        public void Menu()
        {
            int menu;
            string opcao;
            bool continuar = true;
            while (continuar)
            {
                Console.ResetColor();
                Console.WriteLine("Digite 1 - Para Gerenciar Amigo");
                Console.WriteLine("Digite 2 - Para Gerenciar Emprestimo");
                Console.WriteLine("Digite 3 - Para Gerenciar Caixa");
                Console.WriteLine("Digite 4 - Para Gerenciar Revista");
                Console.WriteLine("Digite quit - Para Sair");
                opcao = Console.ReadLine();
                if (opcao == "quit")
                    break;
                int.TryParse(opcao, out menu);
                Console.Clear();
                if (menu == 1)
                    continuar = amigoMenu.Menu();
                else if (menu == 2)
                    continuar = emprestimoMenu.Menu();
                else if (menu == 3)
                    continuar = caixaMenu.Menu();
                else if (menu == 4)
                    continuar = revistaMenu.Menu();
                menu = 0;
            }
        }
    }
}

