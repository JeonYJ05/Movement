using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Color newColor;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("충돌감지");
            Renderer renderer = collision.gameObject.GetComponent<Renderer>();
            renderer.material.color = newColor;
            
        }

    }
    


}
