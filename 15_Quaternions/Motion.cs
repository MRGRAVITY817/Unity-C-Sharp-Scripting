using UnityEngine;
using System.Collections;

public class MotionScript : MonoBehaviour
{
  public float speed = 3f;

  void Update()
  {
    // Translate moves the point, not turning the angle.
    transfrom.Translate(-Input.GetAxis("Horizontal")*speed*Time.deltaTime, 0, 0);
  }
}
