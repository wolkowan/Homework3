

// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.

static void DistanceBetweenPoints(int[] array1, int[] array2)
{
    double distanceBetweenPoints = Math.Sqrt(Math.Pow(array1[1] - array2[1], 2) + Math.Pow(array1[2] - array2[2], 2) + Math.Pow(array1[0] - array2[0], 2));
    Console.WriteLine($"Distance Between Points={distanceBetweenPoints:f2}");
}
int[] array1 = { 3, 6, 8 };
int[] array2 = { 2, 1, -7 };

DistanceBetweenPoints(array1, array2);

// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9.
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


static void NumberToThirdPower(int arg)
{
    for (int index = 1; index <= arg; index++)
    {
        double num = Math.Pow(index, 3);
        System.Console.Write($"{num} ");
    }
}

NumberToThirdPower(5);


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да

static void IfPallindrome(int number)
{
    string line = number.ToString();

    if (line[0] == line[4])
    {
        if (line[1] == line[3])
        { System.Console.WriteLine("Pallindrome"); }
    }
    else
    { System.Console.WriteLine("Not Pallindrome"); }
}
IfPallindrome(14212);



