using UnityEngine;
using System.Collections;

public class Fruit
{
  public Fruit()
  {
    Debug.Log("1st Fruit Constructor Called");
  }
  // Parent functions should be named
  // as virtual.
  public virtual void Chop()
  {
    Debug.Log("The Fruit has been chopped.");
  }

  public virtual void SayHello()
  {
    Debug.Log("Hello, I am a Fruit.");
  }
}

public class Apple : Fruit 
{
  public Apple()
  {
    Debug.Log("1st Apple Constructor Called");
  }
  // Child functions should be named
  // as override.
  public override void Chop()
  {
    // By using 'base', we can also have an
    // parent's functionality.
    base.Chop();
    Debug.Log("The Apple has been chopped.");
  }

  public override void SayHello()
  {
    base.Chop();
    Debug.Log("Hello, I am an Apple.");
  }
}
