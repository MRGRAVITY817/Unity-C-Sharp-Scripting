using UnityEngine;
using System.Collections;

public class Game
{
  void Start()
  {
    // Always write new when using the class :)
    Enemy enemy1 = new Enemy();
    Enemy enemy2 = new Enemy();
    Enemy enemy3 = new Enemy();

    // You can access a static variable by using the class
    // name and the dot operator.
    int x = Enemy.enemyCount;
    // Since the enemyCount is static, the result should be 3, 
    // not 1. Because even if you make "new" Enemy(), the static
    // property saves what it used to have before.
  }
}
