using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Systems")]
    public float jumpForce = 100; //Force use to move the player up
    public GameObject player; //Player game object
    public GameObject Thrusters; //Thruster game object
    public bool isDead; //Boolean use to check if the player is dead or not
    public ScoreSystem ss; //Script used for keeping track of score
    
    void Awake()
    {
        //When the script is awake, we find the game object that contains the ScoreSystem script and set the score to 0
        ss = GameObject.FindGameObjectWithTag("SS").GetComponent<ScoreSystem>();
        ss.score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //When isDead boolean is false, the player can tap/click on the screen to set the player's velocity to zero, 
        //add force in the y axis based on the jumpForce variable and have thrusters art be set active to true
        if (!isDead)
        {
            if (Input.GetMouseButtonDown(0))
            {
                player.GetComponent<Rigidbody>().velocity = Vector2.zero;
                player.GetComponent<Rigidbody>().AddForce(new Vector2(0, jumpForce));
                Thrusters.SetActive(true);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        //When the player collides with any colliders, like the floor, ceiling, or pillars, then the isDead boolean will be set to true
        if(collision.gameObject)
        {
            isDead = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //When the player collides with the trigger box that is between the pillar, a point will be added to the score
        if(other.gameObject)
        {
            ss.score += 1;
        }
    }
}
