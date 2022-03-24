using Periodos_AtrasConsoleApp;
using System;

namespace Periodos_Atras.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Data dataAtual = new Data();
            dataAtual.data = DateTime.Now;

         

            Data dataInserida = new Data();
            dataInserida.cadastrarData();

            TimeSpan diasIntervalo = dataAtual.data - dataInserida.data;
            int mesIntervalo = DateTime.Now.Month - dataInserida.data.Month;
            int anoIntervalo = DateTime.Now.Year - dataInserida.data.Year;




            //Condicionais

            Console.Clear();

           


            if (diasIntervalo.Days == 1)
            {
                Console.WriteLine("Um dia Atrás");
            }else 

            if (diasIntervalo.Days > 1 && diasIntervalo.Days < 7)
            {
                Console.Write(diasIntervalo.Days + " dias atrás");

            }
            else if (diasIntervalo.Days > 7 && diasIntervalo.Days < 14)
            {

                Console.WriteLine(" Uma semana atrás");

            }
            else if (diasIntervalo.Days >= 14 && diasIntervalo.Days < 21)
            {
                Console.WriteLine("Duas semanas atrás");

            }
            else if (diasIntervalo.Days >= 21 && diasIntervalo.Days < 28)
            {
                Console.WriteLine("Três semanas atrás");

            }
            else if (diasIntervalo.Days >= 28 && diasIntervalo.Days < 30)
            {
                Console.WriteLine("Um mês atrás");

            }
            else if (mesIntervalo == 2)
            {
                Console.WriteLine("Dois meses atrás");
            }else
            {
                Console.WriteLine("Ainda não programei essa data, foi mal..");
            }













        }


    }
}
