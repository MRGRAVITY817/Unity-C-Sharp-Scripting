using UnityEngine;
using System.Collections;

// Classes can be inherited only one. It's like a parent.
// Interfaces can be many. It's like a ability.
public class Avatar : MonoBehaviour, IKillable, IDamagable<float>
{
  // Should be added from IKillable
  public void Kill()
  {
    // Something to write.
  }

  // Should be added from IDamageable
  public void Damage(float damageTaken)
  {
    // Something to write.
  }
}
