Console.Clear();
void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().NextDouble();
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Показать двумерный массив размером m x n заполненный вещественными числами");
Console.WriteLine("Введите число - количество строк: ");
int m = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine("Введите число - количество столбцов: ");
int n = int.Parse(Console.ReadLine() ?? "");
double[,] matrix = new double[m, n];
FillMatrix(matrix);
Console.WriteLine("Результат: ");
PrintMatrix(matrix);
