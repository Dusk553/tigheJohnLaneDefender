using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobController : MonoBehaviour
{
    public playerLives playerLivesIntance;

    public float speed;
    public float health;
    private float timer;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;


        if (gameObject.name == "slime(Clone)" && timer <= 0)
        {
            speed = 2;
        }

        if (gameObject.name == "snail(Clone)" && timer <= 0)
        {
            speed = 1;
        }

        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if (health == 0)
        {
            Destroy(gameObject);
            playerLivesIntance.UpdateScore();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.name == "Defend Line")
        {
            Destroy(gameObject);
        }
        if(collision.gameObject.tag == "Bullet")
        {
            health -= 1;
            speed = 0;
            timer = .5f;

        }
    }
}

