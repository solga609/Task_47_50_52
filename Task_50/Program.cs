// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет 


            int[,] arr = {{ 1, 2, 3, 4 }, { 5, 6, 7, 8}}; 
            Console.WriteLine("Введите искомое число: ");
            int x = Convert.ToInt32(Console.ReadLine()); 
            int m=0, n=0;
            bool f = false;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (x == arr[i, j]) { m = i;n = j;f = true; };
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            if (f)
                Console.WriteLine($"Число найдено. Строка {m+1} Столбец {n+1}");
            else
                Console.WriteLine("Число не найдено");
 
            Console.ReadKey();
