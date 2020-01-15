using UnityEngine;
using System.Collections;

public class PropertiesAndCoroutines : MonoBehaviour
{
  public float smoothing = 7f;
  // Remember properties? It's the members with
  // get and set.
  public Vector3 Target
  {
    get{ return target;}
    set
    {
      target = value;
      // When we rewrite this member,
      // the coroutine should be first stopped.
      StopCoroutine("Movement");
      // This is another way to state the Start Coroutine.
      StartCoroutine("Movement", target);
    }
  }

  private Vector3 target;

  IEnumerator Movement(Vector3 target)
  {
    while(Vector3.Distance(transform.position, target)>0.05f)
    {
      transform.position = Vector3.Lerp(transform.position, target, smoothing*Time.deltaTime);
      yield return null;
    }
  }
}
