using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPower : MonoBehaviour
{
    public GameObject powerUp;
    // Start is called before the first frame update
    void Start()
    {
        GameObject temp = Instantiate(powerUp, transform.position, Quaternion.identity);
        temp.GetComponent<PowerUp>().power = 1; // replace the number with a randomizer call to shuffle the power list
    }

    // Update is called once per frame
    //void Update()
    //{
        
    //}
}
