using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSystem : MonoBehaviour
{

    public GameObject player;
    public GameObject pillarSpawner;
    public GameObject bestScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            player.SetActive(true);
            pillarSpawner.GetComponent<PillarSystem>().enabled = true;
            bestScore.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
