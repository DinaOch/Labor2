using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    public abstract class Payment
    {
        public DateTime Data { get; set; }
        public string? Indetification { get; protected set; }

        public abstract void Pay(double Summ, string PaymentId);
    }
}
