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
System.Console.WriteLine($"количество четных чисел=>  {res}   ");

static int Quantity(int[] array)
{
    int count = 0;
    for (int i = 0; i < 10; i++)
    {
        if ((array[i]%2)==0)
            count++;
    }
    return count;


}
