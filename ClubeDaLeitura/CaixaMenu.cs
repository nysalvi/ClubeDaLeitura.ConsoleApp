using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class CaixaMenu 
    {
        public List<Caixa> caixas;
        int id = 0;
        public CaixaMenu()
        {
            this.caixas = new List<Caixa>();
        }
        public bool Menu(){
            string opcao;
            int numero;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tDigite 1 - Para Adicionar Uma Caixa");
            Console.WriteLine("\tDigite 2 - Para Editar Uma Caixa");
            Console.WriteLine("\tDigite 3 - Para Remover Uma Caixa");
            Console.WriteLine("\tDigite 4 - Para Visualizar as Caixas");
            Console.WriteLine("\tDigite quit - Para Sair");
            opcao = Console.ReadLine();
            int.TryParse(opcao, out numero);
            if (opcao == "quit")
                return false;
            if (numero == 1)
                AdicionarCaixa();
            if (numero == 2)
                EditarCaixa();
            if (numero == 3)
                RemoverCaixa();
            if (numero == 4)
                VisualizarCaixa();
            Console.ReadLine();
            Console.Clear();
            return true;
        }
        public void AdicionarCaixa()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Caixa caixa; string cor, etiqueta; int numero;  
            string input;
            Console.WriteLine("Digite a Cor da Caixa: ");
            cor = Console.ReadLine();   
            Console.WriteLine("Digite a Etiqueta da Caixa : ");
            etiqueta = Console.ReadLine();
            Console.WriteLine("Digite o Número da Caixa : ");
            input = Console.ReadLine();
            int.TryParse(input, out numero);
            id++;
            caixa = new Caixa(cor, etiqueta, numero, id);
            caixas.Add(caixa);
        }
        public void RemoverCaixa()
        {

        }
        public void EditarCaixa()
        {

        }
        public void VisualizarCaixa()
        {
            caixas.ForEach(x => Console.WriteLine("\tID {0} - Cor : {1} | Etiqueta : {2} | " +
                "Número : {3}",
                x.ToString()));
        }
        public Caixa GetCaixa(int idCaixa)
        {
            Caixa caixa = null;
            foreach (Caixa c in caixas)
            {
                if (c.id == idCaixa)
                {
                    caixa = c;
                    break;
                }
            }
            return caixa;    
        }
        
    }
}
