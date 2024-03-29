﻿// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа кратные 3-ём в промежутке от M до N.
// M = 1; N = 9. -> "3, 6, 9"
// M = 13; N = 20. -> "15, 18"

Console.WriteLine("Задача 64. Задайте значения M и N. Напишите программу,");
Console.WriteLine("которая выведет все натуральные числа кратные Num в промежутке от M до N.");

Console.WriteLine("Введите M:");
int task64VariableM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int task64VariableN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Num:");
int task64VariableNum = Convert.ToInt32(Console.ReadLine());

void MultiplicityNum(int variableM, int variableN, int num)
{ 
    // переменная для вывода значений по установленному образцу
    int writeIndex = 0;

    // проверяем кратность и выводим найденные значения
    for(int i = variableM; i < variableN + 1; i++)
    {
        if(i % num == 0)
        {
            if(writeIndex == 1)
            {
                Console.Write(", ");
                writeIndex = 0;
            }
            
            Console.Write(i);
            writeIndex++;
        }
        if(i == variableN)
        {
            Console.Write("\" ");
        }
    }
}

Console.WriteLine("Числа кратные " + task64VariableNum + ":");
Console.Write("M = " + task64VariableM + " ; N = " + task64VariableN);
Console.Write(". -> \"");
MultiplicityNum(task64VariableM, task64VariableN, task64VariableNum);

Console.WriteLine();
Console.WriteLine();


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Задача 66. Задайте значения M и N. Напишите программу,");
Console.WriteLine("которая найдёт сумму натуральных элементов в промежутке от M до N.");

Console.WriteLine("Введите M:");
int task66VariableM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int task66VariableN = Convert.ToInt32(Console.ReadLine());

