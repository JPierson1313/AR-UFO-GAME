using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSystem : MonoBehaviour
{
    public GameObject bestScore; //Game object that shows the player's highest score
    public GameObject player; //Player game object
    public GameObject imageTarget; //Vuforia's Image Target object
    public GameObject playerSpawner; //Spawner for the player

    void OnEnable()
    {
        //When script is enabled, set bestScore game object to being active
        bestScore.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //When the player taps/clicks on the screen, the Player game object and all pillars will be destroyed in the scene
        //Then, a new Player game object will be instantiated and set its parent to the AR Image Target so that way it stays a part of it
        //Then the bestScore and also this game object the script is attach to will become inactive as part of the game restarting
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            GameObject[] pillar = GameObject.FindGameObjectsWithTag("Pillar");
            for (int i = 0; i < pillar.Length; i++)
            {
                Destroy(pillar[i]);
            }

            GameObject UFO = Instantiate(player, playerSpawner.transform.position, transform.rotation);
            UFO.transform.parent = imageTarget.transform;
            bestScore.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
