// ausschnitt main:

double[,] a = { { 0, 1, 2, 3, 4 }, { 10, 11, 12, 13, 14 }, { 20, 21, 22, 23, 24 }, { 30, 31, 32, 33, 34 } };
Console.WriteLine(Sum(a));

// funktion:
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
