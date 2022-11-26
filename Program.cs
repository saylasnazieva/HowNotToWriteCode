// 
void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) && row2 >=0 && 
        row2 >=0 && row2 < array.GetLength(0) &&
        row1 != row2 )
        {
            for(int j =0; j < array.GetLength(1 ) ; j++)
            {
                int temp = array [row1 ,j];
                array[row1,j]= array[row2,j];
                array[row2,j] = temp;
            }
        }
        else Console.WriteLine("Incorrect rows for changing!");
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. 
/* 
// Например, задан массив: 
// 1 4 7 2 
// 5 9 2 3 
// 8 4 2 4 
// В итоге получается вот такой массив: 
// 7 4 2 1 
// 9 5 3 2 
// 8 4 4 2 
 
int[,] matrix = new int[3,4]; 
 
void ShowArray(int[,] matr) 
{ 
for (int i =0; i < matr.GetLength(0); i++) 
  { 
    for (int j = 0; j < matr.GetLength(1) ; j++) 
    { 
        Console.Write($"{matrix[i,j]} "); 
    } 
Console.WriteLine(); 
   } 
} 
int[,] matrix = new int[3,4]; 
ShowArray( matrix); 
 
void NetCommit(int[,] array) 
{ 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            for (int k = 0; k < array.GetLength(1) - 1; k++) 
            { 
                if (array[i, k] < array[i, k + 1]) 
                { 
                    int temp = array[i, k + 1]; 
                    array[i, k + 1] = array[i, k]; 
                    array[i, k] = temp; 
                } 
            } 
        } 
    } 
} 
 
void PrintArray(int[,] array) 
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
*/ 
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
 
// Например, задан массив: 
 
// 1 4 7 2 
 
// 5 9 2 3 
 
// 8 4 2 4 
 
// 5 2 6 7 
 
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка 
/* 
int[,] matrix = new int[m,n]; 
 
void PrintArray(int[,] matr) 
{ 
 
for (int i =0; i < matr.GetLength(0); i++) 
  { 
    for (int j = 0; j < matr.GetLength(1) ; j++) 
    { 
        Console.Write($"{matrix[i,j]} "); 
    } 
Console.WriteLine(); 
   } 
} 
 
void FILLRandomArray(int[,] array) 
{ 
     for (int i = 0; i < array.GetLength(0); i++) 
     { 
       for (int j = 0; j < array.GetLength(1); j++) 
       { 
        array[i,j]= new Random().Next(0,10); 
       } 
     } 
} 
 
int[,] array = new int[m, n]; 
 
PrintArray(array); 
FILLRandomArray(array); 
 
int minSumLine = 0; 
 
int sumLine = SumLineElements(array, 0); 
 
for (int i = 1; i < array.GetLength(0); i++) 
 
{ 
 
  int tempSumLine = SumLineElements(array, i); 
 
  if (sumLine > tempSumLine) 
 
  { 
 
    sumLine = tempSumLine; 
 
    minSumLine = i; 
 
  } 
 
} 
 
Console.WriteLine($"\n{minSumLine+1} - The row with the smallest amount ({sumLine})  "); 
*/ 
 
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. 
// Например, даны 2 матрицы: 
// 2 4 | 3 4 
// 3 2 | 3 3 
// Результирующая матрица будет: 
// 18 20 
// 15 18 
/* 
int[,] CreateMatrix1 (int row, int col, int min, int max)  
{ 
    int[,] matrix1 = new int[row, col]; 
     Random rnd = new Random(); 
     for (int i = 0; i < matrix1.GetLength(0); i++)  
    { 
        for (int j = 0; j < matrix1.GetLength(1); j++) 
       { 
            matrix1[i,j] = rnd.Next(min, max +1); 
        } 
    } 
 return matrix1; 
} 
 
int[,] CreateMatrix2 (int row, int col, int min, int max)  
{ 
    int[,] matrix2 = new int[row, col]; 
    Random rnd = new Random(); 
    for (int i = 0; i < matrix2.GetLength(0); i++)  
    { 
 
for (int j = 0; j < matrix2.GetLength(1); j++) 
        { 
           matrix2[i,j] = new Random().Next(min, max +1); 
        } 
    } 
 return matrix2; 
}  
 
void PrintMatrix1(int[,] matrix) ; 
{ 
   for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        Console.Write("|"); 
        for (int j = 0; j < matrix.GetLength(1); j++)  
        { 
             if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 1}|"); 
             else Console.Write($"{matrix[i, j], 1}"); 
               } 
    } 
} 
 Console.WriteLine 
void PrintMatrix2(int[,] matrix) 
{ 
   for (int i = 0; i < matrix.GetLength(0); i++) 
    { 
        Console.Write("|"); 
        for (int j = 0; j < matrix.GetLengh;
    }

  return A; 
 } 
*/

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int[,,] CreateMatrix (int row, int col, int dep, int min, int max) 
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();   
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                {
                    matrix[i,j,k] = new Random().Next(min, max + 1);
                }
        }
    }
    return matrix;
} 
 
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i <  matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i, j, k], 1}|");            
            }
        }
        Console.WriteLine();        
    }        
}
 
int[,,] array3D = CreateMatrix(2, 2, 2, 10, 99);
PrintMatrix(array3D);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
   
 void Main(string[] args)
   {
        int N = 4, M = 4;
        int a = CreateSnakeArrayVsClock(N, M);
      {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
 
 
            Console.ReadLine();
        }
 
     int[,] CreateSnakeArrayVsClock(int n, int m)
        {
            int  arr = CreateSnakeArray(n, m);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    int tmp = arr[i, j];
                    arr[i, j] = arr[i, m - j - 1];
                    arr[i, m - j - 1] = tmp;
                }
            }
            return arr;
        }
 
        int[,] CreateSnakeArray(int n, int m)
        {
            int[,] A = new int[n, m];
            
            int[,] A = new int[n, m];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;
 
            for (int i = 0; i < A.Length; i++)
            {
                A[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = m*(dirChanges%2) + n*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            return A;
        }
   }
