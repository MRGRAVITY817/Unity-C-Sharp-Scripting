using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour
{
  // Once the event has occurred, it also 
  // has to be turned off.
  void OnEnable()
  {
    // No need to allocate because the event
    // type was static.
    Events.OnClicked += Teleport;
  }

  void OnDisable()
  {
    Events.OnClicked -= Teleport;
  }

  void Teleport()
  {
    Vector3 pos = transform.position;
    pos.y = Random.Range(1.0f, 3.0f);
    transform.position = pos;
  }
}

