void FillArray(int[] coll)
{
int length = coll.Length;
int index = 0;
while (index < length)
{
 coll[index] = new Random().Next(1,10);
 index++;
}
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] coll, int find)
{
    int count = coll.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (coll[index] == find)
        {
            position = index;
            break;
        }
    index++;
    }
return position;
}

int [] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 6);
Console.WriteLine(pos);