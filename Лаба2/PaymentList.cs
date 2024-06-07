using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба2
{
    public class PaymentList : List<Payment>
    {
        public void PostPayments()
        {
            this.Sort((a, b) => b.Data.CompareTo(a.Data));
        }
    }
}
