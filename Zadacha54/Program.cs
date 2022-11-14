// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Write("Введите число строк:\t");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите число столбцов:\t");
int columns = int.Parse(Console.ReadLine()!);

int[,] massiv = GetArray2mmass(rows, columns, 0, 9);
NewMass2mer(massiv);
Console.WriteLine();
ChangeMass(massiv);

void ChangeMass(int[,] mass )
{
    for(int i = 0; i < mass.GetLength(0); i++)
    {       
        for(int j = 0; j < mass.GetLength(1); j++)
        {
            int minPoz = j;
            for(int g = j+1 ; g < mass.GetLength(1); g++)
            {
                 if(mass[i,g] > mass[i,minPoz]) minPoz = g;
            }
           
            int temp = mass[i,j];
            mass[i,j] = mass[i,minPoz];
            mass[i,minPoz] = temp;           
             
            Console.Write($"{mass[i, j]} ");            
        }
        Console.WriteLine();      
        
    }
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
