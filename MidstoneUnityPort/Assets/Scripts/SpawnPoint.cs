using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject[] obstacle;

    void Start()
    {
        int obstacle_num = Random.Range(0, 3);
        Instantiate(obstacle[obstacle_num], transform.position, Quaternion.identity);
    }

}
