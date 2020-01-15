using UnityEngine;
using System.Collections;

public class WarBand : MonoBehaviour
{
  void Start()
  {
    Humanoid human = new Humanoid();
    Humanoid enemy = new Enemy();
    Humanoid orc = new Orc();

    // In this example, these 3 will all call 
    // the Humanoid Yell(), because their type
    // is defined and Humanoid.
    human.Yell();
    enemy.Yell();
    orc.Yell();
  }
}
