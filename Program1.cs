using System;

namespace Surikov_Misis_lab1_0_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  lab_1_4();
            //   lab_1_9();
            //   lab_1_15();
            //lab_1_16();
            // lab_1_18();
          //    lab_2_2();
            //  lab_2_4();
            // lab_2_7and8();
            //  lab_3_1();
          //  lab_3_7();

        }
        static void lab_1_4()
        {
            //Вычислить s = cosx/x^0 + (cos 2x)/x^1 + (cos 3x)/x^2
            //+ ... + (cos 9x)/x^8

            double s = 0; int j = 0; double c = 1;
            int p;
            double x = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= 8; i++)
            {
                s += Math.Cos(x * (i + 1)) / (c);
                // 1 2 3 4 5 6 7 8
                c = c * x;
            }
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void lab_1_9()
        {
            //8,36805555555556
            double s = 0; double c = 1; double j = 1; double k = 1; double mo = 1;
            for (int i = 1; i <= 6; i++)
            {
                //       Console.WriteLine("i = "+i + " s = " + s + " k = " + k + " c = " + c + " mo= " + mo + " j= " + j);
                c = -c;
                mo = 5 * mo;
                j *= k;
                k++;
                s += c * mo / j;
          //      Console.WriteLine(" i = "+i + " c = " + c + " j = " + j +" mo = "+mo+" s = "+s);
                
        //        s += (c+mo)/j;
              //  Console.WriteLine(i+" "+s+" " +k+" "+c+" "+mo+" "+j);
           //     s += ((Math.Pow((-1), i) * (Math.Pow(5, i))) / (Enumerable.Range(1, i).Aggregate(1, (p, item) => p * item)));
            }
        
    Console.WriteLine(s);
            Console.ReadLine();
        }
        static void lab_1_15()
        {
            //1,6
            double old_v = 1;
            double old_n = 1;
            double n = 1;
            double v = 2;
            double new_v = old_v + v;
            double new_n = old_n + n;

            for (int i = 3; i <= 5; i++)
            {
                old_n = n; n = new_n; new_n = old_n + n;
                old_v = v; v = new_v; new_v = old_v + v;
                // 1/1 2/1 3/2 5/3 8/5
            }
            Console.WriteLine(v / n);
            Console.ReadLine();
        }
        static void lab_1_16()
        {
            //18446744073709551615 зерен
            //1229782938247303441 грамм
            ulong s = 0;
            ulong z = 1;
            //15 зерен = 1 грамм

            for (int i = 1; i <= 64; i++)
            {
                s += z;
                z = z * 2;
            }
            Console.WriteLine(s + " зерен");
            Console.Write((s) / 15); Console.WriteLine(" грамм");
            Console.ReadLine();
        }
        static void lab_1_18()
        {
            /* hours = 3, amebs = 20
 hours = 6, amebs = 40
 hours = 9, amebs = 80
 hours = 12, amebs = 160
 hours = 15, amebs = 320
 hours = 18, amebs = 640
 hours = 21, amebs = 1280
 hours = 24, amebs = 2560
            */
            int amount = 20;
            //3 часа -> x*2

            for (int i = 3; i <= 24; i = i + 3)
            {
                Console.WriteLine(" hours = " + i + ", amebs = " + amount);
                amount = amount * 2;
            }
            Console.ReadLine();
        }
        static void lab_2_2()
        {
            //16
            int p = 1; int n = 1;
            while (p <= 30000)
            {
                p = p * n;
                n += 3;
            }
            //-3 так как мы получаем число >30000 на прошлом цикле -> берем предпоследнее число
            Console.WriteLine(n - 3);
            Console.ReadLine();
        }
        static void lab_2_4()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double s = 1; double n = 1;

            if ((-1 <= x) && (x <= 1))
            {
                    for (int i = 1; n >= 0.0001 ; i++)
                    {
                    n = n * x * x;
                    s += n;
                    }
                    
                }
            
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void lab_2_7and8()
        {
            /*a) Бег за 7 дней 94,87171
б) Дней 8
в) Через дней 7(На 8 день)
             */
            double run = 10;
            double sum = 0;
            for (int i = 1; i <= 7; i++)
            {
                sum += run;
                run = run * 1.1;
                //    Console.WriteLine(" sum = " + sum + " run = " + run);
            }
            Console.WriteLine("a) Бег за 7 дней " + sum);
            run = 10;
            sum = 0;
            int day = 0;
            while (sum <= 100)
            {
                day++;
                sum += run;
                run = run * 1.1;
                //      Console.WriteLine("day = " + day + " sum = " + sum + " run = " + run);
            }
            Console.WriteLine("б) Дней " + day);
            run = 10;
            sum = 0;
            day = 0;
            while (run <= 20)
            {
                day++;
                run = run * 1.1;
            }
            Console.WriteLine("в) Через дней " + (day - 1) + "(На 8 день)");
            Console.ReadLine();
        }
        static void lab_3_1()
        {
            //x^2i / (2i)!
            int p = 1; int down = 1;
            double s = 0, xup = 0, SS = 0, a = 0.1, b = 1, h = 0.1;
            for (double x = a; x <= b; x += h)
            {
                xup = x;
                s = 0;
                SS = 1;
                down = 1;
                p = -1;
                for (int i = 2; Math.Abs(SS)>0.0001; i += 2)
                {
                    s += SS;
                    down = down * i * (i - 1);
                    xup = xup * xup;
                    SS = p * xup / down;
                    p = -p;
                }
                Console.WriteLine("x = " + x + " y = " + Math.Cos(x)+" s = "+s);
            }
            Console.ReadLine();
        }
        static void lab_3_7()
        {
            //x^2i / (2i)!
            int p = 1; int down = 1;
            double s = 0, xup = 0, SS = 0, a = 0.1, b = 1.05, h = 0.05;
            for (double x = a; x <= b; x += h)
            {
                xup = x;
                s = 0;
                SS = 1;
                down = 1;
                p = -1; double y;
                for (int i = 2; Math.Abs(SS) > 0.0001; i += 2)
                {
                    s += SS;
                    down = down * i * (i - 1);
                    xup = xup * xup;
                    SS = xup / down;

                }
                y = (Math.Pow(Math.E, x) + Math.Pow(Math.E, -x)) / 2;
                Console.WriteLine("x = " + x + " y = " + y + " s = " + s);
            }
            Console.ReadLine();
        }
    }
}