int NaturalNumSum(int variableM, int variableN)
{ 
    int sum = 0;
    
    for(int i = variableM; i < variableN + 1; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write("M = " + task66VariableM + " ; N = " + task66VariableN);
Console.Write(". -> ");

Console.WriteLine(NaturalNumSum(task66VariableM, task66VariableN));

Console.WriteLine();
Console.WriteLine();


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(n,m) = 29

Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.");
Console.WriteLine(" Даны два неотрицательных числа m и n.");

Console.WriteLine("Введите m:");
int task68VariableM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int task68VariableN = Convert.ToInt32(Console.ReadLine());


int AckermanAlgorithm(int variableM, int variableN)
{
    if (variableM == 0)
    {
      return variableN + 1;
    }
    else
    {
        if ((variableM != 0) & (variableN == 0))
        {
            return AckermanAlgorithm(variableM - 1, 1);
        }
        else
        {
            return AckermanAlgorithm(variableM - 1, AckermanAlgorithm(variableM, variableN - 1));
        }
    }     
}

Console.WriteLine("Функция Аккермана: " + AckermanAlgorithm(task68VariableM, task68VariableN));
Console.WriteLine();
Console.WriteLine();

// Практическая работа № 10

// 1. Дано число n. Получите число, записанное в обратном порядке.
// 345 >> 543
// 81 >> 18

Console.WriteLine("1. Дано число n. Получите число, записанное в обратном порядке.");
Console.WriteLine("Введете число n:");
int lesson10task1VariableN = Convert.ToInt32(Console.ReadLine());

void ReverseNum(int num)
{
    Console.Write(num % 10);
    num = num / 10;
    if(num > 0)
    {
        ReverseNum(num);
    }
    
}
Console.Write(lesson10task1VariableN + " >> ");
ReverseNum(lesson10task1VariableN);
Console.WriteLine();
Console.WriteLine();


// 2. Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз: 
// 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.
// m = 5 >> 1, 2, 2, 3, 3

Console.WriteLine("Дана монотонная последовательность, в которой каждое натуральное число n встречается ровно n раз:");
Console.WriteLine("1, 2, 2, 3, 3, 3, 4, 4, 4, 4, ... Дано число m. Выведите первые m членов этой последовательности.");
Console.WriteLine("m = 5 >> 1, 2, 2, 3, 3");

Console.WriteLine("Введите M:");
int lesson10task2VariableM = Convert.ToInt32(Console.ReadLine());

void MonotonicSequence(int M, int index, int count)
{
    for(int i = 0; i < index; i++)
    {
        if(count < lesson10task2VariableM)
        {
            Console.Write(index + " ");
            count++;
        }
        
    }
    index++;
    if(count < lesson10task2VariableM)
    {
        MonotonicSequence(lesson10task2VariableM, index, count);
    }
}

Console.Write(lesson10task2VariableM + " >> ");
MonotonicSequence(lesson10task2VariableM, 1, 0);
Console.WriteLine();
Console.WriteLine();

// 3. Дано натуральное число n > 1. Вывести все простые множители данного числа.
// 10 >> 5, 2.
// 12 >> 2, 2, 3.

Console.WriteLine("Практическая работа № 10. Задача № 3");
Console.WriteLine("Дано натуральное число n > 1. Вывести все простые множители данного числа");

Console.WriteLine("Введите n:");
int lesson10task3VariableN = Convert.ToInt32(Console.ReadLine());
while(lesson10task3VariableN < 1)
{
    Console.WriteLine("Ошибка! Число n должно быть больше 1!");
    int lesson10task3VariableNTemp = Convert.ToInt32(Console.ReadLine());
    lesson10task3VariableN = lesson10task3VariableNTemp;
}

// // Решение без рекурсии
// /*
// void PrimeFactorNum(int num)
// {
//     for(int i = 1; i < num + 1; i++)
//     {
//         if(num % i == 0)
//         {
//             Console.WriteLine(i);
//         }
//     }
// }

// PrimeFactorNum(lesson10task3VariableN);
// */

// // Решение с рекурсией

void PrimeFactorNumRec(int num, int index)
{
    if(num % index == 0)
    {
        Console.Write(index + " ");
    }
    index++;
    if(index <= num)
    {
        PrimeFactorNumRec(num, index);
    }  
}

Console.Write(lesson10task3VariableN + " >> ");
PrimeFactorNumRec(lesson10task3VariableN, 1);
Console.WriteLine();
Console.WriteLine();

// Практическая работа № 11

// // Задача 1. На вход подуются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].

Console.WriteLine("Задача 1. На вход подуются два числа n и m, такие, что n<m.");
Console.WriteLine("Заполните массив случайными числами из промежутка [n, m]");

Console.WriteLine("Введите количество элементов в массиве:");
int lesson9Task1ArraySize = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n:");
int lesson9Task1VariableN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m:");
int lesson9Task1VariableM = Convert.ToInt32(Console.ReadLine());
while(lesson9Task1VariableN >= lesson9Task1VariableM)
{
    Console.WriteLine("Ошибка, m должно быть больше чем n! Введите m:");
    int lesson9Task1VariableMTemp = Convert.ToInt32(Console.ReadLine());
    lesson9Task1VariableM = lesson9Task1VariableMTemp;
}

int[] randomArrayCreate(int variableN, int variableM, int arraySize)
{
    //задаем массив
    int[] randomArray = new int[arraySize];
    
    //заполняем массив случайными числами от 100 до 999
    for(int i = 0; i < arraySize; i++)
    {
        randomArray[i] = new Random().Next(variableN, variableM + 1);
    }

    //выводим массив
    return randomArray;
}

int[] showArray = randomArrayCreate(lesson9Task1VariableN, lesson9Task1VariableM, 10);
for(int i = 0; i < lesson9Task1ArraySize; i++)
{
    Console.Write(showArray[i] + " ");
}

Console.WriteLine();
Console.WriteLine();

// Задача 2. Двумерный массив заполнен случайными натуральными числами от 1 до 10. 
// Найдите количество элементов, значение которых больше 5, и их сумму.

Console.WriteLine("Двумерный массив заполнен случайными натуральными числами от 1 до 10");
Console.WriteLine("Найдите количество элементов, значение которых больше 5, и их сумму");

int[,] CreateTwoDimensionalrandomArray(int arraySizeM, int arraySizeN, int  rangeFrom, int rageTo)
{
    // задаем массив
    int[,] twoDimensionalArray = new int[arraySizeM, arraySizeN];
    
    // заполняем массив случайными числами
    for(int i = 0; i < arraySizeM; i++)
    {
        for(int j = 0; j < arraySizeN; j++)
        {
            twoDimensionalArray[i,j] = new Random().Next(rangeFrom, rageTo + 1);
        }
    }

    // возвращаем массив
    return twoDimensionalArray;
}

// считаем количество элементов больше num
int countArrayGraiterNum(int num, int[,] twoDimensionalRandomArray)
{
    int sum = 0;
    
    for(int i = 0; i < twoDimensionalRandomArray.GetLength(0); i++)
    {
        for(int j = 0; j < twoDimensionalRandomArray.GetLength(1); j++)
        {
            if(twoDimensionalRandomArray[i,j] > 5)
            {
                sum++;
            }
        }
    }
    return sum;
}

// печатаем массив в консоль
Console.Write("Массив, заполненый случайными натуральными числами:");
int[,] printArray = CreateTwoDimensionalrandomArray (4, 4, 1, 10);
for(int i = 0; i < 4; i++)
{
    Console.WriteLine();
    for(int j = 0; j < 4; j++)
    {
        Console.Write(printArray[i,j] + " ");
    }
}


Console.WriteLine();
Console.WriteLine("Количество искомых элементов:");
Console.WriteLine(countArrayGraiterNum(5, printArray));

Console.WriteLine();
Console.WriteLine();

// Задача 3. Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет.

Console.WriteLine("Введите год для проверки:");
int year = Convert.ToInt32(Console.ReadLine());

string leapYear(int year)
{
    if(year % 100 == 0)
    {
        if(year % 400 == 0 ) return "Високосный"; 
        else return "Не високосный";
    } 
    else 
    {
        if(year % 4 == 0 ) return "Високосный"; 
        else return "Не високосный";
    }    
}

Console.WriteLine(leapYear(year));
Console.WriteLine();
Console.WriteLine();

/*// Task 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
Console.WriteLine("Задача № 34. Зададим массив, заполненный случайными положительными трёхзначными числами:");
Console.WriteLine("И посчитаем количество чётных чисел в массиве:");

Console.WriteLine("Введите колличество элементов в массиве:");
int task34Variable1 = Convert.ToInt32(Console.ReadLine());

void Method1Task34()
{

    //задаем массив
    int[] task34Array = new int[task34Variable1];
    
    //заполняем массив случайными числами от 100 до 999
    for(int i = 0; i < task34Variable1; i++)
    {
        task34Array[i] = new Random().Next(100,999);
    }

    //счётчик
    int count = 0;

    //считаем колличество чётных чисел в массиве
    for(int i = 0; i < task34Variable1; i++)
    {
        if(task34Array[i] % 2 == 0)
        {
            count++;
        }
    }

    //выводим массив
    for(int i = 0; i < task34Variable1; i++)
    {
        Console.Write(task34Array[i] + " ");
    }

    //вывоводим количество чётных элементов массива
    Console.WriteLine();
    Console.Write("Количество чётных элементов в массиве = " + count);
}

Method1Task34();
Console.WriteLine();
Console.WriteLine();

// Task 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("Задача № 36. Зададим массив, заполненный случайными числами");
Console.WriteLine("Найдём сумму элементов, стоящих на нечётных позициях");

Console.WriteLine("Введите колличество элементов в массиве:");
int task36Variable1 = Convert.ToInt32(Console.ReadLine());

void Method1Task36()
{

    //задаем массив
    int[] task36Array = new int[task36Variable1];
    
    //заполняем массив случайными числами от -9 до 9
    for(int i = 0; i < task36Variable1; i++)
    {
        task36Array[i] = new Random().Next(-9,9);
    }

    //считаем сумму
    int sum = 0;

    //суммируем элементы на нечётных позициях
    for(int i = 0; i < task36Variable1; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + task36Array[i];
        }
    }

    //выводим массив
    for(int i = 0; i < task36Variable1; i++)
    {
        Console.Write(task36Array[i] + " ");
    }

    //вывоводим сумму элементов на нечётных позициях
    Console.WriteLine();
    Console.Write("Сумма элементов, стоящих на нечётных позициях = " + sum);
}

Method1Task36();
Console.WriteLine();
Console.WriteLine();

// Task 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задача № 38. Зададим массив, заполненный случайными вещественными числами");
Console.WriteLine("Найдём разницу между максимальным и минимальным элементов массива");

Console.WriteLine("Введите колличество элементов в массиве:");
int task38Variable1 = Convert.ToInt32(Console.ReadLine());

void Method1Task38()
{
    //задаем массив
    double[] task38Array = new double[task38Variable1];
    
    //заполняем массив случайными числами
    for(int i = 0; i < task38Variable1; i++)
    {
        task38Array[i] = new Random().Next(-999, 999) + new Random().NextDouble();
    }

    double max = 0;
    double min = 0;

    //определяем из двух первых элементов минимальный и максимальный
    //и записываем в в min и max соответственно
    if(task38Array[0] > task38Array[1])
    {
        max = task38Array[0];
        min = task38Array[1];
    }
    else
    {
        max = task38Array[1];
        min = task38Array[0];
    }

    //сравниваем элементы массива, начиная с третьего
    //с min и max
    //и записываем в в min и max соответственно
    for(int i = 2; i < task38Variable1; i++)
    {
        if(task38Array[i] > max)
        {
            max = task38Array[i];
        }
        else
        {
            if(task38Array[i] < min)
            {
                min = task38Array[i];
            }
        }
    }

    //выводим массив
    for(int i = 0; i < task38Variable1; i++)
    {
        Console.Write(task38Array[i] + " ");
    }

    //разница между максимальным и минимальным элементами массива
    Console.WriteLine();
    Console.WriteLine("Разница между максимальным и минимальным элементами массива = " + (max - min));
}

Method1Task38();
Console.WriteLine();
Console.WriteLine();

// Task 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

void Method1Task41()
{
    Console.WriteLine("Задача № 41");
    Console.WriteLine("Введите число М:");
    int task41VariableМ = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите с клавиатуры " + task41VariableМ + " чисел");
    //задаем массив
    int[] task34Array = new int[task41VariableМ];
    
    //счётчик
    int count = 0;

    //заполняем массив и считаем количество элементов больше 0
    for(int i = 0; i < task41VariableМ; i++)
    {
        task34Array[i] = Convert.ToInt32(Console.ReadLine());
        if(task34Array[i] > 0)
        {
            count++;
        }
    }

    //выводим ответ
    Console.WriteLine("Посчитаем, сколько чисел больше 0 мы ввели:");

    for(int i = 0; i < task41VariableМ; i++)
    {
        Console.Write(task34Array[i]);
        if(i == task41VariableМ - 1)
        {
             Console.Write(" -> " + count);
        }
        else
        {
             Console.Write(", ");
        }
    }

}

Method1Task41();
Console.WriteLine();
Console.WriteLine();

// Task 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Method1Task43()
{
    Console.WriteLine("Задача № 43. Пересекающиеся прямые");
    Console.WriteLine("Введите число k1:");
    int task41Variablek1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число k2:");
    int task41Variablek2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b1:");
    int task41Variableb1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число b2:");
    int task41Variableb2 = Convert.ToInt32(Console.ReadLine());

    for(double x = -999; x < 999; x = x + 0.1)
    {
        x = Math.Round(x, 2);

        if((task41Variablek1 * x + task41Variableb1) == (task41Variablek2 * x + task41Variableb2))
        {
            Console.Write("b1= " + task41Variableb1 + ", k1= " + task41Variablek1);
            Console.Write(", b2= " + task41Variableb2 + ", k2= " + task41Variablek2);
            Console.Write(" -> (" + x + "; " + (task41Variablek1 * x + task41Variableb1) + ")");
            break;
        }
        else
        {
            if(x == 998.9)
            {
                Console.Write("Прямые не пересекаются");
            }
        }
    }
}

Method1Task43();
Console.WriteLine();
Console.WriteLine();

// Task 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

 void Method1Task47()
{
    Console.WriteLine("Задача № 47. Задайте двумерный массив размером m х n, заполненный случайными вещественными числами");
    Console.WriteLine("Введите m:");
    int task47VariableM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int task47VariableN = Convert.ToInt32(Console.ReadLine());

    //задаем массив
    double[,] task47Array = new double[task47VariableM, task47VariableN];
    
    //заполняем массив случайными числами
    for(int i = 0; i < task47VariableM; i++)
    {
        for(int j = 0; j < task47VariableN; j++)
        {
            task47Array[i,j] = new Random().Next(-9, 9) + new Random().NextDouble();;
        }
    }
   
    //выводим массив
    for(int i = 0; i < task47VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task47VariableN; j++)
        {
            Console.Write(task47Array[i,j] + " ");
        }
    }
}

Method1Task47();
Console.WriteLine();
Console.WriteLine();

// Task 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//          и возвращает значение этого элемента или же указание, что такого элемента нет.

void Method1Task50()
{
    Console.WriteLine("Задача № 50");
    Console.WriteLine("Введите число строк m:");
    int task50VariableM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите столбцов n:");
    int task50VariableN = Convert.ToInt32(Console.ReadLine());

    //задаем массив
    int[,] task50Array = new int[task50VariableM, task50VariableN];
    
    //заполняем массив случайными числами
    for(int i = 0; i < task50VariableM; i++)
    {
        for(int j = 0; j < task50VariableN; j++)
        {
            task50Array[i,j] = new Random().Next(0,9);
        }
    }
   
    //выводим массив
    for(int i = 0; i < task50VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task50VariableN; j++)
        {
            Console.Write(task50Array[i,j] + " ");
        }
    }

    Console.WriteLine();
    Console.WriteLine("Введите номер строки m:");
    int task50VariableM2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите номер столбца n:");
    int task50VariableN2 = Convert.ToInt32(Console.ReadLine());

    //выводим элемент m-ой строки и n-го столбца
    Console.WriteLine("Выбранный элемент:");
    Console.Write(task50Array[task50VariableM2 - 1, task50VariableN2 - 1]);   
}

Method1Task50();
Console.WriteLine();
Console.WriteLine();

// Task 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Method1Task52()
{
    Console.WriteLine("Задача № 52");
    Console.WriteLine("Введите m:");
    int task52VariableM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int task52VariableN = Convert.ToInt32(Console.ReadLine());

    //задаем массив
    int[,] task52Array = new int[task52VariableM, task52VariableN];
    
    //заполняем массив случайными числами
    for(int i = 0; i < task52VariableM; i++)
    {
        for(int j = 0; j < task52VariableN; j++)
        {
            task52Array[i,j] = new Random().Next(0,9);
        }
    }
   
    //выводим массив
    for(int i = 0; i < task52VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task52VariableN; j++)
        {
            Console.Write(task52Array[i,j] + " ");
        }
    }

    double sum = 0;
    //считаем среднее арифметическое элементов в каждом столбце
    for(int j = 0; j < task52VariableN; j++)
    {
        Console.WriteLine();
        for(int i = 0; i < task52VariableM; i++)
        {
            sum = sum + task52Array[i,j];
            if(i == task52VariableM - 1)
            {
                Console.Write("Среднее арифмитическое " + (sum / Convert.ToDouble(task52VariableM)) + " - " + (j+1) + " столбца");
                sum = 0;
            }
        }
    }
}

Method1Task52();
Console.WriteLine();
Console.WriteLine();

// Task 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Method1Task54()
{
    Console.WriteLine("Задача № 54. Построчная сортировка по убыванию");
    Console.WriteLine("Введите m:");
    int task54VariableM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int task54VariableN = Convert.ToInt32(Console.ReadLine());

    //задаем массив
    int[,] task54Array = new int[task54VariableM, task54VariableN];
    //массив для сортировки
    int[,] task54ChangeArray = new int[task54VariableM, task54VariableN];

    //заполняем массив случайными числами
    for(int i = 0; i < task54VariableM; i++)
    {
        for(int j = 0; j < task54VariableN; j++)
        {
            task54Array[i,j] = new Random().Next(0,9);
        }
    }
   
    //выводим изначальный массив
    for(int i = 0; i < task54VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task54VariableN; j++)
        {
            Console.Write(task54Array[i,j] + " ");
        }
    }

    //сортируем массив построчно
    for(int i = 0; i < task54VariableM; i++)
    {
        for(int k = 0; k < task54VariableN; k++)
        {
            for(int j = 1; j < task54VariableN; j++)
            {
                if(task54Array[i,j-1] < task54Array[i,j])
                {
                    task54ChangeArray[i,j] = task54Array[i,j-1];
                    task54Array[i,j-1] = task54Array[i,j];
                    task54Array[i,j] = task54ChangeArray[i,j];
                }
            }
        }   
    }

    Console.WriteLine();
    Console.WriteLine();
    //выводим отсортированный массив
    for(int i = 0; i < task54VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task54VariableN; j++)
        {
            Console.Write(task54Array[i,j] + " ");
        }
    }

}

Method1Task54();
Console.WriteLine();
Console.WriteLine();

// Task 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void Method1Task56()
{
    Console.WriteLine("Задача № 56. Задайте прямоугольный двумерный массив (m < n");
    Console.WriteLine("Введите m:");
    int task56VariableM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите n:");
    int task56VariableN = Convert.ToInt32(Console.ReadLine());
    while(task56VariableN <= task56VariableM)
    {
        Console.WriteLine("Ошибка. n должно быть больше чем m! Введите n:");
        int task56VariableN2 = Convert.ToInt32(Console.ReadLine());
        task56VariableN = task56VariableN2;
    }
    
    //задаем массив
    int[,] task56Array = new int[task56VariableM, task56VariableN];
    //массив для сумм строк
    int[] task56Sum = new int[task56VariableM];
    int sum = 0;

    //заполняем массив случайными числами
    for(int i = 0; i < task56VariableM; i++)
    {
        for(int j = 0; j < task56VariableN; j++)
        {
            task56Array[i,j] = new Random().Next(0,9);
        }
    }
   
    //выводим изначальный массив
    for(int i = 0; i < task56VariableM; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task56VariableN; j++)
        {
            Console.Write(task56Array[i,j] + " ");
        }
    }

    Console.WriteLine();

    //считаем сумму строк и результаты помещаем в массив
    for(int i = 0; i < task56VariableM; i++)
    {
        sum = 0;
        for(int j = 0; j < task56VariableN; j++)
        {
            sum = sum + task56Array[i, j];
            task56Sum[i] = sum;
        }   
    }

    //ищем строку с минимальной суммой
    int min = task56Sum[0];
    int minInd = 0;
    for(int i = 1; i < task56VariableM; i++)
    {
        if(task56Sum[i] < min)
        {
            min = task56Sum[i];
            minInd = i + 1;
        }
    }
    //выводим номер строки с минимальной суммой
    Console.WriteLine("Строка с минимальной суммой: ");
    Console.WriteLine(minInd);
}


Method1Task56();
Console.WriteLine();
Console.WriteLine();


// Task 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Method1Task58()
{
    Console.WriteLine("Задача № 58. Зададим две матрицы");
    
    Console.WriteLine("Зададим размер первой матрицы");
    
    Console.WriteLine("Введите m1:");
    int task58VariableM1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Введите n1:");
    int task58VariableN1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Зададим размер первой матрицы");
    Console.WriteLine("Умножать матрицы можно тогда и только тогда, когда количество столбцов первой матрицы равно количеству строк второй матрицы.");
    Console.WriteLine("n1 = m2!");

    Console.WriteLine("Зададим размер второй матрицы");
    
    Console.WriteLine("Введите m2:");
    int task58VariableM2 = Convert.ToInt32(Console.ReadLine());
    
    while(task58VariableM2 != task58VariableN1)
    {
        Console.WriteLine("Ошибка. Число строк второй матрицы m2");
        Console.WriteLine("должно быть равно числу столбцов первой матрицы n1:");
        int task58VariableM2Temp = Convert.ToInt32(Console.ReadLine());
        task58VariableM2 = task58VariableM2Temp;
    }

    Console.WriteLine("Введите n2:");
    int task58VariableN2 = Convert.ToInt32(Console.ReadLine());

    //создаем массивы
    int[,] task58Array1 = new int[task58VariableM1, task58VariableN1];
    int[,] task58Array2 = new int[task58VariableM2, task58VariableN2];
    int[,] task58Array3 = new int[task58VariableN1, task58VariableN1];

    //заполняем случайными числами 1-й массив
    for(int i = 0; i < task58VariableM1; i++)
    {
        for(int j = 0; j < task58VariableN1; j++)
        {
            task58Array1[i,j] = new Random().Next(0,9);
        }
    }

     //заполняем случайными числами 2-ой массив
    for(int i = 0; i < task58VariableM2; i++)
    {
        for(int j = 0; j < task58VariableN2; j++)
        {
            task58Array2[i,j] = new Random().Next(0,9);
        }
    }
   
    //выводим изначальный 1-й массив
    for(int i = 0; i < task58VariableM1; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task58VariableN1; j++)
        {
            Console.Write(task58Array1[i,j] + " ");
        }
    }

    Console.WriteLine();

    //выводим изначальный 2-ой массив
    for(int i = 0; i < task58VariableM2; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task58VariableN2; j++)
        {
            Console.Write(task58Array2[i,j] + " ");
        }
    }

    //перемножаем матрицы, формируем 3-й массив
    for(int i = 0; i < task58VariableM1; i++)
    {
        for(int j = 0; j < task58VariableN2; j++)
        {
            for(int k = 0; k < task58VariableM1; k++)
            {
                task58Array3[i, j] += task58Array1[i, k] * task58Array2[k, j];
            }
        }
    }

    Console.WriteLine();
    //выводим 3-й массив
    for(int i = 0; i < task58VariableM1; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task58VariableN2; j++)
        {
            Console.Write(task58Array3[i,j] + " ");
        }
    }

}

Method1Task58();
Console.WriteLine();
Console.WriteLine();

// Task 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая построчно выведет элементы и их индексы.

void Method1Task60()
{
    Console.WriteLine("Сформируем трёхмерный массив из неповторяющихся двузначных чисел");
    Console.WriteLine("Общее число элементов массива не должно превышать количество двузначных чисел - 90");
    
    Console.WriteLine("Введите колличество строк:");
    int task60VariableX = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите колличество столцов:");
    int task60VariableY = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите колличество страниц:");
    int task60VariableZ = Convert.ToInt32(Console.ReadLine());
    while(task60VariableZ > (90/(task60VariableX * task60VariableY)))
    {
        Console.WriteLine("Уменьшите количество страниц!");
        int task60VariableZTemp = Convert.ToInt32(Console.ReadLine());
        task60VariableZ = task60VariableZTemp;
    }

    // Задаём трёхмерный массив
    int[,,] task60Array1 = new int[task60VariableX, task60VariableY, task60VariableZ];
    
    // Задаём массив двузначных чисел
    int[] task60Array2 = new int[90];

    // Заполняем массив двухзначных чисел двухзначными числами
    for(int i = 0; i < 90; i++)
    {
        task60Array2[i] = i + 10;
    }
    
    // Заполняем трёхмерных массив
    for(int i = 0; i < task60VariableX; i++)
    {
        for(int j = 0; j < task60VariableY; j++)
        {
            for(int k = 0; k < task60VariableZ; k++)
            {
                // Получаем случайный индекс
                int task60VariableRandomIndex = new Random().Next(0,90);
                // Если в массиве двузначных чисел элемент с выбранным индексом равен нулю
                // Получаем новый случайный индекс
                while(task60Array2[task60VariableRandomIndex] == 0)
                {
                    task60VariableRandomIndex = new Random().Next(0,90);    
                } 
                // Присваиваем текущему элементу трёхмерного массива 
                // значение элемента из массива двухзначных чисел
                // под выбранным индексом
                task60Array1[i,j,k] = task60Array2[task60VariableRandomIndex];
                // Переписываем использованное двузначное число в массиве на нуль
                task60Array2[task60VariableRandomIndex] = 0;                              
            }
        }
    }

    Console.WriteLine();
   
    for(int i = 0; i < task60VariableX; i++)
    {
        for(int j = 0; j < task60VariableY; j++)
        {
            for(int k = 0; k < task60VariableZ; k++)
            {
                Console.WriteLine("Элемент- " + task60Array1[i,j,k] + " строка- " + i + " столбец- " + j + " страница- " + k + " ");
            }
        }
    }

}

Method1Task60();
Console.WriteLine();
Console.WriteLine();

// Task 62: Заполните спирально массив 4 на 4 числами от 1 до 16.

void Method1Task62()
{
    // Задаём размер массива
    int task62ArraySize = 4;
    //создаем массив
    int[,] task62Array1 = new int[task62ArraySize, task62ArraySize];

    //заполняем массив
    for(int i = 0; i < task62ArraySize; i++)
    {
        for(int j = 0; j < task62ArraySize; j++)
        {
            // Справедливо для любых массивов n х n
            if(i == 0)
            {
                task62Array1[i,j] = j + 1;
            }
            if(j == (task62ArraySize - 1) & i > 0)
            {
                task62Array1[i,j] = i + j + 1;
            }
            if(i == (task62ArraySize - 1) & j < (task62ArraySize - 1))
            {
                task62Array1[i,j] = task62Array1[0, (task62ArraySize - 1)] * 3 - 2 - j;
            }
            if(j == 0 & i < (task62ArraySize - 1) & i > 0)
            {
                task62Array1[i,j] = 4 * (task62ArraySize - 1) + 1 - i;
            }
            if(i == 1 & j > 0 & j < (task62ArraySize - 1))
            {
                task62Array1[i,j] = 4 * (task62ArraySize - 1) + j;
            }
            // Справедливо для массива размером 4 х 4
            if(i == 2 & j < 3 & j > 0)
            {
                task62Array1[i,j] = 17 - j;
            }
       }
    }
   
    //выводим массив
    for(int i = 0; i < task62ArraySize; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < task62ArraySize; j++)
        {
            if(task62Array1[i,j] > 9)
            {
                Console.Write(task62Array1[i,j] + " ");
            }
            else
            {
                Console.Write(task62Array1[i,j] + "  ");
            }
            
        }
    }


}

Method1Task62();
Console.WriteLine();
Console.WriteLine();
/*Fourth practical work. (Task 25, 27, 29)

// Task 25: Напишите цикл, который принимает на вход два натуральных числа (A и B) и возводит число A в степень B.

int Method1Task25(int a, int b)
{
    if(b < 2)
    {
        if(b < 1)
        {
            return 1;
        }
        else
        {
            return a;
        }
    }
    else
    {
        int result = a;
        for(int i = 1; i < b; i++)
        {
            result = result * a;
        }

        return result;
    }
}

int task29 = Method1Task25(2, 6);
Console.WriteLine(task29);

// Task 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Method1Task27(int a)
{
    int m = 0;

    while(a > 0)
    {
        m = m + a % 10;
        a = a / 10;
    }

    return m;

}

int task27 = Method1Task27(12345);
Console.WriteLine(task27);

// Task 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.

void Method1Task29()
{
    //задаем массив
    int[] task29Array = new int[8];
    
    //заполняем массив случайными числами от -1 до 1
    for(int i = 0; i < 8; i++)
    {
        task29Array[i] = new Random().Next(-9,9);
    }

    //сортируем массив по убыванию (по модулю)
    for(int i = 0; i < 8; i++)
    {
        for(int j = 1; j < 8; j++)
        {
            int k = 0;

            if(Math.Abs(task29Array[j]) > Math.Abs(task29Array[j-1]))
            {
                k = task29Array[j];
                task29Array[j] = task29Array[j-1];
                task29Array[j-1] = k;
            }
        }
    }

    //выводим массив
    for(int i = 0; i < 8; i++)
    {
        Console.Write(task29Array[i] + " ");
    }
}

Method1Task29();


/*Second and third practical work. (Task 10, 13, 15, 19, 21, 23)

Console.WriteLine("Здравствуйте Денис, доброго времени суток!");

// Task 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число.
Console.WriteLine("Приступаем ко второй практической работе!");
Console.WriteLine("Давайте для начала напишем программу, которая принимает на вход трёхзначное число и на выходе выводит перевёрнутое число");

Console.WriteLine("Введите трёхзначное число:");
int task10Variable1 = Convert.ToInt32(Console.ReadLine());

int[] task10Array = new int[3];

task10Array[2] = task10Variable1 / 100;

task10Array[1] = (task10Variable1 - task10Array[2] * 100) / 10;

task10Array[0] = task10Variable1 % 10;

int invertedNumber = task10Array[0] * 100 + task10Array[1] * 10 + task10Array[2];

Console.WriteLine("Получившееся перевёрнутое трёхзначное число:");
Console.WriteLine(invertedNumber);

// Task 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Отлично! Давайте теперь выводит третью цифру заданного числа, если она конечно существует!");

Console.WriteLine("Для этого давайте введём произвольное целое число:");
string? task13Variable1 = Console.ReadLine();

if(task13Variable1 is not null)
{
    if((task13Variable1.Length < 3))
    {
        Console.WriteLine("Упс, третьего числа не существует!");
    }
    else
    {
        Console.WriteLine(task13Variable1[2]);
    }
}

// Task 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Идём дальше! Введите цифру, обозначающую день недели:");
int task15Variable1 = Convert.ToInt32(Console.ReadLine());

if((task15Variable1 % 7 == 0) | ((task15Variable1 + 1) % 7 == 0))
{
    Console.WriteLine("Ура, это день выходной!");
}
else
{
    Console.WriteLine("Будний день, продолжаем работу.");
}

Console.WriteLine("Отличная работа! Приступим к третьей практической работе!");

// Task  19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Проверим, является ли пятизначное число палиндромом");

Console.WriteLine("Для этого введите пятизначное число:");
int task19Variable1 = Convert.ToInt32(Console.ReadLine());

if((task19Variable1 % 10 == task19Variable1 /10000) & ((task19Variable1 / 1000) % 10 == (task19Variable1 % 100) / 10))
{
    Console.WriteLine("Введённое число палиндром!");
}
else
{
    Console.WriteLine("Введённое число не является палиндромом!");
}

// Task  21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Далее найдём расстояние между двумя точками в трёхмерном пространстве");

int[] dotA = new int[3];

int[] dotB = new int[3];

int task21Index1 = 0;

int task21Index2 = 0;

Console.WriteLine("Введите первую точку:");

while(task21Index1 < 3)
{
    dotA[task21Index1] = Convert.ToInt32(Console.ReadLine());
    task21Index1++;
}

Console.WriteLine("Введите вторую точку:");

while(task21Index2 < 3)
{
    dotB[task21Index2] = Convert.ToInt32(Console.ReadLine());
    task21Index2++;
}

double distance = Math.Sqrt((dotB[0] - dotA[0]) * (dotB[0] - dotA[0]) + (dotB[1] - dotA[1]) * (dotB[1] - dotA[1]) + (dotB[2] - dotA[2]) * (dotB[2] - dotA[2]));

Console.WriteLine("Расстояние между точками в трёхмерном пространстве:");
Console.WriteLine(distance);


/* Task  23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27.
5 -> 1, 8, 27, 64, 125
*/

/*
Console.WriteLine("В следующем задании составим таблюцу кубов числе от 1 до N");

Console.WriteLine("Введите число N:");
int task23VariableN = Convert.ToInt32(Console.ReadLine());

int task23Index1 = 0;

int[] task23Array = new int[task23VariableN];

Console.Write((task23VariableN) + " -> ");

while(task23Index1 < task23VariableN)
{
    task23Array[task23Index1] = (task23Index1 + 1) * (task23Index1 + 1) * (task23Index1 + 1);
    Console.Write((task23Array[task23Index1]));
    task23Index1++;
    if(task23Index1 < (task23VariableN))
    {
        Console.Write(", ");
    }
    else
    {
        Console.Write(".");
    }
}

*/

/*First practical work. (Task 2, 4, 6, 8)

// Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Ищем наибольшее из двух чисел.");
Console.WriteLine("Введите первое число:");
int task2Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task2Variable2 = Convert.ToInt32(Console.ReadLine());

if(task2Variable1 > task2Variable2)
{
   Console.WriteLine("Наибольшее из двух чисел " + task2Variable1 + " и " + task2Variable2 + " - это " + task2Variable1); 
}
else
{
    Console.WriteLine("Наибольшее из двух чисел " + task2Variable1 + " и " + task2Variable2 + " - это " + task2Variable2); 
}

// Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Идём дальше!Теперь найдём наибольшее из трёх чисел.");

Console.WriteLine("Введите первое число:");
int task4Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4Variable2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int task4Variable3 = Convert.ToInt32(Console.ReadLine());

if(task4Variable1 > task4Variable2)
{
    if(task4Variable1 > task4Variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable1); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable3); 
    }
}
else
{
    if(task4Variable2 > task4Variable3)
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable2); 
    }
    else
    {
        Console.WriteLine("Наибольшее из трёх чисел " + task4Variable1 + ", " + task4Variable2 + " и " + task4Variable3 + " - это " + task4Variable3); 
    }
}

// Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Отлично! Идём дальше!");

Console.WriteLine("Определим, является ли число чётным:");

Console.WriteLine("Введите число:");
int task6Variable1 = Convert.ToInt32(Console.ReadLine());

if(task6Variable1 % 2 == 0)
{
    Console.WriteLine(task6Variable1 + " - чётное число.");
}
else
{
    Console.WriteLine(task6Variable1 + " - нечётное число.");
}

// Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Переходим к последнему заданию.");

Console.WriteLine("Введите некоторое число N:");
int task8Variable1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Покажем все чётные числа от 1 до " + task8Variable1);

int count = 2;

while(count < task8Variable1)
{
    Console.Write(count + " ");
    count = count + 2;
}

Console.WriteLine();

Console.Write("Спасибо за внимание!");
*/