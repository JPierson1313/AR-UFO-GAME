using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMovement : MonoBehaviour
{
    PlayerController pc; //PlayController script

    // Start is called before the first frame update
    void Start()
    {
        //Finds the player game object that has the PlayerController script attach to it and set it to the variable name pc
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //If isDead boolean set to true, then we tell the pillar to stop moving by setting its velocity to 0;
        if (pc.isDead)
        {
            GetComponent<Rigidbody>().velocity = Vector2.zero;
        }
    }
}
