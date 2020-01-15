using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour
{
  public Transform target;

  void Update()
  {
    // Difference of angle between to positions
    Vector3 relativePos = target.position - transform.position;
    // Quaternion is a method to describe the angle in Unity.
    // LookRotation method gives an rotation of Z axis to
    // given vector.
    transform.rotation = Quaternion.LookRotation(relativePos);
  }
}
