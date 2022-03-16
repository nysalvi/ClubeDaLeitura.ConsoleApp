using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class RevistaMenu
    {
        public List<Revista> revistas;
        int id = 0;
        CaixaMenu caixas;
        public RevistaMenu(CaixaMenu caixas)
        {
            this.revistas = new List<Revista>();
            this.caixas = caixas;
        } 
        public bool Menu()
        {
            int numero;
            string input;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDigite 1 - Para Adicionar Um Revista");
            Console.WriteLine("\tDigite 2 - Para Editar Um Revista");
            Console.WriteLine("\tDigite 3 - Para Remover Um Revista");
            Console.WriteLine("\tDigite 4 - Para Visualizar as Revistas");
            Console.WriteLine("\tDigite quit - Para Sair");
            input = Console.ReadLine();
            if (input == "quit")
                return false;
            int.TryParse(input, out numero);
            if (numero == 1)
                AdicionarRevista();
            if (numero == 2)
                EditarRevista();
            if (numero == 3)
                RemoverRevista();
            if (numero == 4)               
                VisualizarRevista();
            
            Console.ReadLine();
            Console.Clear();
            return true;            
        }
        public bool AdicionarRevista()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Caixa caixa; string tipoColecao; int edicao, ano;
            string input;
            int idCaixa;
            Console.WriteLine("Digite a ID da Caixa para Adicionar : ");
                input = Console.ReadLine();
                int.TryParse(input, out idCaixa);
            Console.WriteLine("Digite o tipo da coleção da Revista : ");
                tipoColecao = Console.ReadLine();
            Console.WriteLine("Digite a Edição da Revista : ");
                input = Console.ReadLine();
                int.TryParse(input, out edicao);
            Console.WriteLine("Digite o Ano da Revista : ");
                input = Console.ReadLine();
                int.TryParse(input, out ano);
            caixa = caixas.GetCaixa(idCaixa);
            id++;
            Revista re = new Revista(tipoColecao, edicao, ano, id, caixa);
            revistas.Add(re);
            return caixa.adicionarRevista(re);
        }
        public void RemoverRevista()
        {

        }
        public void EditarRevista()
        {

        }
        public void VisualizarRevista()
        {
            revistas.ForEach(x => Console.WriteLine("\tID {0} - Coleção : {1} | Edição : {2} | " +
                "Ano : {3}/\t/Caixa - ID : {4} | Etiqueta : {5}",
                x.ToString()));
        }
        public Revista GetRevista(int idRevista)
        {
            Revista revista = null;
            foreach (Revista r in revistas)
            {
                if (r.id == idRevista)
                {
                    revista = r;
                    break;
                }
            }
            return revista;
        }
    }
}
