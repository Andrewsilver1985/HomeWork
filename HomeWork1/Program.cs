Random rnd = new Random();
int sise = 10;
int res;
int[] array = new int[10];
for (int i = 0; i < sise; i++)
{
    array[i] = rnd.Next(1, 100);
    System.Console.Write(array[i]+"\t");


}
res =Quantity(array);
System.Console.WriteLine($"количество элементов в отрезке [20,90]=>  {res}   ");

static int Quantity(int[] array)
{
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        if (array[i] >= 10 && array[i] <= 90)
            count++;
    }
    return count;


}
