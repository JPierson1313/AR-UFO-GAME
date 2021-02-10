using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterSystem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This code is mainly use to turn the Thrusters game object off when the player is not tapping/clicking the screen to make the UFO move upwards
        if(gameObject.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
    }
}
