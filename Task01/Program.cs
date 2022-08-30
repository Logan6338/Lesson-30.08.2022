// Задайте двумерный массив. Поменяй местами первую и последнюю строку массива
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

int[,] SwapRowsArray (int[,] array)
{
    int[] tempArray = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempArray[i] = array[0,i];
    }
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[0,j] = array[3,j];
    }
    for (int k = 0; k < array.GetLength(0); k++)
    {
        array[3,k] = tempArray[k];
    }
    return array;
}

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

PrintArray2D(array);
int[,] result = SwapRowsArray(newArray);
Console.WriteLine();
PrintArray2D(array);