using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura
{
    internal class Reserva
    {
        private Amigo amigo;
        private Revista revista;
        private DateTime reserva, devolucao;
        private bool status;
        public readonly int id;
        public Reserva(Amigo amigo, Revista revista, DateTime reserva, int id)
        {
            this.amigo = amigo;
            this.revista = revista;
            this.reserva = reserva;
            this.devolucao = reserva.AddDays(2);
            this.status = true;
            this.id = id;
        }
        public bool EmAberto()
        {
            return status;
        }
        public Revista GetRevista()
        {
            return revista;
        }
        public bool ChecarValidez(DateTime? dataAtual)
        {
            if (dataAtual == null)
                return false;
            else if (dataAtual > devolucao && EmAberto())
                return false;
            else
                return true;
        }
        public void MudarStatus(bool status)
        {
            this.status = status;
        }
        public string[] ToString()
        {
            return new string[] {id.ToString(), amigo.id.ToString(), revista.id.ToString(),
                reserva.ToString(), devolucao.ToString()};
        }
    }
}
