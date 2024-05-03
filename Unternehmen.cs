using System;

namespace tut;

public enum Gf
{
  GmbH, EK, AG
}

class Unternehmen
{
  private string name;
  private Gf gf;
  private uint year;
  private static int ma;
  private string addr;
  private double money;

  public double Year { get { return this.year; } }
  public int Ma
  {
    get { return Unternehmen.ma; }
    set { Unternehmen.ma = value; }
  }

  public Unternehmen(string name, Gf gf, uint year, string addr, int ma = 1)
  {
    this.name = name;
    this.gf = gf;
    this.year = year;
    Unternehmen.ma = ma;
    this.addr = addr;

    if (gf == Gf.GmbH)
    {
      this.money = 25000;
    }
    else
    {
      this.money = 0;
    }
  }

  public double returnMoney()
  {
    return this.money;
  }
  public string returnName()
  {
    return this.name;
  }
}

