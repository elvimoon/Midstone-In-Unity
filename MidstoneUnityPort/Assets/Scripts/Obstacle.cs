using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage = 1;
    public float speed;

    public GameObject effect;
    private obstacle_anim obsMove;

    private void Start()
    {
       obsMove = GameObject.FindGameObjectWithTag("ObstacleSprite").GetComponent<obstacle_anim>();
    }

    private void Update()
    {
        //Obstacle moving continually left
        //obsMove.ObstacleMoving();
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Player taking damage upon collision with obstacle
        if (other.CompareTag("Player"))
        {
            //spawn obstacle destroy particle effect
            Instantiate(effect, transform.position, Quaternion.identity);
            //lower player health, set damage # in inspector
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }

    }
}
