using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CorreccionEvaluacionNomina
{
    internal class ClassMain
    {
        public void Main(string[] args)
        {
            Operations facture = new Operations();
            int op = 0;
            do
            {
                try
                {
                    Console.WriteLine("Welcome to the nomina");
                    facture.calculatenomina();
                    facture.imprimirdatos();
                    Console.WriteLine("Can you repeat this program");
                    Console.WriteLine("1.Yes");
                    Console.WriteLine("2.No");
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                }catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Invalid character \n");
                }
                    

            } while (op != 2);
            {
                facture.basededatos();
            }
        }
    }
}
