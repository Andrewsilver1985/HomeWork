Random rnd = new Random();
int value = rnd.Next(1000000);

int sise = 0;
Console.WriteLine($"Заданное число: {value}");
int value1 = value;
int didgital;
//int count=0;
while (value > 0)
{

    value = value / 10;
    sise++;
}
System.Console.WriteLine($" размер массива =>  {sise}");

int[] array = new int[sise];
int sise1 = sise - 1;
for (int i = 0; i < sise; i++)
{
    didgital = value1 % 10;
    value1 = value1 / 10;

    array[sise1] = didgital;
    sise1--;



}
System.Console.WriteLine("Сам массив");
foreach (var item in array)
{
    
    System.Console.Write(item + " ");
}





