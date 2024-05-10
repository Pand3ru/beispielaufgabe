using System;

namespace idk;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(fak(50000000));
    }
    public static int fak(int x)
    {
        int a = 1;
        for (int i = x; i > 0; i--) // i--;
        {
            a = a * i;
        }
        // for loop
        return a;
    }







}
