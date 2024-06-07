using System;
using Лаба2;
namespace Лаба
{
    class Program
    {
        static void Main()
        {

            var paymentList = new PaymentList();

            var paymentFiz1 = new IndividPayment("Иванов Иван Иванович", "1234 567890", new DateTime(2023, 5, 1));
            var paymentFiz2 = new IndividPayment("Петров Петр Петрович", "0987 654321", new DateTime(2023, 5, 2));

            var paymentYur1 = new EntityPayment("ООО 'Рога и Копыта'", "р/с 40702810000000000000", new DateTime(2023, 5, 3));
            var paymentYur2 = new EntityPayment("ПАО 'Газпром'", "р/с 40702810000000000001", new DateTime(2023, 5, 4));
            var paymentYur3 = new EntityPayment("АО 'Роснефть'", "р/с 40702810000000000002", new DateTime(2023, 5, 5));

            paymentList.Add(paymentFiz1);
            paymentList.Add(paymentFiz2);
            paymentList.Add(paymentYur1);
            paymentList.Add(paymentYur2);
            paymentList.Add(paymentYur3);

            paymentList.PostPayments();

            foreach (var payment in paymentList)
            {
                payment.Pay(1000, "123");
            }
        }
    }
}