using UnityEngine;
using System.Collections;

public class SpinScript : MonoBehaviour
{
  // By using the squared brackets []
  // we can give an attribute to some
  // members. In this case, we limit the
  // range of speed bounded by +-100 interval.
  [Range(-100, 100)] public int speed = 0;

  void Update()
  {
    // speed*Time.deltaTime = amount of movement
    transform.Rotate(new Vector3(0, speed*Time.deltaTime, 0));
  }
}

