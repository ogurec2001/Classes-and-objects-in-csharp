using System;
using System.Collections.Generic;
using System.Text;

namespace лаба_9
{
    class Money
    {
        int rubles;
        int kopeks;

        public static int count=0;
        public int Rub
        {
            get
            {
                return rubles;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка! Значение не может быть отрицательным!");
                    rubles = 0;
                    throw new Exception();
                }
                else rubles = value;
            }
        }
        public int Kop
        {
            get
            {
                return kopeks;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка! Значение не может быть отрицательным!");
                    kopeks = 0;
                    throw new Exception();
                }
                if (value > 99)
                {
                    rubles += value / 100;
                    kopeks = value % 100;
                }
                else kopeks = value;
            }
        }
        public Money()
        {
            Rub = 0;
            Kop = 0;
            count++;
        }
        public Money(int r, int k)
        {
            Rub = r;
            Kop = k;
            count++;
        }
        public void Show()
        {
            Console.WriteLine($"{Rub} руб. {Kop} коп.");
        }
        public Money SubstractKop(int kopeks)
        {
            if (this.Kop == 0 && this.Rub > 0)
            {
                int r1;
                r1 = this.Rub;
                this.Kop = ((this.Kop + (this.Rub * 100))-kopeks);
                this.Rub = this.Rub - r1;
            }
            else
                this.Kop -= kopeks;
            return this;
        }
        public static Money SubstractKop(Money m, int kopeks)
        {
            if (m.Kop == 0 && m.Rub > 0)
            {
                int r2;
                r2 = m.Rub;
                m.Kop = (m.Kop + (m.Rub * 100)) - kopeks;
                m.Rub = m.Rub - r2;
            }
            else
                m.Kop -= kopeks;
            return m;
        }
        public Money SubstractRub(int rubles)
        {
            this.Rub -= rubles;
            return this;
        }
        public static Money SubstractRub(Money m, int rubles)
        {
            m = new Money();
            m.Rub -= rubles;
            return m;
        }
        //перегрузка
        
        public static Money operator --(Money m)
        {
            if (m.Kop > 0 && m.Rub > 0)
            {
                m.Kop--;
                return m;
            }
            else if (m.Kop == 0 && m.Rub > 0)
            {
                m.Rub--;
                m.Kop = 99;
                return m;
            }
            else
            {
                throw new Exception();
            }
        }
        public static Money operator ++(Money m)
        {
            if (m.Kop >= 0&&m.Rub>=0)
            {
                m.Kop++;
                return m;
            }
            else
            {
                throw new Exception();
            }
        }
        
        public static implicit operator int(Money m)
        {
            return m.Rub;
        }

        public static explicit operator double(Money m)
        {
            return m.Kop;
        }
        public static Money operator -(Money m1, int k)
        {
            if (k > 0)
            {
                Money m = new Money();
                m.Rub = m1.Rub;
                m.Kop = m1.Kop - k;
                return m;
            }
            else
            {
                Console.WriteLine("Неверно введено число k!");
                throw new Exception();
            }
        }
        public static Money operator +(Money m1, int k)
        {
            if (k > 0)
            {
                Money m = new Money();
                m.Rub = m1.Rub;
                m.Kop = m1.Kop + k;
                return m;
            }
            else
            {
                Console.WriteLine("Неверно введено число k!");
                throw new Exception();
            }
        }
        public static bool operator >(Money m1, Money m2)
        {
            if (m1.Rub > m2.Rub) return true;
            else if (m1.Rub == m2.Rub)
            {
                if (m1.Kop > m2.Kop) return true;
                else return false;
            }
            else return false;
        }
        public static bool operator <(Money m1, Money m2)
        {
            if (m1.Rub < m2.Rub) return true;
            else if (m1.Rub == m2.Rub)
            {
                if (m1.Kop < m2.Kop) return true;
                else return false;
            }
            else return false;
        }
    }
}
