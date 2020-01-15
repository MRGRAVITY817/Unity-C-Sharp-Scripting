using UnityEngine;
using System.Collections;

public class MultiCast : MonoBehaviour
{
  delegate void MultiDelegate();
  MultiDelegate myMultiDelegate;

  void Start()
  {
    // You can concatenate the methods by
    // using '+=' to delegate.
    myMultiDelegate += PowerUp;
    myMultiDelegate += TurnRed;

    // This is a safe way to check if
    // there are any methods stored in delegate
    // before executing the delegate.
    if(myMultiDelegate != null)
    {
      myMultiDelegate();
    }
  }

  void PowerUp()
  {
    print("Orb is powering Up!");
  }

  void TurnRed()
  {
    renderer.material.color = Color.red;
  }
}
