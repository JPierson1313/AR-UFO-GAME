using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOverSystem : MonoBehaviour
{
    public GameObject bestScore;
    public GameObject player;
    public GameObject imageTarget;
    public GameObject pillarSpawner;

    private void OnEnable()
    {
        bestScore.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            GameObject[] pillar = GameObject.FindGameObjectsWithTag("Pillar");
            for (int i = 0; i < pillar.Length; i++)
            {
                Destroy(pillar[i]);
            }

            GameObject UFO = Instantiate(player, new Vector3(-2.95f, 0.5f, 0), transform.rotation);
            UFO.transform.parent = imageTarget.transform;
            bestScore.SetActive(false);

            gameObject.SetActive(false);
        }
    }
}
