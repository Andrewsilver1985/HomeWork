Random rnd = new Random();
int sise = 10;

double[] array = new double[10];
for (int i = 0; i < sise; i++)
{
    array[i] = rnd.NextDouble();
    System.Console.Write(array[i] + "  ");


}

double razn=FindRazn(array);
System.Console.WriteLine($"разница Max b Min в  массиве=>  {razn}   ");

static double FindRazn(double[] array)
{
    double max = array[0];
    double min = array[0];


    for (int i = 1; i < 10; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }

        if (array[i] < min)
        {
            min = array[i];
        }
        
    
    }
    double razn =max-min;
    return razn;
   


}
