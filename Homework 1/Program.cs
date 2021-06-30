/*ДЗ 1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.Программа должна сосчитать количество введенных пользователем пробелов.
ДЗ 2. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот.
ДЗ 3. Даны целые положительные числа A и B (A<B). Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению.Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
3 3 3
4 4 4 4
5 5 5 5 5
6 6 6 6 6 6
7 7 7 7 7 7 7
ДЗ 4.Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив общие элементы первых двух массивов без повторений.
ДЗ 5. Пользователь вводит строку. Проверить, является ли эта строка палиндромом. Палиндромом называется строка, которая одинаково читается слева направо и справа налево.
ДЗ 6. Подсчитать количество слов во введенном предложении.*/

using System;

namespace Homework_1
{
    class Program
    {
        static void Main()
        {
//ДЗ 1.  -------------------------------------------------------------------------------------------------------------------------------
            /*char key;
            int count_space = 0;
            Console.Write("Введите символы: ");
            do
            { 
                key = Console.ReadKey().KeyChar;
                if (key == ' ')
                    count_space++;
            }
            while (key != '.');
            Console.WriteLine();
            Console.Write("Количество пробелов: ");
            Console.WriteLine($"{count_space}");
//ДЗ 2.  -------------------------------------------------------------------------------------------------------------------------------
            int down = 0;
            int up = 0;
            char symbolChar = ' ';
            Console.WriteLine("Введите маленькие и большие буквы:");
            while (symbolChar != '.')
            {
                var symbol = Console.Read();
               
                if (symbol >= 'A' && symbol <= 'Z' || symbol >= 'А' && symbol <= 'Я')
                {
                    symbol += 32;
                    ++down;
                }
                else if (symbol >= 'a' && symbol <= 'z' || symbol >= 'а' && symbol <= 'я')
                {
                    symbol -= 32;
                    ++up;
                }
                symbolChar = (char)symbol;
                Console.Write(symbolChar);            
            }
            Console.WriteLine();
            Console.Write("Количество измененных символов: ");
            Console.WriteLine($"{down + up}");*/
//ДЗ 3.  -------------------------------------------------------------------------------------------------------------------------------
            /*int a, b;
            Console.WriteLine("Введите числа A < B: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (a <= b)
            {
                for (int i = 0; i < a; i++)
                    Console.Write($"{a}");
                Console.WriteLine();
                a++;
            }*/
//ДЗ 4.  ----------------------------------------------------------------------------------------------------------------------------
            const int m = 8;
            const int n = 6;
            int[] arrayM = new int[m] { 2, 2, 4, 5, 6, 7, 8, 9 };
            int[] arrayN = new int[n] { 2, 2, 4, 5, 6, 7 };
            int size = 0;
            RandomArray(arrayM);
            PrintArray(arrayM);
            RandomArray(arrayN);
            PrintArray(arrayN);
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (arrayM[i] == arrayN[j]) size++;
                }
            }            
            Console.Write("Размер выделяемой памяти для третьего массива: ");
            Console.WriteLine(size);
            int[] arrayC = new int[size];
            int povtor = 0;
            int it = 0;
            
            for (int i = 0; i < m; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (arrayM[i] == arrayN[j])
                    {
                        for (int k = 0; k < size; k++)
                        {
                            if (arrayC[k] == arrayN[j]) povtor++;
                        }                       
                        if (povtor == 0)
                        {
                            arrayC[it] = arrayN[j];
                            it++;
                        }
                        povtor = 0;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arrayC[i]}");
            }
            Console.WriteLine();

        }
        static void RandomArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
        }
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }
//ДЗ 5.  ----------------------------------------------------------------------------------------------------------------------------
    }
}
