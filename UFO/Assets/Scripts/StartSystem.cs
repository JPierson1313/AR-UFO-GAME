using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSystem : MonoBehaviour
{

    public GameObject player;
    public GameObject pillarSpawner;
    public GameObject bestScore;
    public GameObject imageTarget;

    // Start is called before the first frame update
    void Start()
    {
        imageTarget = GameObject.FindGameObjectWithTag("Image");    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            GameObject UFO = Instantiate(player, new Vector3(-2.95f, 0.5f, 0), transform.rotation);
            UFO.transform.parent = imageTarget.transform;
            pillarSpawner.GetComponent<PillarSystem>().enabled = true;
            bestScore.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
