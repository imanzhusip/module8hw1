using System;

class Kvadrat
{
    private int[] array;

    public Kvadrat(int size)
    {
        array = new int[size];
    }

    public int this[int index]
    {
        get
        {
            return array[index];
        }
        set
        {
            array[index] = value * value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kvadrat arr = new Kvadrat(5);

       
        arr[0] = 1;
        arr[1] = 2;
        arr[2] = 3;
        arr[3] = 4;
        arr[4] = 5;

       
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"arr[{i}] = {arr[i]}");
        }

        Console.ReadKey();
    }
}
