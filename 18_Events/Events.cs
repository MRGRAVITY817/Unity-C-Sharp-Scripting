using UnityEngine;
using System.Collections;

public class Events : MonoBehaviour
{
  // Events should be always derived from
  // pre-defined delegate.
  // EX) EventHandler in Dot NET.
  public delegate void ClickAction();
  public static event ClickAction OnClicked;

  void OnGUI()
  {
    if(GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "Click"))
    {
      if(OnClicked != null)
        Onclicked();
    }
  }
}
