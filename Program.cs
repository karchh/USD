using System;

namespace Project {

    class Program {

        static void Main() {
            Console.WriteLine("Введите желаемую сумму USD на счету в банке страны НАТО: ");
            double SUMM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите текущую стоимость одного лота USD по курсу покупки у брокера: ");
            double USD = Convert.ToDouble(Console.ReadLine());
            double RUB = USD * 1.00923 * SUMM + 60000;
            Console.WriteLine("Необходимая сумма в рублях при покупке USD по стоимости {0} с учетом всех сраных комиссий этого гребанного Газпромбанка равна {1}", USD, (Math.Round(RUB, 2)));
        }

    }

}