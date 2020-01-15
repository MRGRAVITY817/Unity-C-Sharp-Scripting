using UnityEngine;
using System.Collections;
using System.Collections.Generic; // This allows us to use Generic

public class SomeOtherClass : MonoBehaviour
{
  void Start()
  {
    // Dictionaries should be declared with <KEY, Value>
    Dicitionary<string, BadGuy> badguys = new Dictionary<string, BadGuy>();

    BadGuy bg1 = new BadGuy("Harvey", 50);
    BadGuy bg2 = new BadGuy("Magneto", 100);

    // Add method adds element in to the dictionary with
    // the pair of key and value
    badguys.Add("gangster", bg1);
    badguys.Add("mutant", bg2);

    // You can save the value of the dictionary element
    // only if the lefthand member has the same type
    BadGuy magneto = badguys["mutant"];

    BadGuy temp = null;
    // Slow but safer mehtod to access to dictionary values
    if(badguys.TryGetValue("birds", out temp))
    {
      // success!
    }
    else
    {
      // failure!
    }
  }
}
