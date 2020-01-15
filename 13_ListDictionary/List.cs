using UnityEngine;
using System.Collections;
using System.Collections.Generic; // This allows us to use Generic

public class SomeClass : MonoBehaviour
{
  void Start()
  {
    List<BadGuy> badguys = new List<BadGuy>();

    // The Add function adds the element into the list
    badguys.Add(new BadGuy("Harvey", 50));
    badguys.Add(new BadGuy("Magneto", 100));
    badguys.Add(new BadGuy("Pip", 5));

    // Sort function sorts the elements by the value which
    // is used as a parameter in the ComapareTo mehtod (Power)
    badguys.Sort();

    // foreach statement is used for doing some code
    // starting from an first index to the last index
    foreach(BadGuy guy in badguys)
    {
      print(guy.name + " " + guy.power);
    }

    // Clear function clears out the List
    badguys.Clear();
  }
}
