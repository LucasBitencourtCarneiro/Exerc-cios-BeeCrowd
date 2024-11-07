using System;

namespace uri1046
{
    class Program
    {
        static void Main(string[] args)
        {

            int horaInicio, horaFim,total,horaMaxima;

            string[] valores = Console.ReadLine().Split(' ');

            horaInicio = int.Parse(valores[0]);
            horaFim = int.Parse(valores[1]);

            if (horaInicio < horaFim)
            {
                total = horaFim - horaInicio;

            }
            else { 
             total = 24 - horaInicio + horaFim;
            }
            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}
