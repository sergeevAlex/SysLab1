using System;
namespace SysLab
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
			//System.Diagnostics.Stopwatch sw2 = new System.Diagnostics.Stopwatch();
			Random rd = new Random();
			const int N = 10000;
			int[] vector = new int[N];
			int[,] matrix = new int[N,N];
			WorkArray.rMatrix(matrix);
			for (int i = 0; i < N; i++)
			{
				vector[i] = rd.Next(1,5);
			}
			Console.WriteLine("Матрица");
			//WorkArray.printMatrix(matrix);
			Console.WriteLine("Вектор");
			//WorkArray.printArr(vector);
			Console.WriteLine("Матрица на вектор:");
			sw.Start();
			//WorkArray.printArr(WorkArray.multiplyMV(vector,matrix));
			WorkArray.multiplyMV(vector,matrix);
			sw.Stop();
			Console.WriteLine("Время умножения матрицы на вектор:" + sw.ElapsedMilliseconds);
			Console.WriteLine("Вектор на матрицу");
			sw.Start();
			WorkArray.multiplyVM(vector, matrix);
			sw.Stop();
			Console.WriteLine("Время умножения вектора на матрицу:" + sw.ElapsedMilliseconds);
			//WorkArray.printArr(WorkArray.multiplyVM(vector,matrix));
		}
	}
}