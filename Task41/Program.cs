//Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void Print1DArr(int[] arr)
{
    Console.Write("Ваши числа [");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
int arrayLen = ReadData("Введите количество чисел:");
int[] numbers = new int[arrayLen];
int[] FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = ReadData("Введите число : ");
    }
    return numbers;
}
int NumbersGreaterZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > 0)
            count++;
    }
    return count;
}

FillArray(numbers);
Print1DArr(numbers);
Console.WriteLine();
Console.WriteLine("Из них " + NumbersGreaterZero(numbers) + " больше нуля");
