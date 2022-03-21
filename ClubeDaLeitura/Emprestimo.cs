using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Emprestimo
    {
        private Amigo amigo;
        private Revista revista;
        private DateTime emprestimo, devolucao;
        private bool status;
        private int id;
        public Emprestimo(Amigo amigo, Revista revista, DateTime emprestimo, DateTime devolucao, int id)
        {
            this.amigo = amigo;
            this.revista = revista;
            this.emprestimo = emprestimo;
            this.devolucao = devolucao;
            this.status = true;
            this.id = id;
        }
        public DateTime GetEmprestimo()
        {
            return this.emprestimo;
        }   
        public bool EmAberto()
        {
            return status;
        }
        public Amigo GetAmigo()
        {
            return amigo;
        }
        public DateTime GetDevolucao()
        {
            return devolucao;
        }
        public void MudarStatus(bool status)
        {
            this.status = status;
        }
        public string[] ToString()
        {
            return new string[] {id.ToString(), amigo.id.ToString(), revista.id.ToString(), 
                emprestimo.ToString(), devolucao.ToString()};
        }
    }
}
