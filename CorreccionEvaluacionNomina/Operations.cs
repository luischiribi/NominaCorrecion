using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CorreccionEvaluacionNomina
{
    internal class Operations
    {
        Variables variables = new Variables();

        public void calculatenomina()
        {
            Console.WriteLine("Enter id");
            variables.Document1 = Console.ReadLine();
            Console.WriteLine(" Enter first name");
            variables.Firstname1 = Console.ReadLine();
            Console.WriteLine("Enter last name");
            variables.Lastname1 = Console.ReadLine();
            Console.WriteLine("Enter your salary");
            variables.Salary1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your worked days");
            variables.WorkedDays1 = double.Parse(Console.ReadLine());

            variables.TotalDevengado1 = variables.Salary1 / 30;
            variables.TotalDevengado1 = variables.Salary1 * variables.WorkedDays1;

            variables.AuxTransporte1 = 117172 / 30;
            variables.AuxTransporte1 = variables.AuxTransporte1 * variables.WorkedDays1;

            variables.Salud1 = variables.TotalDevengado1 * 0.04;

            variables.Pension1 = variables.TotalDevengado1 * 0.04;

            if (variables.Salary1 <= 2000000)
            {
                variables.TotalDevengado1 = variables.TotalDevengado1 + variables.AuxTransporte1;
            }
            else
            {
                variables.TotalDevengado1 = variables.TotalDevengado1;
            }

            variables.TotalPay1 = variables.TotalDevengado1 - variables.Salud1 - variables.Pension1;

        }
        public void imprimirdatos()
        {
            Console.WriteLine($"number id: {variables.Document1}");
            Console.WriteLine($"First name: {variables.Firstname1}");
            Console.WriteLine($"Last name: {variables.Lastname1}");
            Console.WriteLine($"salary: {variables.Salud1}");
            Console.WriteLine($" worked days: {variables.WorkedDays1}");
            Console.WriteLine($" worked days: {variables.TotalDevengado1}");
            Console.WriteLine($"pension: {variables.Pension1}");
            Console.WriteLine($"healt: {variables.Salud1}");
            Console.WriteLine($"Total pay: {variables.TotalPay1}");
        }
        public void basededatos()
        {
            TextWriter database = new StreamWriter("DataBase.txt", true);
            database.WriteLine($"number id: {variables.Document1}");
            database.WriteLine($"First name: {variables.Firstname1}");
            database.WriteLine($"Last name: {variables.Lastname1}");
            database.WriteLine($"salary: {variables.Salud1}");
            database.WriteLine($" worked days: {variables.WorkedDays1}");
            database.WriteLine($" worked days: {variables.TotalDevengado1}");
            database.WriteLine($"pension: {variables.Pension1}");
            database.WriteLine($"healt: {variables.Salud1}");
            database.WriteLine($"Total pay: {variables.TotalPay1}");
            database.Close();

            TextReader info = new StreamReader("DataBase.txt");
            Console.WriteLine(info.ReadToEnd);
            info.Close();
        }
    }
}
