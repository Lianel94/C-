int[] array = {10, 54, 35 , 54, 58, 62, 77, 98};

int n = array.Length;
int find = 54;

int index = 0;

while(index < n)
{
	if(array[index] == find)
	{
		Console.WriteLine(index);
		break; // will find only the first element
	}
	index++;
}
