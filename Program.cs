using System;

namespace tut;

class Program
{
  public static void Main(string[] args)
  {
    // Unternehmen a = new Unternehmen("4gewinnt", Gf.GmbH, 2024, "Hohfederstrasse 40");
    //Console.WriteLine(a.returnMoney());
    //Console.WriteLine(a.returnName());
    //Console.WriteLine(a.Year);
    double[,] a = { { 0, 1, 2, 3, 4 }, { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 }, { 30, 31, 32, 33, 34 } };
    Console.WriteLine(Sum(a));
  }

  static double Sum(double[,] arr)
  {
    double sum = 0;

    for (int i = 1; i < arr.GetLength(0); i++) // Spalten SPICKER!!
    {
      for (int j = 0; j < i; j++) // Zeilen SPICKER!!
      {
        sum += arr[i, j]; // SPICKER!!
      }
    }
    return sum;
  }
}

