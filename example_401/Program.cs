Console.Clear();
// string[,] table = new string[2,5]; // таблица из 2 строк и 5 столбцов

// // table[0,0] ... table[0,4]
// // table[1,0] ... table [1,4]

// table[1, 2] = "word";

// for(int rows = 0; rows < 2; rows++)
// {
// 	for (int columns = 0; columns < 5; columns++)
// 	{
// 		Console.WriteLine($"-{table[rows, columns]}-");
// 	}
// }

void PrintArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++) 
	{
		for (int j = 0; j < matr.GetLength(1); j++)
		{
			Console.Write($"{matr[i, j]} ");
		}
		Console.WriteLine();
	}
}

void FillArray(int[,] matr)
{
	for(int i = 0; i < matr.GetLength(0); i++)
	{
		for(int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i,j] = new Random().Next(1,10);
		}
	}
}

int[,] matrix = new int[3, 4]; // 2 мерный массив
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

