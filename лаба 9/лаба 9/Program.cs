using System;

namespace лаба_9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Вы ввели:");
            Money m1 = new Money(3, 45);
            m1.Show();
            Money m2 = new Money(3, 110);
            m2.Show();
            Money m3 = new Money(4, 0);
            m3.Show();
            Money m4 = new Money(1, 3);
            m4.Show();
            Console.WriteLine("\nКоличество объектов: " + Money.count);

            Console.WriteLine("\nВызов нестатических методов:");
            Console.Write("\nВычитание переменной типа Money (копейки) из объекта ");
            m3.Show();
            m3.SubstractKop(8);
            m3.Show();
            Console.Write("\nВычитание переменной типа Money (рубли) из объекта ");
            m2.Show();
            m2.SubstractRub(2);
            m2.Show();

            Console.WriteLine("\nВызов статических методов:");
            Console.Write("\nВычитание переменной типа Money (копейки) из объекта ");
            Money m8 = new Money(5, 0);
            m8.Show();
            Money.SubstractKop(m8, 18);
            m8.Show();
            Console.Write("\nВычитание переменной типа Money (рубли) из объекта ");
            Money m9 = new Money(7, 19);
            m9.Show();
            Money.SubstractKop(m8, 10);
            m9.Show();

            Console.WriteLine("\nЭто была 1 часть лабораторной.\n");

            Console.Write("Результат операции сложение++ объекта ");
            m4.Show();
            m4++;
            m4.Show();
            Console.Write("Результат операции ++сложение объекта ");
            Money m5 = new Money(99, 99);
            m5.Show();
            ++m5;
            m5.Show();

            Console.Write("Результат операции вычитание-- объекта ");
            m3.Show();
            m3--;
            m3.Show();
            Console.Write("Результат операции --вычитание объекта ");
            Money m6 = new Money(4, 0);
            m6.Show();
            --m6;
            m6.Show();
         
            Console.Write("\nСледующие операции будут проводиться с объектом ");
            m1.Show();
            int res1 = m1;
            Console.WriteLine($"    Неявное преобразование типа (отбрасывание копеек): "+ res1);
            double res2 = (double)m1;
            Console.WriteLine($"    Явное преобразование типа (отбрасывание рублей):" + res2);

            Console.WriteLine("\nБинарные операции:");
            Console.Write("\nВычитание заданного числа: ");
            m2.Show();
            m2 = m2 - 10;
            m2.Show();
            Console.Write("\nСложение заданного числа: ");
            Money m7 = new Money(3, 99);
            m7.Show();
            m7 = m7 + 1;
            m7.Show();
            Console.WriteLine("\nЭто была 2 часть лабораторной.");

            
            //random
            Console.WriteLine("\nФормирование массива методом ДСЧ:");
            FractionArray frarr = new FractionArray(5);
            Console.WriteLine("\nВаш массив: ");
            frarr.Show();
            Console.WriteLine("\nКоличество объектов: " + FractionArray.count);
           

            Console.Write("Вывод значения по индексу: ");
            frarr[3].Show();
            Console.Write("Изменение значения на: ");
            frarr[3] = new Money(4, 0);
            frarr[3].Show();
            Console.WriteLine("\nИзмененный массив:");
            frarr.Show();

            Console.WriteLine("\nПоиск максимального значения: ");
            Money max1 = frarr[0];
            for (int i = 0; i < frarr.Length; i++)
            {
                if (frarr[i] > max1) max1 = frarr[i];
            }
            max1.Show();

            //by hand
            Console.WriteLine("\nФормирование массива с клавиатуры:");
            FractionArray fr = new FractionArray();
            Console.WriteLine("\nВаш массив: ");
            fr.Show();
            Console.WriteLine("\nКоличество объектов: " + FractionArray.count);

            Console.Write("Вывод значения по индексу: ");
            fr[2].Show();
            Console.Write("Изменение значения на: ");
            fr[2] = new Money(5, 0);
            fr[2].Show();
            Console.WriteLine("\nИзмененный массив:");
            fr.Show();

            Console.WriteLine("\nПоиск максимального значения: ");
            Money max2 = fr[0];
            for (int i = 0; i < fr.Length; i++)
            {
                if (fr[i] > max2) max2 = fr[i];
            }
            max2.Show();
            Console.WriteLine("\nЭто была 3 часть лабораторной.");
            Console.ReadKey();
        }
    }
}
