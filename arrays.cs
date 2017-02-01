using System;

namespace testttt
{
	class MainClass
	{
		static void CreateArray(int[,] array, int N, int M)
		{
			int i = 0, j = 0;
			for (i = 0; i < N; i++) {
				for (j = 0; j < M; j++) {
					array[i, j] = i;
				}
			}
		}
		static void PrintArray(int[,] array, int N, int M)
		{
			int i = 0, j = 0;
			for (i = 0; i < N; i++)
			{
				for (j = 0; j < M; j++)
				{
					Console.Write("{0,-2}",array[i, j]);
				}
				Console.WriteLine();
			}
		}
		public static void Main(string[] args)
		{
			int N = int.Parse(Console.ReadLine());
			int M = int.Parse(Console.ReadLine());
			int[,] array = new int[N,M];
			CreateArray(array,N,M);
			PrintArray(array, N,M);
		}
	}
}
