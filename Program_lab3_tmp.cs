using System;
using System.Linq;

namespace Surikov_Misis_lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //    lab_1_6();
            // lab_1_10();
            // lab_1_11();
            // lab_1_12();
            //  lab_1_13();
            //lab_2_5();
            //   lab_2_6();
            //   lab_2_9();
            // lab_2_10();
            //  lab_2_11();
            //    lab_2_13();
            //  lab_2_15();
            //    lab_3_1();
            //    lab_2_15();      @@@@@@@@@@@@@@@@@@@@@@
            //  lab_3_5();
            //    lab_3_8();
            // lab_3_9();
            //      lab_3_12();      @@@@@@@@@@@@@@@@@@@@@@
            //  lab_3_13();
            //   lab_0_11();
            //  lab_0_12();
            //     lab_0_13();             @@@@@@@@@@@@@@@@@@@@@@
            //  lab_0_14();
         //   lab_0_15();
        }
        static void lab_1_6()
        {
            const int n = 5;
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToDouble(Console.ReadLine());
            }
            double L=Math.Sqrt((x[0]*x[0])+ (x[1] * x[1]) + (x[2] * x[2]) + (x[3] * x[3]) + (x[4] * x[4])) ;
            Console.WriteLine(L);
            Console.ReadLine();
        }
        static void lab_1_10()
        {
            const int n = 10; double s = 0;
            double[] x = new double[n];
            Console.Write("P = ");
            double P = Convert.ToDouble(Console.ReadLine());
            Console.Write("Q = ");
            double Q = Convert.ToDouble(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToDouble(Console.ReadLine());
                if ((P <= x[i]) && (x[i] <= Q)) { s++; }
            }
            Console.Write("S = ");
            Console.WriteLine(s);
            Console.ReadLine();
        }
        static void lab_1_11()
        {
            const int n = 10; double s = 0; int i = 0;
            double[] x = new double[n];
            while(x[9]<=0)
            {
                double y = Convert.ToDouble(Console.ReadLine());
                if (y > 0)
                {
                   
                    x[i] = y;
                    Console.WriteLine(i + ") " + x[i]);
                    i++;
                   
                }
            }
            //   Console.WriteLine(x);
            for (int j = 0; j < n; j++)
            {
                Console.Write(j + ")" + x[j]+" ");
            }
            Console.ReadLine();
        }
        static void lab_1_12()
        {
            const int n = 8; double s = 0; int j = 0;
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToDouble(Console.ReadLine());
                if (x[i]<0) { j=i; s = x[i]; }
            }
            Console.WriteLine(j + ") " + s);
            Console.ReadLine();
        }
        static void lab_1_13()
        {
            const int n = 10; const int n5 = 5; int j = 0; int g = 0;
            double[] x = new double[n]; double[] y = new double[n5]; double[] z = new double[n5];
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToDouble(Console.ReadLine());
                if (x[i] % 2 == 0)
                {
                    y[j] = x[i];
                    j++;
                }
                else
                {
                    z[g] = x[i];
                    g++;
                }
            }
            for (int l = 0; l < n5; l++)
            {
                Console.WriteLine(l + ") " + y[l] + " четное");
            }
            for (int l = 0; l < n5; l++)
            {
                Console.WriteLine(l + ") " + z[l] + " нечетное");
            }
            Console.ReadLine();
        }
        static void lab_2_5()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            int[] x = new int[n]; int max = -1000000; int min = 1000000;
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] > max)&&(x[i]<0)) { max = x[i]; } // -1 -5    -2 -3 -4 -5-(-1)+1 ((a-b)+1)*реверс знака
                if ((x[i] < min) && (x[i] < 0)) { min = x[i]; }
            }
            Console.WriteLine("max = "+max);//-1
            Console.WriteLine("min = "+min);//-5
            int kolvo = (min - max + 1)*-1;
            int[] y = new int[kolvo];
            int j = 0;
            while (max != min+1)
            {
                y[j] = max;
                Console.WriteLine(j + ") " + y[j]);
                max--;
                j++;
            }
         //   for (int i = min + 1; i < max; i++)
      //      {
       //         Console.WriteLine(i);
       //     }

            Console.ReadLine();
        }
        static void lab_2_6()
        {
            double max, middle, summa;
          int  size = Convert.ToInt16(Console.ReadLine());
            double[] myArray = new double[size];
            double[] myNewArray = new double[size];
            double number;
            for (int n = 0; n < size; n++)
            {
                myNewArray[n] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine();
            summa = 0; max = myNewArray[0];
            double delta;
            for (int n = 0; n < size; n++)
            {
                if (max < myNewArray[n]) max = myNewArray[n];
                summa += myNewArray[n];
            }
            delta = max;
            middle = summa / size;
            int middleIndex = 0;
            for (int n = 0; n < size; n++)
                if (Math.Abs(middle - myNewArray[n]) < delta)
                {
                    delta = Math.Abs(middle - myNewArray[n]);
                    middleIndex = n;
                }
            number = middle;
            Console.WriteLine(" Среднее элементов массива = {0}", middle);
            Console.WriteLine(" Ближайший к среднему элемент [{0}] = {1}", middleIndex, myNewArray[middleIndex]);
            double[] temp = new double[size];
            for (int n = 0; n < size; n++) temp[n] = myNewArray[n];
            myNewArray = new double[size + 1];
            for (int n = 0, m = 0; n < size; n++)
            {
                if (n == middleIndex + 1)
                {
                    myNewArray[m++] = number;
                    myNewArray[m++] = temp[n];
                }
                else myNewArray[m++] = temp[n];
            }
            Console.WriteLine();
            foreach (float a in myNewArray) Console.WriteLine(" {0}", a);
            Console.ReadLine();
        }
        static void lab_2_9()
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); double s = 0; 
            int[] x = new int[n]; int max = -1000000; int maxi = 0; int min = 1000000; int mini = 0;
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] > max)) { max = x[i]; maxi = i; } 
                if ((x[i] < min))  { min = x[i]; mini = i; }
            }
            Console.WriteLine("max " + max);
            Console.WriteLine("min " + min);
            for (int i = mini+1; i < maxi; i++)
            {
                s += x[i];
            }
            n = maxi - mini + 1;
            double f = s / (n-2);
            Console.WriteLine("Среднее арифметическое "+f);
            Console.ReadLine();
        }
        static void lab_2_10()
        {
            // Удалить минимальный среди положительных элементов массива
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); double s = 0;
            int[] x = new int[n]; int min = 1000000; int mini = 0;
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] < min)&&(x[i]>0)) { min = x[i]; mini = i; }
            }
            for (int i = mini; i < n-1; i++)
            {
                x[i] = x[i + 1];
            }
            for (int i = 0; i < (n-1) ; i++)
            {
                Console.WriteLine(i + ") " + x[i]);
            }
            Console.ReadLine();
        }
        static void lab_2_11()
        {
            // Включить заданный элемент P после последнего положительного элемента массива.
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); double s = 0;
            double[] x = new double[n]; double max = -1000000; int maxi = 0; 
            for (int i = 0; i < n-1; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] >max) && (x[i] > 0)) { max = x[i]; maxi = i; }
            }
            Console.Write("p = "); double p = Convert.ToDouble(Console.ReadLine());
            //1 2 3 4 5 -1 -3
            //1 2 3 4 5 6
            for (int i = n-2; i >= maxi+1; i--)
            {
                x[i+1] = x[i];
            }
            x[maxi + 1] = p;
            for (int i = 0; i < (n); i++)
            {
                Console.WriteLine(i + ") " + x[i]);
            }
            Console.ReadLine();
        }
        static void lab_2_13()
        {
            //Максимальный элемент массива среди элементов с четными
            //индексами заменить значением его индекса.
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); double s = 0;
            double[] x = new double[n]; double max = -1000000; int maxi = 0;
            for (int i = 0; i < n - 1; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] > max) & (i % 2 == 0)) { max = x[i]; maxi = i; }
            }
            for (int i = 0; i < n - 1; i++)
            {
                if (i == maxi)
                {
                    x[i] = maxi;
                }
            }
            max = maxi;
            for (int i = 0; i < n - 1; i++)
            {
                
                Console.WriteLine(i + ") " + x[i]);
            }
            Console.ReadLine();
        }
         //Пропустить и потом доделатт
        static void lab_2_15()
        {
            //Заданы массивы А и В, содержащие n и m элементов соответственно. Вставить массив В между k-м и (k + 1)-м элементами массива А (k задано).

        }
        static void lab_3_1()
        {
            //Найти все максимальные элементы одномерного массива (предполагается, что в массиве несколько одинаковых максимальных элементов)
            // за один проход исходного массива.Сформировать массив из их индексов
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); double s = 0; int j = 0;
            double[] x = new double[n]; double max = -1000000; int maxi = 0;
            double[] y = new double[n];
            for (int i = 0; i < n ; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
                if ((x[i] > max))
                {
                    max = x[i];
                    maxi = i;
                    for (int l = j; l >= 0; l--)
                    {
                        y[l] = 0;
                    }
                    j = 0;
                    //обнуляем массив индексов так как нашли новый максимальный элемент
                }
                if ((x[i] == max)) {
                    max = x[i];
                    maxi = i;
                    //обнулить у
                    y[j] = maxi;
                    j++;
                    //Добавляем индекс максимального числа
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
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            double[] x = new double[n]; 
            double[] y = new double[n];
            for (int o = 0; o < n; o++)
            {
                x[o] = Convert.ToInt16(Console.ReadLine());
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (( i %   2 ==0) && (x[i] > x[j]) && (j %2 == 0)) //Если левый > правого -> делаем свап 100 1 2 3 4  
                    {
                         //        Console.WriteLine("Original x[i] and x[j] " + x[i] + " " + x[j]);
                        double t = x[i];
                        x[i] = x[j];
                        x[j] = t;
                         //     Console.WriteLine("Dev x[i] and x[j] and t " + x[i] + " " + x[j]+" "+t);
                    }
                }
            }
            for (int k = 0; k < n; k++)
            {
                Console.WriteLine(k+") "+x[k]);
            }
            Console.ReadLine();
        }
        static void lab_3_8()
        {
            //Упорядочить по убыванию отрицательные элементы массива,
            // сохраняя остальные элементы на прежних местах

            
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            double[] x = new double[n]; 
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
            }
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
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
            }
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
            double globalMax=-1000; double globalMin=1000;
            double x=1; 
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
            for (int i = 0; i <= (n-3); i++)
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
        //Не решил надо подумать
        static void lab_3_12()
        {
            ///
            // Из массива размером 12 удалить все отрицательные элементы. 
        }
        static void lab_3_13()
        {
            // Из массива удалить повторяющиеся элементы
            Console.Write("n = ");   int n = Convert.ToInt16(Console.ReadLine());
            int[] array = new int[n];
            for (int l = 0; l < n; l++)
            {
                array[l] = Convert.ToInt16(Console.ReadLine());

            }
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

            for (int l = 0; l < n-numDups; l++)
            {
                Console.WriteLine(array[l]); 

            }
            Console.ReadLine();
        }
        static void lab_0_11()
        {
            int counter;
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.Write("x = ");
            int X = Convert.ToInt32(Console.ReadLine());
             int binPoisk(int b)
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
            Console.WriteLine(binPoisk(X)+") "+X);
            Console.ReadLine();
        }
        static void lab_0_12()
        {
            Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = "); int m = Convert.ToInt32(Console.ReadLine());
            if (n > m) { n = m; } else m = n;
            int[] arr1 = new int[n];
            Console.WriteLine("X) ");
            for (int l = 0; l < n; l++)
            {
                arr1[l] = Convert.ToInt32(Console.ReadLine());
            }
            int n1 = arr1.Length;
            int[] arr2 = new int[m];
            Console.WriteLine("Y) ");
            for (int l = 0; l < n; l++)
            {
                arr2[l] = Convert.ToInt32(Console.ReadLine());
            }
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];
            DoMerge(arr1, arr2, n1, n2, arr3);

            Console.WriteLine("Массив после слияния");
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
            Console.ReadLine();
        }
        static void DoMerge(int[] arr1, int[] arr2,
                           int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;
            while (i < n1 && j < n2)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];
            }
            while (i < n1)
                arr3[k++] = arr1[i++];
            while (j < n2)
                arr3[k++] = arr2[j++];
        }
        //Не решил надо подумать
        static void lab_0_13()
        {
            Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m = "); int m = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n + m];
           
        }
        static void lab_0_14()
        {
            Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            for (int l = 0; l < n; l++)
            {
                arr1[l] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0, j = n - 1; i < j; i++, j--)
            {
               int t = arr1[i];
                arr1[i] = arr1[j];
                arr1[j] = t;
            }
            for (int i = 0; i<n;i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadLine();
        }
        static void lab_0_15()
        {
            Console.Write("n = "); int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int l = 0; l < n; l++)
            {
                a[l] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("m = "); int m = Convert.ToInt32(Console.ReadLine());
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
