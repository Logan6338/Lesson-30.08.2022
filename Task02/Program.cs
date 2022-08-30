// Поменяй строки на столбцы
Console.Clear();

int[,] array = new int[4, 4];
Random random = new Random();

int[,] FillArry(int[,] array)
{
    int[,] newArray = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j] = random.Next(1,10);
        }
        Console.WriteLine();
    }
    return newArray;
}

int[,] newArray = FillArry(array);

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }

        Console.WriteLine();
    }
}

int[,] SwapRowToColumns (int[,] arr)
{
    int[,] tempArr = new int [arr.GetLength(0), arr.GetLength(1)];
    if (arr.GetLength(0) != arr.GetLength(1))
    {
        Console.WriteLine("Это не возможно!");
        throw new Exception();
    }
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArr[j,i] = arr[i,j];
        }
    }
    return tempArr;
}

PrintArray2D(newArray);
Console.WriteLine();
PrintArray2D(SwapRowToColumns(newArray));