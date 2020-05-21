using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9
{
    class FractionArray
    {
        public static int count = 0;
        Money [] arr = null;
        static Random rand = new Random();
        public int Length
        {
            get
            {
              return arr.Length;
            }
        }
        public FractionArray(int size)
        {
            arr = new Money[size];
            for (int i = 0; i < size; i++)
            {
                Money m = new Money(rand.Next(0, 100), rand.Next(0, 100));
                arr[i] = m;
                count++;
            }
        }
        public FractionArray()
        {
            int size=5;
            Console.WriteLine($"\nВведите количество рублей ({size} раз) и копеек ({size} раз. Сначала вводятся рубли, потом копейки (идет чередование). ");
            arr = new Money[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = new Money(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                count++;
            }
        }

        public void Show()
        {
            if (arr == null || arr.Length == 0)
            {
                Console.WriteLine("Массив пустой!");
                return;
            }
            
           for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Show();
            }
        }
        public Money this[int index]//индексатор
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    Console.WriteLine("Индекс выходит за пределы массива!");
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                arr[index] = value;
            }
        }

    }
}
