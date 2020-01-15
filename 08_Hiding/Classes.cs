using UnityEngine;
using System.Collections;

public class Humanoid
{
  public void Yell()
  {
    Debug.Log("Humanoid version of the Yell() method");
  }
}

public class Enemy : Humanoid
{
  new public void Yell()
  {
    Debug.Log("Enemy version of the Yell() method");
  }
}

public class Orc : Enemy 
{
  new public void Yell()
  {
    Debug.Log("Orc version of the Yell() method");
  }
}
