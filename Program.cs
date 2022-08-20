void Zadacha47()
{
    //Задача 47: Задайте двумерный массив размером m×n, 
    //заполненный случайными вещественными числами, округлёнными до одного знака.

    Random random = new Random();
    int m = random.Next(4, 8);
    int n = random.Next(4, 8);
    double[,] array = new double[m, n];
    void FillArrayDouble(double[,] array)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10;
            }
        }
    }
    FillArrayDouble(array);
    void PrintArray(double[,] array)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                double number = Math.Round(array[i, j], 1);
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
    PrintArray(array);
}

void Zadacha50()
{
    //Задача 50: Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.

    Console.Write("Введите строку:");
    int number1 = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите столбец:");
    int number2 = Convert.ToInt32(Console.ReadLine()) - 1;
    Random random = new Random();
    int rows = 3;
    int columns = 4;
    int[,] array = new int[rows, columns];
    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(0, 10);
            }
        }
    }
    FillArray(array);
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + ", ");
            }
            Console.WriteLine();
        }
    }
    PrintArray(array);

    if (number1 < 0 | number1 > rows - 1 | number2 < 0 | number2 > columns - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[number1, number2]);
    }
    Console.ReadLine();
}

void Zadacha52()
{
    //Задача 52: Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.

    Random random = new Random();
    int rows = random.Next(4, 5);
    int columns = random.Next(4, 5);
    int[,] array = new int[rows, columns];
    void FillArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(0, 10);
            }
        }
    }
    FillArray(array);
    void PrintArray(int[,] array)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + ", ");
            }
            Console.WriteLine();
        }
    }
    PrintArray(array);
    Console.WriteLine();

    void Kadiir(int[,] array)
    {
        for (int j = 0; j < columns; j++)
        {
            double sum = 0;
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, j];
            }
            Console.WriteLine(sum /= rows);
        }
    }
    Kadiir(array);
}


//Zadacha47();
//Zadacha50();
//Zadacha52();