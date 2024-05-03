using System;

namespace tut;

public enum Abschluss
{
  Nix,
  Abi,
  Bachelor,
  Master
}

public enum Jobtitel
{
  Bettler,
  Programmierer,
  Wirtschaftler
}

class Mitarbeiter
{
  // Namen : string
  // geburtsdatum : 
  // herkunft
  // abschluss (enum: abi, bachelor, master, nix)
  // jobtitel (enum: programmierer, wirtschaftler, bettler)
  // mitarbeiteranzahl unabhaengig
  string name;
  string geburtsdatum;
  string herkunft;
  Abschluss abschluss;
  Jobtitel jobtitel;
  Unternehmen unternehmen;

  static int mitarbeiteranzahl;

  public string Name { get { return this.name; } set { this.name = value; } }
  public Abschluss abschluss_prop { get { return this.abschluss; } set { this.abschluss = value; } }
  public Jobtitel jobtitel_prop { get { return this.jobtitel; } set { this.jobtitel = value; } }
  public Unternehmen unternehmen_prop { get { return this.unternehmen; } set { this.unternehmen = value; } }

  public string Geburtsdatum { get { return this.geburtsdatum; } }
  public string Herkunft { get { return this.herkunft; } }

  public Mitarbeiter(string name, string geburtsdatum, string herkunft, Abschluss abschluss, Jobtitel jobtitel, Unternehmen unternehmen)
  {
    this.name = name;

    if (this.isValid(geburtsdatum))
    {
      this.geburtsdatum = geburtsdatum;
    }

    this.herkunft = herkunft;
    this.abschluss = abschluss;
    this.jobtitel = jobtitel;
    this.unternehmen = unternehmen;

    mitarbeiteranzahl++;
  }

  // Hausaufgabe: schreibe eine funktion, die das Geburtsdatum auf richtigkeit pruef (mit schaltjahr)

}
