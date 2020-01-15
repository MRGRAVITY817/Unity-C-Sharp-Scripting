using UnityEngine;
using System.Collections;

public class TurnColorScript : MonoBehaviour
{
  void OnEnable()
  {
    Events.OnClicked += TurnColor;
  }

  void OnDisable()
  {
    Events.OnClicked -= TurnColor;
  }

  void TurnColor()
  {
    Color col = new Color(Random.value, Random.value, Random.value);
    // renderer.material.color changes the color of the object
    // which has added this component script.
    renderer.material.color = col;
  }
}
