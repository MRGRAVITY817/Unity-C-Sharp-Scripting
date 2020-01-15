using UnityEngine;
using System.Collections;

public class Fruit
{
  public Fruit()
  {
    Debug.Log("1st Fruit Constructor Called");
  }

  public void Chop()
  {
    Debug.Log("The fruit has been chopped");
  }

  public void SayHello()
  {
    Debug.Log("Hello, I am a Fruit");
  }
}

public class Apple : Fruit
{
  public Apple()
  {
    Debug.Log("1st Apple Constructor Called");
  }

  // Since the parent class also has the same name of 
  // function, we have to override using "new"
  public new void Chop()
  {
    Debug.Log("The apple has been chopped");
  }

  public new void SayHello()
  {
    Debug.Log("Hello, I am an Apple");
  }
}
