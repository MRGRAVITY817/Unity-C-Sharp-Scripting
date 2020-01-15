using UnityEngine;
using System.Collections;

// For this attribute we don't need any parameters.
// ExecuteInEditMode enables to see changes in Unity
// in Scene mode.
[ExecuteInEditMode]
public class ColorScript : MonoBehaviour
{
  void Start()
  {
    renderer.sharedMaterial.color = Color.red;
  }
}

