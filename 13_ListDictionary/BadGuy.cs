using UnityEngine;
using System.Collections;
using System; // This allows the IComparable Interface

public class BadGuy : IComparable<BadGuy>
{
  public string name;
  public int power;

  public BadGuy(string newName, int newPower)
  {
    name = newName;
    power = newPower;
  }

  // This functions should be added for
  // using the IComparable Interface
  public int CompareTo(BadGuy other)
  {
    if(other == null)
    {
      return 1;
    }
    return (power-other.power);
  }
}
