using System;

namespace Surikov_Misis_lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //      lab_1_3(); 
            //  lab_1_4();
            // lab_1_5();
            //  lab_2_1();
            //  lab_2_3();
            //  lab_3_4();
            //  lab_3_11();
            //   lab_3_12();
            lab_3_13();
        }
        static void lab_1_3()
        {
            Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());
            double c;
            if (a > 0)
            {
                if (a >= b) { c = a; } else c = b;
            }
            else
            {      
                if (a >= b) { c = b; } else c = a;
            }
            Console.Write("c = "); Console.WriteLine(c);
            Console.Read();
        }
        static void lab_1_4()
        {
            Console.Write("a = "); double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = "); double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = "); double c = Convert.ToDouble(Console.ReadLine());
            double z; //z=max(min(a,b),c); 
            double p1; 
            if (a >= b) { p1 = b; } else { p1 = a; }
            if (p1 >= c) { z = p1; } else { z = c; }
            Console.Write("z = "); Console.WriteLine(z);
            Console.Read();
        }
        static void lab_1_5()
        {
            Console.Write("r = "); double r = Convert.ToDouble(Console.ReadLine());
            Console.Write("s = "); double s = Convert.ToDouble(Console.ReadLine());
            //если диагональ квадрата меньше или равна диаметру круга квадрат в круге уместится
            double skv = Math.Sqrt(s);
            double dkv = Math.Sqrt(2) * skv;
            double skr = Math.Sqrt(r / Math.PI);
            double dkr = 2 * skr;
            if (dkv >= dkr) { Console.WriteLine("Поместится"); } else { Console.WriteLine("Не поместится"); }
            //r=70 s=36,74 Ne pomestitsya
            //r=0,86 s=0,74 Pomestitsya
            Console.Read();
        }
        static void lab_2_1()
        {
            double n = Convert.ToInt16(Console.ReadLine());
            double x, s; s = 0;
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                s += x;
            }
            Console.WriteLine(s / n);
            Console.Read();
        }
        static void lab_2_3()
        {
            double n = Convert.ToInt16(Console.ReadLine()); double doze = 200;
            double x, s; s = 0;
            for (int i = 1; i <= n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                if (x < 30) { s += doze; };
            }
            Console.WriteLine((s / 1000)+" литра");
            Console.Read();
        }
        static void lab_3_4()
        {
            Console.WriteLine("Введите 0 0 в координатах для выхода"); int i = 1;
            double x=1;
            double y=1;
            Console.Write("r = ");
            double R1 = Convert.ToDouble(Console.ReadLine()); //малый круг
            Console.Write("R = ");
            double R2 = Convert.ToDouble(Console.ReadLine()); //большой круг
            int j = 0;
            while ((x != 0)||(y!=0))
            {
                Console.Write("x = "); x = Convert.ToDouble(Console.ReadLine());
                Console.Write("y = ");
                y = Convert.ToDouble(Console.ReadLine());   
                Console.WriteLine("Точка " + i + " (x,y) = " + x + ";" + y);
                if ((x*x + y*y <= R2*R2) && ((x * x + y * y >= R1 * R1)))
                { Console.WriteLine("Точка лежит в окружности"); j++; }
                else { Console.WriteLine("Точка не лежит в окружности");  }
                i++;
            }
            Console.WriteLine("В кольцо попадет всего " + j + " точек");
            Console.ReadLine();
        }
        static void lab_3_11()
        {
                Console.WriteLine("Введите 0 0 0 0 в оценках для выхода"); int i = 1;
            double x = 1;
            double y = 1;
            double z = 1;
            double l = 1;
            double globalsum = 0;
            double number = 0;
            double neusp = 0;
                int j = 0;
                while ((x != 0) && (y != 0) && (z !=0)&&(l!=0))
                {
                    Console.Write("1) "); x = Convert.ToDouble(Console.ReadLine());
                    Console.Write("2) "); y = Convert.ToDouble(Console.ReadLine());
                    Console.Write("3) "); z = Convert.ToDouble(Console.ReadLine());
                    Console.Write("4) "); l = Convert.ToDouble(Console.ReadLine());
                if (x == 2 || y == 2 || z == 2 || (l == 2))
                {
                    neusp++;
                }
                else
                {
                    if (x == 0 || y == 0 || z == 0 || (l == 0))
                    {
                        break;
                    }
                        globalsum = globalsum + (x + y + z + l);
                    number++;
                }
                }
                Console.WriteLine("Число неуспевающих " + neusp);
                Console.WriteLine("Средний балл " + (globalsum/ (number*4)));
            Console.ReadLine();
        }
        static void lab_3_12()
        {
            Console.Write("n = "); double s=1;
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write("r = ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберете 1 для площади квадрата, 2 для площади круга, 3 для равностороннего треугольника");
            double choice = Convert.ToDouble(Console.ReadLine());
            switch (choice)
            {
                case 1:
                s= r * r;
                    break;
                    case 2:
                        s = Math.PI * r * r;
                        break;
                    case 3:
                        s = r * r * Math.Sqrt(3) / 4;
                        break;
            }
            Console.WriteLine("s = "+s);
            }
            Console.ReadLine();
        }
        static void lab_3_13()
        {
            Console.Write("n = "); double s = 1;
            double n = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write("A = ");
                double A = Convert.ToDouble(Console.ReadLine());
                Console.Write("B = ");
                double B = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Выберете 1 для площади прямоугольника со сторонами А-В, 2 для площади кольца с окружностями с радиусами А-В, 3 для равностороннего треугольника со сторонами А-В-В");
                double choice = Convert.ToDouble(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        s = A * B;
                        break;
                    case 2:
                        s = Math.Abs( Math.PI * A *A - Math.PI*B*B);
                        break;
                    case 3:
                            s = B * Math.Sqrt(A * A - B * B / 4) / 2;
                        break;
                }
                Console.WriteLine("s = " + s);
            }
            Console.ReadLine();
        }

    }
}
