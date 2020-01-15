using UnityEngine;
using System.Collections;

public class Player
{
  //Member variables can be referred to as fields.
  private int experience;

  //Experience is a basic property
  public int Experience
  {
    get
    {
      // In get, we write something to get return,
      // normally to "read" something.
      return experience;
    }
    set
    {
      // In set, we write something to happen
      // automatically, "writing" something.
      experience = value;
      // "value" is a predefined value which has
      // dynamic type. No need to be specified.
    }
  }
  // We can also remove "get" to make it write-only,
  // Or to remove "set" to make it read-only.

  //Level is a "property" that converts experience
  //points into the level of a player automatically
  public int Level
  {
    get
    {
      return experience/1000;
    }
    set
    {
      experience = value*1000;
    }
  }
  //This is an example of an auto-implemented property 
  //Very basic form of making the property.
  public int Health{ get; set;}
}
