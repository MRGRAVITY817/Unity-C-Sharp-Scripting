using UnityEngine;
using System.Collections;

public class Gravity : MonoBehaviour
{
  public Transform target;

  void Update()
  {
    Vector3 relativePos = (target.position + new Vector3(0, 1.5f, 0)) - transform.position;
    // You can also save the LookRotation method in 
    // Quaternion member.
    Quaternion rotation = Quaternion.LookRotation(relativePos);

    // You can also save the localRotation method in
    // Quaternion member.
    Quaternion current = transform.localRotation;

    // The term "slerp" stands for "Spherical Interpolation",
    // which you make a curved route to the destination.
    // Required parameters are start, destination, and speed.
    transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime);
    transfrom.Translate(0, 0, 3*Time.deltaTime);
  }
}
