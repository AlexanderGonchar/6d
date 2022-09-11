System.Console.WriteLine($"Программа, которая обменяет элементы первой строки и последней строки: ");
void FillArray(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "  ");
        }
            Console.WriteLine();
    }
}
Console.WriteLine();

void ExchangeArray(int[,] array) 
{
int m = 0; 
for (int i = 0; i < array.GetLength(1); i++)
    {
        m = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0, i];
        array[0, i] = m;
    }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "  ");
            }
            Console.WriteLine();
        }
    
}
Console.WriteLine();
int[,] matrix = new int[4,5];
FillArray(matrix);
Console.WriteLine("----------------");
ExchangeArray(matrix);
