//// Задача 58: Задайте две квадратные матрицы.
// Напишите программу, которая будет находить произведение двух матриц.

Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray2mmass(rows, columns, 0, 3);
NewMass(massiv);
Console.WriteLine();

int[,] mass = GetArray2mmass2(rows, columns, 0, 3);
NewMass2(mass);
Console.WriteLine();

int[,] resultMass = new int[rows, columns];
//ProizvMass(massiv, mass, resultMass);
ProizvMass(massiv, mass, resultMass);
Console.WriteLine($"Произведение первой и второй матриц:");
NewMass2(resultMass);

void ProizvMass(int[,] NewMass, int[,] NewMass2, int[,] resultMass)
{
  if(rows != columns) Console.WriteLine("Ошибка. Колчество строк должно быть равно количеству столбцов.");
  else
  for (int i = 0; i < resultMass.GetLength(0); i++)
  {
    for (int j = 0; j < resultMass.GetLength(1); j++)
    {
      int result = 0;
      for (int g = 0; g < rows; g++)
      {
        result = result + NewMass[i,g] * NewMass2[g,j];
      }
      resultMass[i,j] = result;      
    }    
  }  
}

void NewMass(int[,] mass )
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

void NewMass2(int[,] mass )
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

int[,] GetArray2mmass2(int m, int n, int minValue, int maxValue)
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

