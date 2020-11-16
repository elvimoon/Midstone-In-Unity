using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int pickupsPerUse; //the number of pickups needed to use a powerup
    public int maxHeldPickups; // the maximum number of pickups that can be stored
    // the number of each pickup held
    public int heldHeal = 0;
    public int heldBomb = 0;


    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (heldHeal >= pickupsPerUse)
            {
                //heal the player
                GetComponent<Player>().health += 1;

                heldHeal -= pickupsPerUse;
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (heldBomb >= pickupsPerUse)
            {
                // clear obstacles on screen
                GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
                foreach (GameObject obstacle in obstacles)
                    GameObject.Destroy(obstacle);

                heldBomb -= pickupsPerUse;
            }
        }
    }


}
