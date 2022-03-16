using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Caixa
    {
        private Revista[] revistas;
        public readonly int id;
        private int contador;
        public string cor, etiqueta;
        private int numero;
        public Caixa(string cor, string etiqueta, int numero, int id)
        {
            this.revistas = new Revista[15];
            this.cor = cor;
            this.etiqueta = etiqueta;
            this.numero = numero;
            this.id = id;
        }
        public string[] ToString()            
        {
            return new string[] { id.ToString(), cor, etiqueta, numero.ToString() } ;
        }
        public int Numero()
        { return this.numero; }
        public bool estaCheia()
        {
            if (contador == revistas.Length - 1)
                return true;
            else
                return false;
        }
        /*public bool adicionarRevista(string tipoColecao, int edicao, int ano, int id)
        {
            if (this != null && !this.estaCheia())
            {
                revistas[contador] = new Revista(tipoColecao, edicao, ano, id, this);
                contador++;
                return true;
            }
            return false;            
        }*/
        public bool adicionarRevista(Revista revista)
        {
            if (revista != null)
            {
                revistas[contador] = revista;
                contador++;
                return true;
            }
            return false;
        }
        public Revista[] Visualizar() 
            {return this.revistas;}

    }
}
