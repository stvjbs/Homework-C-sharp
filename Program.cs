// Homework lesson 4

// Task 1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// int NumAB(int a, int b)
// {
//     int result = 1;
//     for (int c = 1; c <= b; c++)
//     {
//         result = result * a;
//     }
//     return result;
// }
// Console.WriteLine("Input number A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number B");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your result is - " + NumAB(a,b));

// Task 2 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumOfNums(int num)
// {
//     int sum = 0;
//     while(num >= 1)
//     {
//         sum = sum + (num % 10);
//         num = num / 10;
//     }
//     return sum;
// }
// Console.WriteLine("Input number ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Your result is - " + SumOfNums(b));

// Task 3 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int[] myArray = new int[8];
// for(int i = 0; i < 8; i++)
// {
//     Console.WriteLine("Input element");
//     myArray[i] = Convert.ToInt32(Console.ReadLine());
// }
// ShowArray(myArray);