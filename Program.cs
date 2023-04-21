// Homework lesson 5

// Task 1 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size) 
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(100, 1000);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int CountNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 0)
//         count = count + 1;
//     }
//     return count;
// }

// Console.WriteLine("Inpt a quanity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size);
// ShowArray(myArray);
// Console.WriteLine("Quanity of even numbers is - " + CountNumbers(myArray));

// Task 2 Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int minValue, int maxValue) 
// {
//     int[] array = new int[size];

//     for(int i = 0; i < size; i++)
//         array[i] = new Random().Next(minValue, maxValue + 1);

//     return array;
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// int SumElems(int[] array)
// {
//     int sum = 0;
//     for (int i = 1; i < array.Length; i = i+2)
//     {
//         sum += array[i];
//     }
//     return sum;
// }
// Console.WriteLine("Inpt a quanity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a min possible value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a max possible value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[] myArray = CreateRandomArray(size,min,max);
// ShowArray(myArray);

// Console.WriteLine("Sum = " + SumElems(myArray) );

// Task 3 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] CreateArray(int size) 
// {
//     double[] array = new double[size];

//     for(int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Input element");
//         array[i] = Convert.ToDouble (Console.ReadLine());
//     }
//     return array;
// }

// void ShowArray(double[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");

//     Console.WriteLine();
// }

// double CheckMaxAndMin(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if(array[i] < min) min = array [i];
//         if(array[i] > max) max = array [i];
//     }
//     double result = max - min;
//     return result;
// }
// Console.WriteLine("Inpt a quanity of elements: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] myArray = CreateArray(size);
// ShowArray(myArray);
// Console.WriteLine("Difference of max and min numbers is - " + CheckMaxAndMin(myArray)); 