using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PowerType { Heal, Bomb }

public class HealPowerUp : MonoBehaviour
{
    //public Inventory inventory;
    public float speed;
    public PowerType power;
    public int heal = 1;

    public GameObject effect;

    private void Start()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("HealSprite");

        if (obj.Length > 0)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                Heal_Anim healMove = obj[i].GetComponent<Heal_Anim>();
                if (healMove)
                {
                    healMove.HealMoving();
                }
            }
        }
    }

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
            //other.GetComponent<Player>().health += heal;
            //Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }

        else if (other.CompareTag("Laser"))
        {
            Destroy(gameObject);
        }

        //if (other.CompareTag("Player"))
        //{
        //    Instantiate(effect, transform.position, Quaternion.identity);
        //    switch (power)
        //    {
        //        case PowerType.Heal:
        //            other.GetComponent<Inventory>().heldHeal = Mathf.Min(GetComponent<Inventory>().heldHeal + 1, GetComponent<Inventory>().maxHeldPickups);
        //            Debug.Log("Got Heal Power");
        //            break;
        //        case PowerType.Bomb:
        //            other.GetComponent<Inventory>().heldBomb = Mathf.Min(GetComponent<Inventory>().heldHeal + 1, GetComponent<Inventory>().maxHeldPickups);
        //            Debug.Log("Got Bomb Power");
        //            break;
        //    }
        //    Destroy(gameObject);
        //}
    }
}

