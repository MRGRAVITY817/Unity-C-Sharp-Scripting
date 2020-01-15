using UnityEngine;
using System.Collections;

public class CoroutinesExample : MonoBehaviour
{
  public float smoothing = 1f;
  public Transform target;

  void Start()
  {
    StartCoroutine(MyCoroutine(target));
  }

  IEnumerator MyCoroutine(Transform target)
  {
    // Execute this loop until the distance between
    // target and object is no longer narrower than
    // 0.05f.
    while(Vector3.Distance(transform.position, target.position) > 0.05f)
    {
      // Lerp method is "Linear Interpolation", which is to approach to
      // target in linear manner.
      transform.position = Vector3.Lerp(transform.position, target.position, smoothing*Time.deltaTime);

      // When we use 'return null', we wait for the frame change.
      yield return null;
    }

    print("Reached the target.");
    // This makes this method stop for designated amount of time.
    yield return new WaitForSeconds(3f);
    
    print("MyCoroutine is now finished.");
  }
}
