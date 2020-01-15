using UnityEngine;
using System.Collections;

public class FruitSalad : MonoBehaviour
{
  void Start()
  {
    Apple myApple = new Apple();
    myApple.SayHello();
    myApple.Chop();
    
    // Upcasting.
    Fruit myFruit = new Apple();
    // Even the type is Fruit, the functions in
    // the Fruit class are virtual, so the Apple
    // class functions will be called.
    myFruit.SayHello();
    myApple.Chop();

  }
}
