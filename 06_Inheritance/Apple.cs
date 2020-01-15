using UnityEngine;
using System.Collections;

public class Apple : Fruit
{
  // This is the first Constructor for the Apple class.
  // It calls the parent construtor immediately, even
  // befor it runs.
  public Apple()
  {
    // Notice how Apple has access to the public variable
    // color, whic is a part of the parent Fruit class.
    color = "red";
    Debug.Log("1st Apple Constructor Called");
  }

  // This is the second constructor for the Apple class.
  // It specifies which parent constructor will be called.
  // using the "base" keyword.
  public Apple(string newColor) : base(newColor)
  {
    // base(newColor) = Fruit(newColor)
    // Notice how this constructor doesn't set the color
    // since the base constructor sets the color that 
    // is passed as an arguement.
    Debug.Log("2nd Apple Constructor Called");
  }
}
