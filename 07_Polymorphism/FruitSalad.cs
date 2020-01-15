using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour
{
  void Start()
  {
    // This is called Upcasting.
    Fruit myFruit = new Apple();

    // Since the type is "Fruit",
    // the function will be called from the
    // parent class.
    myFruit.SayHello();
    myFruit.Chop();

    // Class re-specified for 
    // using functions in child class.
    // This is called Downcasting.
    Apple myApple = (Apple)myFruit;

    myApple.SayHello();
    myApple.Chop();
  }
}
