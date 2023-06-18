using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{ 
    void Start()
    {
        transform.parent = transform;
        transform.position = transform.parent.position;
        transform.rotation = transform.parent.rotation;
    }

   
}
