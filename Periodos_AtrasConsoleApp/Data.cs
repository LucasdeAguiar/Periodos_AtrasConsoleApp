using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Periodos_AtrasConsoleApp
{
    public class Data
    {
        public DateTime data ;


        public void cadastrarData()
        {
            do
            {
                Console.WriteLine("Digite a data que deseja registrar:");
                 this.data = Convert.ToDateTime(Console.ReadLine());

                if (this.data >= DateTime.Now)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite uma data válida:");
                    Console.ReadLine();
                    Console.Clear();
                    Console.ResetColor();
                }
            }while(this.data > DateTime.Now);
        }
       

    }
}
