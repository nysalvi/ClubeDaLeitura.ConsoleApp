using System;

namespace ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gustavo gustavo = new Gustavo(DateTime.Parse("13/11/2017"));
            gustavo.Menu();
        }        
    }
}
