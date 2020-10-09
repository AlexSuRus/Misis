using System;
using System.Linq;

namespace Surikov_Misis_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
         //      lab_1_6();
        //     lab_1_10();
          //   lab_1_11();
         //    lab_1_12();
          //    lab_1_13();
       //     lab_2_5();
        //       lab_2_6();
       //        lab_2_9();
             lab_2_10();
          //    lab_2_11();
          //      lab_2_13();
          //    lab_2_15();
           //     lab_3_1();
            //      lab_2_15();         
         //     lab_3_5();
            //   lab_3_8();
         //    lab_3_9();
           //       lab_3_12();      
            //  lab_3_13();
          //     lab_0_11();
         //     lab_0_12();
            //     lab_0_13();         
          //    lab_0_14();
         //      lab_0_15();
        }
        static void lab_1_6()
        {
            const int n = 5;
            double[] x = new double[n]{ 1,2,3,4,5}; double S = 0;
            for (int i = 0; i < n; i++)
            {
                S += (x[i] * x[i]);
            }
            Console.WriteLine(Math.Sqrt(S));
            Console.ReadLine();
        }
        static void lab_1_10()
        {
            const int n = 5; double s = 0;
            double[] x = new double[n] { -4,6,1,-6,7 };
            Console.Write("P = ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Q = ");
            double Q = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if ((P <= x[i]) && (x[i] <= Q)) { s++; }
            }
            Console.Write("S = ");
            Console.WriteLine(s);
            Console.ReadLine();
        } 
        static void lab_1_11()
        {
            double[] a = new double[5] { 444, 333, 544, -565, -7365 };
            double[] b = new double[5];
            int k = 0;
            foreach (double x in a)
            {
             if (x > 0)
                {
                    b[k] = x;
                    k = k + 1;
                }
            }
            for (int i = 0; i < k; i++)
            {
                Console.WriteLine(i + ") " + b[i]);
            }
            Console.ReadLine();
        }
        static void lab_1_12()
        {
            const int n = 8; double s = 0; int j = 0;
            double[] x = new double[n] { 0, 0, -76, 10, 130, 0, -6868, 0};
            for (int i = 0; i < n; i++)
            {
                if (x[i] < 0) { j = i; s = x[i]; }
            }
            Console.WriteLine(j + ") " + s);
            Console.ReadLine();
        }
        static void lab_1_13()
        {
            int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] b = new int[5];
            int[] c = new int[5];
            for (int i = 0; i < 5; i++)
            {
                b[i] = a[2 * i];
                c[i] = a[2 * i + 1];
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+")b) "+ b[i]);
                Console.WriteLine((i + ")c) " + c[i]));
            }
            Console.ReadLine();
        }      
        static void lab_2_5()
        {
            int[] a = new int[5] { 1000,3,-5,-6,-7 };
            int[] b = new int[5];
            int amax = a[0];
            int imax = 0;
            int amin = a[0];
            int imin = 0;
            for (int i = 1; i < 5; i++)
            {
                if (a[i] > amax)
                {
                    amax = a[i];
                    imax = i;
                }
                if (a[i] < amin)
                {
                    amin = a[i];
                    imin = i;
                }
            }
            int j = 0;
            if (imin > imax) //4 > 1  -> надо свап имин на имакс
            {
                int t = imin; // 4
                imin = imax;
                imax = t;
            }
                for (int i = imin; i < imax; i++)
                {
                    if (a[i] < 0)
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(i + ") " + b[i]);
            }
            Console.ReadLine();
        } 
        static void lab_2_6()
        {
            int[] a = new int[5+1] { -1000, 3, -5, -6, 7,0 }; int P = -960; int S = 0, sr = 0;
            for (int i = 0; i < 5; i++)
            {
                S += a[i];
            }
            sr = S / 5;
            //наиболее близок к sr -> a[i]-sr должно быть минимальным
            int minR = Math.Abs(a[0] - sr); int minI = 0;
            for (int i = 0; i < 5; i++)
            {
                if (Math.Abs((a[i] - sr)) < minR)
                {
                    minR = Math.Abs((a[i] - sr));
                    minI = i;
                }
            }
            for (int i = 4; i >= minI + 1; i--)
            { 
                a[i + 1] = a[i];
            }
     //       Console.WriteLine(minR + " " + minI);
            a[minI + 1] = P;
            Console.WriteLine(sr + " " + P+" (sr,P)");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(i + ") " + a[i]);
            }
            Console.ReadLine();
        } 
        static void lab_2_9()
        {
            int[] a = new int[5] { 1000,3,-5,-6,-7 };
            int sr = 0; int S = 0; int iS = 0;
            int amax = a[0];
            int imax = 0;
            int amin = a[0];
            int imin = 0;
            for (int i = 1; i < 5; i++)
            {
                if (a[i] > amax)
                {
                    amax = a[i];
                    imax = i;
                }
                if (a[i] < amin)
                {
                    amin = a[i];
                    imin = i;
                }
            }
            if (imin > imax) 
            {
                int t = imin; 
                imin = imax;
                imax = t;
            }
                for (int i = imin; i < imax + 1; i++)
                {
                    S += a[i];
                    iS++;
                }
            sr = S / iS;
            Console.WriteLine(sr);
            Console.ReadLine();
        } 
        static void lab_2_10()
        {
            // Удалить минимальный среди положительных элементов массива
            int[] a = new int[5] {-4,6,1,-6,-7 };
            int n = 5;
            int amin = -1;
            int imin=0;
            for (int i = 0; amin < 0; i++)
            {
                if (a[i] > 0)
                {
                    amin = a[i];
                    imin = i;
                    break;
                }
            }
           
           
            for (int i = 1; i < 5; i++)
            {
                if ((a[i] < amin) && (a[i] > 0))
                {
                    amin = a[i];
                    imin = i;
                }
            }
            n = n - 1;
            for (int i = imin; i < n; i++)
            {
                a[i] = a[i + 1];
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ") " + a[i]);
            }
            Console.ReadLine();
        }
        static void lab_2_11()
        {
            int[] a = new int[6] { 4, 6, 5, -6, -7,0 };
            int n = 6;
             int S = 10000; 
            int am = a[0];
            int imin = 0;
            for (int i = 1; i < 5; i++)
            {
                if ((a[i] > 0))
                {
                    imin = i;
                }
            }
            n = n - 1;
            for (int i = 4; i >= imin + 1; i--)
{
                a[i + 1] = a[i];
            }
            a[imin + 1] = S;
            for (int i = 0; i < n+1; i++)
            {
                Console.WriteLine(i + ") " + a[i]);
            }
            Console.ReadLine();
        }
        static void lab_2_13()
        {
            //Максимальный элемент массива среди элементов с четными
            //индексами заменить значением его индекса.
            int[] a = new int[5] { 400, 6, 1, -6, 7 };
            int n = 5;
            int amax = a[0];
            int imax = 0;
            for (int i = 0; i < 5; i=i+2)
            {
                if (a[i] > amax)
                {
                    amax = a[i];
                    imax = i;
                }
            }
            a[imax] = imax;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + ") " + a[i]);
            }
            Console.ReadLine();
        }
        static void lab_2_15()
        {
            //Заданы массивы А и В, содержащие n и m элементов соответственно. Вставить массив В между k-м и (k + 1)-м элементами массива А (k задано).
         const int n = 6; //Массив А
         const int m = 3; //Массив В
            int[] A = new int[] { 1, 2, 3, 4, 5, 6,0,0,0,0 };
            int[] B = new int[m] { 7,8,9 }; // 1 2 3 7 8 9 4 5 6 0
            int k = 3;
            int j = 0;
            //k=3 -> между 3 и 4 вставляем -> 4 5 6 двигаем направо элементв это 3 4 5
            for (int i = k; i >k-m; i--)
            {
           //     A[i+5] = A[i + 2 ];
                A[i + (n - 1)] = A[i + (m - 1)];
                //A[8]=A[5]
                //A[7]=A[4]
                //A[6]=A[3]
            }
            for (int i = k; i < k + m; i++)
            {
           //     Console.WriteLine(i + " " + A[k + 2] + " " + A[k + 5]+" DDDDDDDDDDD");
                A[i] = B[j];
                j++;
            }
            for (int i = 0; i < (n+m); i++)
            {
                Console.WriteLine(i + ") " + A[i]);
            }
            Console.ReadLine();
        } 
        static void lab_3_1()
        {
            //Найти все максимальные элементы одномерного массива (предполагается, что в массиве несколько одинаковых максимальных элементов)
            // за один проход исходного массива.Сформировать массив из их индексов
           const int n = 6;  int j = 0;
            double[] x = new double[n] { 0, 0, 5, 0, 5, 5 }; double max = x[0]; int maxi = 0;
            double[] y = new double[n] { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < n; i++)
            {
                if ((x[i] > max)||(x[i]==max))
                {
                    if (x[i] > max)
                    {
                        max = x[i];
                        maxi = i;
                        for (int l = j; l >= 0; l--)
                        {
                            y[l] = 0;
                        }
                        j = 0;
                    }
                    //обнуляем массив индексов так как нашли новый максимальный элемент
                    else if (x[i] == max)
                    {
                        max = x[i];
                        maxi = i;
                        //обнулить у
                        y[j] = maxi;
                        j++;
                    }
                }
            }
            for (int l = 0; l < j; l++)
            {
                Console.WriteLine(y[l]);
            }
            Console.ReadLine();
        }
        static void lab_3_5()
        {
            //Упорядочить по возрастанию элементы массива с четными индексами (остальные элементы оставить на своих местах).
         const int n = 6;
            double[] x = new double[n] { 3, 5, 4, 1, 2, 10 };
            double[] y = new double[n] { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < n-2; i=i+2)
            {
                for (int j = i + 2; j < n; j=j+2)
                {
                    if ((x[i] > x[j]))   
                    {
                        double t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(k + ") " + x[k]);
            }
            Console.ReadLine();
        } 
        static void lab_3_8()
        {
            //Упорядочить по убыванию отрицательные элементы массива,
            // сохраняя остальные элементы на прежних местах
       const int n = 6;
            double[] x = new double[n] { 10, -31, -3, 0, -1, 320 };
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if ((x[i] < 0) && (x[i] < x[j]) && (x[j] < 0)) //Если левый меньше правого -> делаем свап -2 1 -1
                    {
                        //         Console.WriteLine("Original x[i] and x[j] " + x[i] + " " + x[j]);
                        double t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                        //      Console.WriteLine("Dev x[i] and x[j] and t " + x[i] + " " + x[j]+" "+t);
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }
        static void lab_3_9()
        {
            //В заданном массиве определить длину самой большой упорядоченной (по возрастанию или по убыванию) последовательности.
           const int n = 6;
            double[] x = new double[n] { 1, 2, 3, 0, 4, 5 };
            //длина самой большой упорядоченной по возрастанию подпоследовательности
            int count = 1, max = 0; //переменные счетчика и максимальной последовательности
            for (int i = 1; i < n; i++)
            {
                if (x[i] > (x[i - 1])) //проверка на сущ-е возрастающей последовательности
                {
                    count++;
                    if (count > max)
                    {
                        max = count;
                    }
                }
                else
                    count = 1;
            }
            int countUUU = 1, maxUUU = 0; //переменные счетчика и максимальной последовательности
            for (int i = 1; i < n; i++)
            {
                if (x[i] < (x[i - 1])) //проверка на сущ-е возрастающей последовательности
                {
                    countUUU++;
                    if (countUUU > maxUUU)
                    {
                        maxUUU = countUUU;
                    }
                }
                else
                    countUUU = 1;
            }
            if (max > maxUUU) { Console.WriteLine(max); } else { Console.WriteLine(maxUUU); }
            Console.ReadLine();

        }
        //Не обязательно 3_10
        static void lab_3_10()
        {
            //НЕ НУЖНО БЫЛО ДЕЛАТЬ
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n / 2; ++i)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i -= 2)
            {
                arr[i] = arr[i / 2];
                arr[i - 1] = arr[i];
            }
            foreach (var x in arr)
            {
                Console.WriteLine("{0} ", x);
            }
            Console.ReadLine
();
        }
        //Не обязательно 3_11
        static void lab_3_11()
        {
            //НЕ НУЖНО
            int a = Convert.ToInt16(Console.ReadLine());
            int b = Convert.ToInt16(Console.ReadLine());
            //1 2 3 4 5
            //a=1 b=5 n=b-a+1
            int n = Convert.ToInt32(Console.ReadLine());
            double[] arrX = new double[n];
            double[] arrY = new double[n];
            double globalMax = -1000; double globalMin = 1000;
            double x = 1;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToDouble(Console.ReadLine());
                double y = Math.Cos(x) + x * Math.Sin(x);
                if ((y >= a) & (y <= b))
                {
                    arrY[i] = y;
                    arrX[i] = x;
                }
            }
            for (int i = 0; i <= (n - 3); i++)
            {
                if ((arrY[i] < arrY[i + 1]) & (arrY[i + 1] > arrY[i + 2]))
                {
                    Console.WriteLine("В точке " + arrX[i] + " функция = " + arrY[i] + " достигается максимум");
                    if (arrY[i] > globalMax) { globalMax = arrY[i]; }
                }
                if ((arrY[i] > arrY[i + 1]) & (arrY[i + 1] < arrY[i + 2]))
                {
                    Console.WriteLine("В точке " + arrX[i] + " функция = " + arrY[i] + " достигается минимум");
                    if (arrY[i] < globalMin) { globalMin = arrY[i]; }
                }
            }
            Console.WriteLine("Глобальный максимум " + globalMax);
            Console.WriteLine("Глобальный минимум " + globalMin);


            Console.ReadLine();
        }
        static void lab_3_12()
        {
            ///
            // Из массива размером 12 удалить все отрицательные элементы. 
            const int n = 12;
            double[] x = new double[n] { 1, 2, 3, -4, -5, -6 ,-7,8,9,10,11,12}; // 1 2 3 8 9 10 11 12 0 0 0 0
            // видим элемент с индексом 3 который меньше 0 - значит 
            //l=12
            //a[3]=a[4]          a[i]=a[i+1]      
            //a[4]=a[5]
            //...
            //a[10]=a[11]
            //a[l]=0; l--;
            int l = 11;
            for (int i = 0; i < 11; i++)
            {
                if (x[i] < 0)
                {
                    for (int j = i; j < 11; j++)
                    {
                        x[j] = x[j + 1];
                    }
                    x[l] = 0;
                    l--;
                    i--;
                }
            }
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(i + ") " + x[i]);
            }
            Console.ReadLine();
        } 
        static void lab_3_13()
        {
            // Из массива удалить повторяющиеся элементы
            const int n = 6;
            int[] array = new int[n] { 1, 2, 3, 1, 2, 3 };
            int numDups = 0, prevIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool foundDup = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        foundDup = true;
                        numDups++; // Увеличиваем каунт на 1 при дубликате
                        break;
                    }
                }

                if (foundDup == false)
                {
                    array[prevIndex] = array[i];
                    prevIndex++;
                }
            }

            // Обнуляем дубликаты.
            for (int k = 1; k <= numDups; k++)
            {
                array[array.Length - k] = '\0';
            }
            Console.WriteLine(" ");

            for (int l = 0; l < n - numDups; l++)
            {
                Console.WriteLine(array[l]);

            }
            Console.ReadLine();
        }
        static void lab_0_11()
        {
            int counter;
           const int n = 6;
            double[] x = new double[n] { 1, 2, 3, 4, 5, 0 };
            int X = 4;
            int Poisk(int b)
            {
                int k;
                int L = 0;        // левая граница
                int R = n - 1;    // правая граница
                k = (R + L) / 2;
                counter = 0;
                while (L < R - 1)
                {
                    counter++;
                    k = (R + L) / 2;
                    if (x[k] == b)
                        return k;
                    counter++;
                    if (x[k] < b)
                        L = k;
                    else
                        R = k;
                }
                if (x[k] != b)
                {
                    if (x[L] == b)
                        k = L;
                    else
                    {
                        if (x[R] == b)
                            k = R;
                        else
                            k = -1;
                    };
                }
                return k;
            }
            Console.WriteLine(Poisk(X) + ") " + X);
            Console.ReadLine();
        }
        static void lab_0_12()
        {
             int n = 6;
             int m = 6;
             void DoMerge(int[] ar1, int[] ar2,
                           int nu, int nt, int[] ar3)
            {
                int i = 0, j = 0, k = 0;
                while (i < nu && j < nt)
                {
                    ar3[k++] = ar1[i++];
                    ar3[k++] = ar2[j++];
                }
                while (i < nu)
                    ar3[k++] = ar1[i++];
                while (j < nt)
                    ar3[k++] = ar2[j++];
            }
            if (n > m) { n = m; } else m = n;
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int n1 = arr1.Length;
            int[] arr2 = new int[] { 7, 8, 9, 10, 11, 12 };
            int n2 = arr2.Length;
            int[] arr3 = new int[] { 0, 0, 0, 0, 0, 0 , 0, 0, 0, 0, 0, 0};
            DoMerge(arr1, arr2, n1, n2, arr3);

            Console.WriteLine("Массив после слияния");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
            Console.ReadLine();
        }
        
        static void lab_0_13()
        {
            //3. Объединение двух упорядоченных массивов в один с сохранением упорядоченности.
            //    Требуется объединить два упорядоченных по убыванию массива A
            //размером n и B размером m в один массив C размером(n + m), также
            //упорядоченный.
          const int n = 4;
          const int m = 4;
            void mergeArrays(int[] ar1, int[] ar2,
                                   int nu, int nt, int[] ar3)
            {
                int i = 0, j = 0, k = 0;
                while (i < nu && j < nt)
                {
                    if (ar1[i] < ar2[j])
                        ar3[k++] = ar1[i++];
                    else
                        ar3[k++] = ar2[j++];
                }
                while (i < nu)
                    ar3[k++] = ar1[i++];
                while (j < nt)
                    ar3[k++] = ar2[j++];
            }
            int[] arr1 = new int[n] { 1, 3, 5, 7 };
            int n1 = arr1.Length;

            int[] arr2 = new int[m]{ 2, 4, 6, 8 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];

            mergeArrays(arr1, arr2, n1, n2, arr3);

            for (int i = 0; i < n1 + n2; i++)
                Console.WriteLine(i+") "+arr3[i]);
            Console.ReadLine();

        }
         
        static void lab_0_14()
        {
            const int n = 6;
            int[] arr1 = new int[n] { 0, 1, 2, 3, 4, 5 };
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
                int t = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = t;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();
        }
        static void lab_0_15()
        {
            const int n = 6;
            int[] a = new int[n] { 1, 2, 3, 4, 5, 6 };
             int m = 2;
            for (int g = 0; g < m; g++)
            {
                if (a.Length > 1)
                {
                    var tmp = a[a.Length - 1];
                    for (var i = a.Length - 1; i != 0; --i)
                        a[i] = a[i - 1];
                    a[0] = tmp;
                }
            }
            for (int l = 0; l < n; l++)
            {
                Console.WriteLine(a[l]);
            }
            Console.ReadLine();
        }

    }
}
