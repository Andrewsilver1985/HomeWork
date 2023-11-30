Random rnd = new Random();
int value = rnd.Next(1, 1000000);
int sise = 0;
Console.WriteLine(value);
int value1 = value;
int didgital;
//int count=0;
while (value > 0)
{

    value = value / 10;
    sise++;


}
System.Console.WriteLine(sise);

int[] array = new int[sise];

for (int i = 0; i < sise; i++)
{
    didgital = value1 % 10;
    value1 = value1 / 10;

    array[i] = didgital;
    System.Console.Write(array[i] + "  ");

}





