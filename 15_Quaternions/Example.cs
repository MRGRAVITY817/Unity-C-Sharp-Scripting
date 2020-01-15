using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour
{
  void Start()
  {
    // Quaternion.identity sets rotation vector
    // to (0,0,0).
    transform.rotation = Quaternion.identity;
  }
}
