Console.WriteLine("Введите число m: ");
bool numberM = int.TryParse(Console.ReadLine(), out int m);
Console.WriteLine("Введите число n : ");
bool numberN = int.TryParse(Console.ReadLine(), out int n);
if (numberN == false || numberN == false)
{
    Console.WriteLine("Введены неправильные данные");
}

int[,] FillArray(int m, int n)
{
    Random random = new Random();
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(15);
        }
    }
    return array;
}
int[,] result = FillArray(m, n);

void Print2dArray(int[,] array)
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

Print2dArray(result);

int[] GetFirstRow (int [,] array)
{
    int [] firstRow = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        firstRow[i] = array[0,i];
    }
    return firstRow;
}

int[] result2 = GetFirstRow (result);

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] GetLastRow (int [,] array)
{
    int [] LastRow = new int [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        LastRow[i] = array[array.GetLength(1)-1, i];
    }
    return LastRow;
}

int[] result3 = GetLastRow (result);
Console.WriteLine();

void ResultPrintArray(int [,] array)
{
    for (int i = 1; i < array.GetLength(1)-1; i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    
}
PrintArray(result3);
Console.WriteLine();
ResultPrintArray(result);
PrintArray(result2);