// // Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.



Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray2mmass(rows, columns, 0, 9);
NewMass2mer(massiv);
Console.WriteLine();

int minRows = 0;
int sum = ChangeMass(massiv, 0);
for (int i = 1; i < massiv.GetLength(0); i++)
{
  int result = ChangeMass(massiv, i);
  if (sum > result)
  {
    sum = result;
    minRows = i;
  }
}

Console.WriteLine($"Наименьшая сумма  элементов в {minRows+1}-й строке = {sum}");




int ChangeMass(int[,] mass, int i )
{
    int sum = mass[i,0];
          
        
        for(int j = 1; j < mass.GetLength(1); j++)
        {        
            sum = sum + mass[i,j];               
        }
   return sum; 
}

void NewMass2mer(int[,] mass )
{
    for(int i = 0; i < mass.GetLength(0); i++)
    {
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray2mmass(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j <n; j++)
        {
             result[i, j] = new Random().Next(minValue, maxValue + 1);
        }       
    }
    return result;
}