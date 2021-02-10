using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killzone : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        //Whenever a game object collides with an object that this script is attached to, it'll destroy the colliding object like the pillars for example
        if(collision.gameObject)
        {
            Destroy(collision.gameObject);
        }
    }
}
