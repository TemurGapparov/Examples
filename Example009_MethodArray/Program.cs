int[] array = { 1, 3, 56, 8, 9, 20, 8, 6 };

int n = array.Length;
int find = 8;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}