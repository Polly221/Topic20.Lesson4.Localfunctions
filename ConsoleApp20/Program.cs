int[,] array1 =
            {
              { 4, 8, 8, 4 },
              { 3, -7, 9, 4 },
              { 2, 2, 5, 26 },
              { 22, 8, 3, -5 }
            };

int[,] array2 =
{
              { 21, 4, -48, 36},
              { 5, 10, 0, 28 },
              { 36, 7, 35, -3 },
              { 11, 25, 6, -2 }
            };

int[,] array3 = new int[4, 4];

Console.WriteLine("Первый массив: ");
BringOutArray(array1);
Console.WriteLine();
Console.WriteLine("Второй массив: ");
BringOutArray(array2);
Console.WriteLine();
Console.WriteLine("Массив суммы двух предыдущих: ");
BringOutArray(SummOfArrays(array1, array2));
Console.WriteLine();

int[,] SummOfArrays(int[,] firstArray, int[,] secondArray)
{
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            array3[i, j] = array1[i, j] + array2[i, j];
        }
    }
    return array3;
}

void BringOutArray(int[,] array)
{
    for (int l = 0; l < array.GetLength(0); l++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            Console.Write(array[l, m] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int Max(int[,] firstArray)
{
    int c = -50;
    for (int n = 0; n < 4; n++)
    {
        for (int k = 0; k < 4; k++)
        {
            if (array3[n, k] > c)
            {
                c = array3[n, k];
            }
        }
    }
    return c;
}

Console.WriteLine($"Максимальное значение массива: {Max(SummOfArrays(array1, array2))}");
