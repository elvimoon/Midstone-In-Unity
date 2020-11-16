using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum PowerType { None, Power1, Power2 }

public class HealPowerUp : MonoBehaviour
{
    //public Inventory inventory;
    public float speed;
  //  public int power = 1; //Should never be 0
    public int heal = 1;

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
            //spawn obstacle destroy particle effect
            Instantiate(effect, transform.position, Quaternion.identity);
            //increase player health, set heal # in inspector
            other.GetComponent<Player>().health += heal;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }

        /*
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Inventory>().heldPower = power;
            Debug.Log("Got power type " + power);
            Destroy(gameObject);
        }
        */
    }
}

