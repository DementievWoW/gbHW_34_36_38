//////34
//Console.WriteLine("Введите длину массива:  ");
//int size = Convert.ToInt16(Console.ReadLine());
//int[] valueArray = new int[size];
//RandomValue(valueArray);
//Console.WriteLine("В этом массиве: ");
//PrintArray(valueArray);

//void RandomValue(int[] value)
//{
//    for (int i = 0; i < size; i++)
//    {
//        value[i] = new Random().Next(100, 1000);
//    }
//}


//int count = 0;

//for (int x = 0; x < valueArray.Length; x++)
//{
//    if (valueArray[x] % 2 == 0)
//        count++;
//}
//Console.WriteLine($"из {valueArray.Length} чисел, {count} четных");


//void PrintArray(int[] valueArray)
//{
//    for (int i = 0; i < valueArray.Length; i++)
//    {
//        Console.Write(valueArray[i] + " ");
//    }
//    Console.WriteLine();
//}
//////36

//Console.WriteLine("Введите размер массива  ");
//int size = Convert.ToInt16(Console.ReadLine());
//int[] valueArray = new int[size];
//RandomValue(valueArray);
//Console.WriteLine("массив: ");
//PrintArray(valueArray);
//int sum = 0;

//for (int z = 0; z < valueArray.Length; z += 2)
//    sum +=valueArray[z];

//Console.WriteLine($"всего {valueArray.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");

//void RandomValue(int[] valueArray)
//{
//    for (int i = 0; i < valueArray.Length; i++)
//    {
//        valueArray[i] = new Random().Next(1, 10);
//    }
//}
//void PrintArray(int[] valueArray)
//{
//    for (int i = 0; i < valueArray.Length; i++)
//    {
//        Console.Write(valueArray[i] + " ");
//    }
//    Console.WriteLine();
//}
//////38
Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt16(Console.ReadLine());
int[] valueArray = new int[size];
RandomValue(valueArray);
PrintArray(valueArray);

int max = valueArray[0];
int min = valueArray[0];

for (int i = 0; i < valueArray.Length; i++)
{
    if (valueArray[i] > max)
    {
        max = valueArray[i];
    }
    else if (valueArray[i] < min)
    {
        min = valueArray[i];
    }
}

Console.WriteLine($"Минимальное число: {min}");
Console.WriteLine($"Минимальное число: {max}");
Console.WriteLine($"Разница между максимальным и минимальным числами: {max - min}");



void RandomValue(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 555);
    }
}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}