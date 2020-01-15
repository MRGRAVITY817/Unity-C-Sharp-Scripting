using UnityEngine;
using System.Collections;

// When making an interface, you don't specify it.
// And also, the class which will use the interface should
// have all the members in the used interface.
public interface IKillable
{
  void Kill();
}

// Interfaces can be defined for Generic types.
public interface IDamageable<T>
{
  void Damage(T damageTaken);
}
