using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public enum PowerType { None, Power1, Power2 }

public class PowerUp : MonoBehaviour
{
    //public Inventory inventory;
    public float speed;
    public int power = 1; //Should never be 0
    
    // Start is called before the first frame update
    //void Start()
    //{
        
    //}

    // Update is called once per frame
    void Update()
    {
        //Move to the left each frame
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            other.GetComponent<Inventory>().heldPower = power;
            Debug.Log("Got power type " + power);
            Destroy(gameObject);
        }
    }
}
