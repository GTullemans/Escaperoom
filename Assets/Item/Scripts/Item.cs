using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour  {

    
    virtual public void Use() { }
    virtual public Sprite Sprite() { return null; }
    
}
