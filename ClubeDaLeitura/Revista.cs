using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Revista
    {
        public readonly int id;
        private Caixa caixa;
        private string tipoColecao;
        private int edicao, ano;
        public Revista(string tipoColecao, int edicao, int ano, int id, Caixa caixa)
        {
            this.tipoColecao = tipoColecao;
            this.edicao = edicao;
            this.ano = ano;
            this.caixa = caixa;
            this.id = id;
        } 
        public string[] ToString()
        {
            return new string[]{id.ToString(), tipoColecao, edicao.ToString(), ano.ToString(),
                caixa.id.ToString(), caixa.etiqueta};
        }
    }    
}
