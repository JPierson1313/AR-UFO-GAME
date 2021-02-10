using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSystem : MonoBehaviour
{
    [Header("Pillar Systems")]
    public GameObject pillars; //Pillar game object
    public float countDownTimer; //Countdown timer used to spawn in new pillars
    public float pillarMoveForce; //Force needed to intially move the pillars

    public PlayerController pc; //PlayerController script
    public GameObject gameOverScreen; //Game Over Screen game object

    public float hMin; //Minimum height for pillars being spawned in
    public float hMax; //Maximum height for pillars being spawned in
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pc = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        if (!pc.isDead)
        {
            GameObject pillar;
            countDownTimer -= Time.deltaTime;
            if(countDownTimer < 0)
            {
                Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(hMin, hMax));
                pillar = Instantiate(pillars, spawnPos, transform.rotation) as GameObject;
                pillar.GetComponent<Rigidbody>().velocity = new Vector2(-pillarMoveForce, 0);
                pillar.transform.parent = gameObject.transform;
                countDownTimer = 1.1f;
            }
        }
        else
        { 
            gameOverScreen.SetActive(true);
        }
    }
}
