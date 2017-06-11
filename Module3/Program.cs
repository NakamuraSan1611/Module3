using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3
{
    class Program
    {
        static void Main(string[] args)
        {

            //•	Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. 
            //Программа должна сосчитать количество введенных пользователем пробелов.
            //(Подсказка.IF, Length

            void task1()
            {
                Console.WriteLine("Ввод до точки");
                while (true)
                {
                    if (Console.Read() == '.')
                    {
                        Console.WriteLine("точка детектед");
                        break;
                    }
                    else
                        continue;
                }
                Console.ReadKey();
            }

            //•Ввести с клавиатуры номер трамвайного билета(6 - значное число) и проверить является ли данный билет 
            //счастливым(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, 
            //то этот билет считается счастливым).
            //(Подсказка.SUBSTRING, LENGTH)

            void task2()
            {
                Console.WriteLine("Введите 6 цифр билета");
                string str = Console.ReadLine();
                if (str.Length == 6)
                {
                    int sum1 = Int32.Parse(str.Substring(0, 3));
                    int sum2 = Int32.Parse(str.Substring(3));
                    if (sum1 == sum2)
                        Console.WriteLine("У Вас Счастливый билет");
                    else
                        Console.WriteLine("у тебя обычный билет нищеброд");

                }
                else
                    Console.WriteLine("Читай внимательнее");
                Console.ReadKey();
            }

            //•	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений 
            //символов верхнего регистра на величину 32.Используя эту информацию, написать программу, 
            //которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы 
            //верхнего регистра и наоборот.
            //(Без подсказки – легче легкого)

            void task3()
            {
                Console.WriteLine("Введите буквы разным регистром: ");
                string str = Console.ReadLine();
                char[] charArray = str.ToCharArray();
                for (int i = 0; i < charArray.Length; i++)
                {
                    if ((int)charArray[i] >= 65 && (int)charArray[i] <= 90)
                        charArray[i] += (char)32;
                    else
                        charArray[i] -= (char)32;
                }
                Console.WriteLine(charArray);
                Console.ReadKey();
            }
            //•	Даны целые положительные числа A и B(A < B).Вывести все целые числа от A до B включительно; 
            //каждое число должно выводиться на новой строке; при этом каждое число должно выводиться 
            //количество раз, равное его значению. Например: если А = 3, а В = 7, то программа должна 
            //сформировать в консоли следующий вывод:
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            void task4()
            {
                Console.WriteLine("Введите первое число:");
                int A = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Введите второе число (больше первого):");
                int B = Int32.Parse(Console.ReadLine());
                if (A < B)
                {
                    for (int i = A; i <= B; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i);
                            Console.Write(" ");
                        }
                        Console.Write("\n");
                    }
                }
                else
                    Console.WriteLine("Второе не больше первого!");
                Console.ReadKey();
            }

            //•	Дано целое число N(> 0), найти число, полученное при прочтении числа N справа налево. 
            //Например, если было введено число 345, то программа должна вывести число 543.
            void task5()
            {
                Console.WriteLine("Введите число");
                string numS = Console.ReadLine();
                char[] charArray = numS.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(charArray);
                Console.ReadKey();
            }

            //•	Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца) 
            //дробных чисел с именем B.Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, 
            //а двумерный массив В случайными числами с помощью циклов. Вывести на экран значения массивов: массива А 
            //в одну строку, массива В — в виде матрицы.Найти в данных массивах общий максимальный элемент, минимальный 
            //элемент, общую сумму всех элементов, общее произведение всех элементов, сумму четных элементов массива А, 
            //сумму нечетных столбцов массива В.
            void task6()
            {
                Console.WriteLine("Введите через Enter 5 элементов первого массива: ");
                int[] A = new int[5];
                int[,] B = new int[3, 4];
                for (int i = 0; i < 5; i++)
                {
                    A[i] = Int32.Parse(Console.ReadLine());
                }
                Console.WriteLine("\nПервый массив\n");
                int Amax = A[0], Bmax = A[0], Amin = A[0], Bmin = A[0];
                int Asum = 0, Aeven = 0, Bsum = 0, Bodd = 0;
                decimal Amult = 1, Bmult = 1;
                for (int i = 0; i < 5; i++)
                {
                    if (A[i] > Amax)
                        Amax = A[i];
                    if (A[i] < Amin)
                        Amin = A[i];
                    Amult *= A[i];
                    Asum += A[i];
                    if (A[i] % 2 == 0)
                        Aeven += 1;
                    Console.Write("{0}\t", A[i]);
                }
                Console.WriteLine("\n\nВторой массив\n");
                Random ran = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        B[i, j] = ran.Next(0, 20);
                        if (B[i, j] > Bmax)
                            Bmax = B[i, j];
                        if (B[i, j] < Bmin)
                            Bmin = B[i, j];

                        Bmult *= B[i, j];
                        Bsum += B[i, j];
                        if (B[i, j] % 2 != 0)
                            Bodd += 1;
                        Console.Write("{0}\t", B[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\nРезультаты сложнейших математических вычислений анализа\n");
                decimal mult = Amult * Bmult;
                Console.WriteLine("Сумма всех " + (Asum + Bsum) + " Произведение всех " + mult);
                Console.WriteLine("Минимальный и максимальный в A: " + Amin + " " + Amax);
                Console.WriteLine("Минимальный и максимальный в B: " + Bmin + " " + Bmax);
                Console.WriteLine("Сумма четных в А: " + Aeven);
                Console.WriteLine("Сумма нечетных в B: " + Bodd);
                Console.ReadKey();
            }

            //•	Даны 2 массива размерности M и N соответственно. 
            //Необходимо переписать в третий массив общие элементы первых двух массивов без повторений. 
            void task7()
            {
                Random rand = new Random();
                int M = rand.Next(10, 20);
                int N = rand.Next(10, 20);
                int[] arr1 = new int[M];
                int[] arr2 = new int[N];
                Console.WriteLine(rand.Next(0, 20));
                Console.WriteLine("\nПервый рандомный массив\n");
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr1[i] = rand.Next(0, 20);
                    Console.Write(arr1[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("\nВторой рандомный массив\n");
                for (int i = 0; i < arr2.Length; i++)
                {
                    arr2[i] = rand.Next(0, 20);
                    Console.Write(arr2[i] + " ");
                }
                Console.WriteLine("\n\nТретий массив с общими без повторений\n");
                if (M > N)
                {
                    int[] arr3 = new int[M];
                    int common = 0;
                    for (int i = 0; i < arr2.Length; i++)
                    {
                        for (int j = 0; j < arr1.Length; j++)
                        {
                            if (arr2[i] == arr1[j])
                            {
                                int count = 0;
                                for (int k = 0; k < arr3.Length; k++)
                                {
                                    if (arr2[i] == arr3[k])
                                    {
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {
                                    arr3[common] = arr2[i];
                                    Console.Write(arr3[common] + " ");
                                    common++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    int[] arr3 = new int[N];
                    int common = 0;
                    for (int i = 0; i < arr1.Length; i++)
                    {
                        for (int j = 0; j < arr2.Length; j++)
                        {
                            if (arr1[i] == arr2[j])
                            {
                                int count = 0;
                                for (int k = 0; k < arr3.Length; k++)
                                {
                                    if (arr1[i] == arr3[k])
                                    {
                                        count++;
                                    }
                                }
                                if (count == 0)
                                {
                                    arr3[common] = arr1[i];
                                    Console.Write(arr3[common] + " ");
                                    common++;
                                }
                            }
                        }
                    }
                }
                Console.ReadKey();
            }
            //•	Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
            //Определить сумму элементов массива, расположенных между минимальным и максимальным элементами
            //Подсказка – Random rnd = new Random, rnd.Next(1, 15).
            void task8()
            {
                Random rand = new Random();
                int[,] arr = new int[5, 5];
                int[] arr2 = new int[25];
                int max = arr[0, 0], min = arr[0, 0];
                int count = 0, index1 = 0, index2 = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        arr2[count] = arr[i, j] = rand.Next(-100, 100);
                        Console.Write(arr[i, j] + "\t");
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            index1 = count;
                        }
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                            index2 = count;
                        }
                        count++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Максимальное число = " + max);
                Console.WriteLine("Минимальное число = " + min);
                int sum = 0;
                if (index1 > index2)
                {
                    for (int i = index2; i <= index1; i++)
                    {
                        sum += arr2[i];
                    }
                }
                else
                {
                    for (int i = index1; i <= index2; i++)
                    {
                        sum += arr2[i];
                    }
                }

                Console.WriteLine("Сумма между минимальным и максимальным = " + sum);
                Console.ReadKey();
            }


            //•	Пользователь вводит строку.Проверить, является ли эта строка палиндромом.
            //Палиндромом называется строка, которая одинаково читается слева направо и справа налево. 
            //Подсчитать количество слов во введенном предложении. 
            void task9()
            {
                Console.WriteLine("Введите палиндром: ");
                string str = Console.ReadLine();
                str = str.Replace(" ", String.Empty).Replace(",", String.Empty).Replace(".", String.Empty).Replace("!", String.Empty).Replace("?", String.Empty).Replace("-", String.Empty);
                if (str.ToLower().SequenceEqual(str.ToLower().Reverse()))
                    Console.WriteLine("Это палиндром!");
                else
                    Console.WriteLine("блин, просил же полиндром");
                Console.ReadKey();
            }
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите номер задания (1-9): ");
                string taskS = Console.ReadLine();
                int taskI;
                int.TryParse(taskS, out taskI);
                switch (taskI)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                    case 3:
                        task3();
                        break;
                    case 4:
                        task4();
                        break;
                    case 5:
                        task5();
                        break;
                    case 6:
                        task6();
                        break;
                    case 7:
                        task7();
                        break;
                    case 8:
                        task8();
                        break;
                    case 9:
                        task9();
                        break;
                    default:
                        Console.WriteLine("Неправильное задание");
                        break;
                }
            }
        }
    }
}
