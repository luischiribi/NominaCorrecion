using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CorreccionEvaluacionNomina
{
    internal class Variables
    {
        private string Document;
        private string Firstname;
        private string Lastname;
        private double Salary;
        private double WorkedDays;
        private double TotalDevengado;
        private double AuxTransporte;
        private double Salud;
        private double Pension;
        private double TotalPay;


        public Variables() { }

        public string Document1 { get => Document; set => Document = value; }
        public string Firstname1 { get => Firstname; set => Firstname = value; }
        public string Lastname1 { get => Lastname; set => Lastname = value; }
        public double Salary1 { get => Salary; set => Salary = value; }
        public double AuxTransporte1 { get => AuxTransporte; set => AuxTransporte = value; }
        public double Salud1 { get => Salud; set => Salud = value; }
        public double Pension1 { get => Pension; set => Pension = value; }
        public double WorkedDays1 { get => WorkedDays; set => WorkedDays = value; }
        public double TotalDevengado1 { get => TotalDevengado; set => TotalDevengado = value; }
        public double TotalPay1 { get => TotalPay; set => TotalPay = value; }
    }
}
