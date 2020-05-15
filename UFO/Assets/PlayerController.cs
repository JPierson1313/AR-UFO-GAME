using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Systems")]
    public float jumpForce = 100;
    public GameObject player;
    public GameObject Thrusters;
    public bool isDead;

    public ScoreSystem ss;

    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        ss = GameObject.FindGameObjectWithTag("SS").GetComponent<ScoreSystem>();
    }

    // Update is called once per frame
    void Update()
    {
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

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject)
        {
            isDead = true;
            gameOverCanvas.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject)
        {
            ss.score += 1;
        }
    }

}
