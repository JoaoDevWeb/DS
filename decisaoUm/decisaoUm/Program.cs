using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisaoUm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Informe o número");
            String numero = Console.ReadLine();

            switch (numero) { 
                case "1":
                    Console.WriteLine("Muito Insuficiente!");
                break;

                case "2":
                    Console.WriteLine("Insuficiente!");
                break;

                case "3":
                    Console.WriteLine("Suficiente!");
                break;

                case "4":
                    Console.WriteLine("Bom!");       
                break;

                case "5":
                    Console.WriteLine("Muito bom!");
                break;

                default:
                    Console.WriteLine("Valor Inválido!");
                    break;
            }

            Console.ReadKey();
        }
    }
}
