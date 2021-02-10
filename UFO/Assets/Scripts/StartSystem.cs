using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSystem : MonoBehaviour
{
    public GameObject player; //Player game object
    public GameObject pillarSpawner; //Pillar Spawner game object
    public GameObject bestScore; //Best Score game object
    public GameObject imageTarget; //Vuforia Image Target game object
    public GameObject playerSpawner; //Player Spawner game object

    // Start is called before the first frame update
    void Start()
    {
        //Set imageTarget to a game object with the tag "Image"
        imageTarget = GameObject.FindGameObjectWithTag("Image");    
    }

    // Update is called once per frame
    void Update()
    {
        //When the player taps/clicks on the screen, 
        if (Input.GetMouseButton(0))
        {
            GameObject UFO = Instantiate(player, playerSpawner.transform.position, transform.rotation);
            UFO.transform.parent = imageTarget.transform;
            pillarSpawner.GetComponent<PillarSystem>().enabled = true;
            bestScore.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
