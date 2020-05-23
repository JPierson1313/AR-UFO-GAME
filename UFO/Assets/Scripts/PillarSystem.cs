using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarSystem : MonoBehaviour
{
    [Header("Pillar Systems")]
    public GameObject pillars;
    public float countDownTimer;
    public float pillarMoveForce;

    public PlayerController pc;
    public GameObject gameOverScreen;

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
                Vector2 spawnPos = new Vector2(transform.position.x, Random.Range(-2.15f, 2.15f));
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
