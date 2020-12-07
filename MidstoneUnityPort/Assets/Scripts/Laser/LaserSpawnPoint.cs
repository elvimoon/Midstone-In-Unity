using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawnPoint : MonoBehaviour
{
    public GameObject[] laser;

    void Start()
    {
        int laser_num = Random.Range(0, 4);
        Instantiate(laser[laser_num], transform.position, Quaternion.identity);
        //Instantiate(laser, transform.position, Quaternion.identity);
    }

}
