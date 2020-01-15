using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
  void Start()
  {
    // Always remember to make "new" container
    // when we are gonna use a class.
    Player myPlayer = new Player();

    // Properties can be used just like variables
    myPlayer.Experience = 5; // Set
    int x = myPlayer.Experience; // Get
  }
}
