Console.WriteLine("Input amount of numbers");
int size = Convert.ToInt32(Console.ReadLine());
int index = 0;
int[] numbers = new int[size];
while(index<size)
{
    Console.WriteLine("Input the number");
    numbers[index] = Convert.ToInt32(Console.ReadLine());
    index = index + 1;
}
int max = numbers[0];
index = 1;
while(index<size)
{
    if(max < numbers[index])
    {
        max = numbers[index];
        index = (index + 1);
    }
    else
        index = index + 1;
}
int min = numbers[0];
index = 1;
while(index<size)
{
    if(min > numbers[index])
    {
        min = numbers[index];
        index = (index + 1);
    }
    else
        index = index + 1;
}
Console.WriteLine($"Maximal number is {max} and minimal is {min}.");
