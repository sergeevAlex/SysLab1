using System;
namespace SysLab
{
	public class WorkArray
	{
		public WorkArray()
		{
		}
		//Заполнение матрицы
		public static int[,] rMatrix(int[,] array)
		{
			Random rd1 = new Random();
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(0); j++)
				{
					array[i,j] = rd1.Next(1, 5);	
				}
			}
			return array;
		}
		//Печать
		public static void printArr(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine(array[i]);
			}
		}
		public static void printMatrix(int[,] array)
		{
			for (int i = 0; i < array.GetLength(0); i++)
			{
				for (int j = 0; j < array.GetLength(0); j++)
				{
					Console.Write(array[i,j] + " ");
				}
				Console.WriteLine();
			}
		}
		//Умножение матрицы на вектор
		public static int[] multiplyMV(int[] array1, int[,] array2)
		{
			int[] result = new int[array1.Length];
			for (int i = 0; i < array1.GetLength(0); i++)
			{
				result[i] = 0;
				for (int j = 0; j < array1.GetLength(0); j++)
				{
						result[i] += array2[i, j] * array1[j];
				}
			}
			//printArr(result);
			return result;
		}
		public static int[] multiplyVM(int[] array1, int[,] array2)
		{
			int[] result = new int[array1.Length];
			for (int i = 0; i < array1.GetLength(0); i++)
			{
				result[i] = 0;
				for (int j = 0; j < array1.GetLength(0); j++)
				{
					result[i] += array1[j]*array2[j,i];
				}
			}
			return result;
		}

	}
}