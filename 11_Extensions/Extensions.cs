using UnityEngine;
using System.Collections;

// It is common to create a class to contain all your
// extenstion methods.
public static class ExtensionMethods
{
  // When we make extenstion method, we should make it static.
  // Also, in parameter we have to put 'this' and the method type.
  public static void ResetTransformation(this Transfrom trans)
  {
    trans.position = Vector3.zero;
    trans.localRotation = Quaternion.identity;
    trans.localScale = new Vector3(1,1,1);
  }
}
