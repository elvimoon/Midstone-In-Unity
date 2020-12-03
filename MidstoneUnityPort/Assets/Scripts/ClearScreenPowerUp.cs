using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearScreenPowerUp : MonoBehaviour
{
    //public Inventory inventory;
    public float speed;
    //  public int power = 1; //Should never be 0

    public GameObject effect;

    // Update is called once per frame
    void Update()
    {
        //Move to the left each frame
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Player taking damage upon collision with obstacle
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);

          //  GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
           // foreach (GameObject obstacle in obstacles)
            //    GameObject.Destroy(obstacle);

            Destroy(gameObject);
        }
    }
}
