using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Лаба2
{
    public class IndividPayment : Payment
    {
        public string? FIO { get; set; }
        public string? PassportData { get; set; }

        public IndividPayment(string fio, string passData, DateTime data)
        {
            FIO = fio;
            PassportData = passData;
            Data = data;
            Indetification = $"{FIO}, {PassportData}";
        }

        public override void Pay(double Summ, string PaymentID)
        {
            Console.WriteLine($"{Indetification} {Summ}");
        }
    }

    public class EntityPayment : Payment
    {
        public string? Name { get; set; }
        public string? Requisites { get; set; }

        public EntityPayment(string? name, string? requisites, DateTime data)
        {
            Name = name;
            Requisites = requisites;
            Data = data;
            Indetification = $"{name} {requisites}";
        }

        public override void Pay(double Summ, string? IDPayment)
        {
            Console.WriteLine($"{Indetification} {Summ}");
        }
    }
}
