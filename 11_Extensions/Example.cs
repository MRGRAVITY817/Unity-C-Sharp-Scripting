using UnityEngine;
using System.Collections;

public class SomeClass : MonoBehaviour
{
  void Start()
  {
    // Important. Even though the extension method has the parameter,
    // when we call it we don't fill the parentheses.
    // Also, this method doesn't need to be allocated, since it's been
    // defined as static.
    transform.ResetTransform();
  }
}
