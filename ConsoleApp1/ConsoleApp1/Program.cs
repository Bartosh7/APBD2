// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, Yo");
Console.WriteLine("Hello, Yo1!");
Console.WriteLine("Hello, Yo2!");
Console.WriteLine("Hello, Yo3!");

Console.WriteLine(avg([1, 2, 3, 4, 5]));
Console.WriteLine(getMax([1, 2, 3, 4, 5]));


static double avg(int[] tab)
{
    double sum = 0;
    for (int i = 0; i < tab.Length; i++)
    {
        sum += tab[i];
    }

    return sum / tab.Length;
}

static int getMax(int[] tab)
{
    int max = tab[0];
    for(int i=1; i<tab.Length; i++)
    {
        if (tab[i] > max)
        {
            max = tab[i];
        }
    }

    return max;
}