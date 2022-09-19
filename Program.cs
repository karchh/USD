using System;

namespace Project {

    class Program {

        static void Main() {
            Console.WriteLine("Введите желаемую сумму EUR на счету в банке страны НАТО: ");
            double SUMM = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите текущую стоимость одного лота USD по курсу покупки у гребаного брокера Газпромбанка: ");
            double USD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите актуальный кросс-курс пары EUR/USD на рынке ФОРЕКС: ");
            double Kross = Convert.ToDouble(Console.ReadLine());
                double RUB = (USD * 1.00923 * SUMM + 60000)*Kross;
            Console.WriteLine("Необходимая сумма в рублях при покупке USD по стоимости {0} с конвертацией в EUR (с учетом всех сраных комиссий этого гребанного Газпромбанка) = {1}", USD, (Math.Round(RUB, 2)));
        }

    }

}