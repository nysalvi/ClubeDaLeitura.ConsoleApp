using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Categoria
    {
        public List<Revista> revistas;
        private string nome;
        private int dias;
        public readonly int id;
        public Categoria(int dias, int id)
        {
            this.dias = dias;
            this.id = id;
            revistas = new List<Revista>();
        }
        public int GetDias()
        {
            return dias;
        }
        public string[] ToString()
        {
            return new string[]{id.ToString(), nome, dias.ToString(), revistas.ToString()};
        }
    }
}
