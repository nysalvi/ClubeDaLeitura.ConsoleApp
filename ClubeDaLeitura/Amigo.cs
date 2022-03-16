using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Amigo
    {
        private string nome, nomeResponsavel, telefone, endereco;
        public readonly int id;
        public Amigo(string nome, string nomeResponsavel, string telefone, string endereco, int id)
        {
            this.nome = nome;
            this.nomeResponsavel = nomeResponsavel;
            this.telefone = telefone;
            this.endereco = endereco;
            this.id = id;
        }
        public string[] ToString()
        {
            return new string[] {id.ToString(), nome, nomeResponsavel, telefone, endereco};
        }
    }
}
