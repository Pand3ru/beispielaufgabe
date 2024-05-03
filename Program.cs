using System;

namespace tut;

class Program
{
  public static void Main(string[] args)
  {
    Unternehmen a = new Unternehmen("4gewinnt", Gf.GmbH, 2024, "Hohfederstrasse 40");
    Console.WriteLine(a.returnMoney());
    Console.WriteLine(a.returnName());
    Console.WriteLine(a.Year);
  }

}

