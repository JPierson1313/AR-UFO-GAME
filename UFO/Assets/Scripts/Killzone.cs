using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is used for an empty gameobject that has a box collider on it that will destroy the pillars when they reach the end of the left side of the board
/// </summary>
public class Killzone : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //Basic code of destroying any gameobject that collides with the object this script is attach to
        if(collision.gameObject)
        {
            Destroy(collision.gameObject);
        }
    }
}
