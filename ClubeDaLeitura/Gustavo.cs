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
        RevistaMenu revistaMenu;
        EmprestimoMenu emprestimoMenu;
        ReservaMenu reservaMenu;
        CategoriaMenu categoriaMenu;
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
            categoriaMenu = new CategoriaMenu();
            revistaMenu = new RevistaMenu(caixaMenu, categoriaMenu);
            reservaMenu = new ReservaMenu(emprestimoMenu, amigoMenu, revistaMenu);
            emprestimoMenu = new EmprestimoMenu(amigoMenu, revistaMenu, reservaMenu, inicio);
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
                Console.WriteLine("Digite 5 - Para Gerenciar Reserva");
                Console.WriteLine("Digite 6 - Para Gerenciar Categoria");
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
                else if (menu == 5)
                    continuar = reservaMenu.Menu();
                else if (menu == 6)
                    continuar = categoriaMenu.Menu();
                menu = 0;
            }
        }
    }
}

