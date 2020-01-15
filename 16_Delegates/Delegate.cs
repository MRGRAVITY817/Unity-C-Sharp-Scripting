using UnityEngine;
using System.Collections;

public class Delegate : Monobehaviour
{
  // Delegates are members that stores the functionality
  // of methods. The connection will be sufficed if and only
  // those which have the same parameter type field.
  delegate void MyDelegate(int num);
  MyDelegate myDelegate;

  void Start()
  {
    // You can store like this.
    myDelegate = PrintNum;
    myDelegate(50);

    myDelegate = DoubleNum;
    myDelegate(50);
  }

  void PrintNum(int num)
  {
    print("Print Num: " + num);
  }

  void DoubleNum(int num)
  {
    print("Double Num: " + num*2);
  }
}
