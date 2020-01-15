using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
  //Static variables are shared across all instances
  //of a class
  public static int playerCount = 0;

  void Start()
  {
    // Just an increment to show how much it has been called
    playerCount++;
  }
}
