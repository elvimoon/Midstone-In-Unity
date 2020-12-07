using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    //object pool

    //set up array of spawner patterns by having multiple spawn pattern gameobjects to place into inspector window
    public GameObject[] obstaclePattern;

    private float timeBetweenSpawn;
    public float startTimeBetweenSpawn;
    public float decreaseTime;
    public float minimumTime = 0.50f;

    private void Update()
    {
        //Setting up the obstacle spawn frequency
        if (timeBetweenSpawn <= 0)
        {
            //randomize the spawn of obstacles via array 
            int random = Random.Range(0, obstaclePattern.Length);

            Instantiate(obstaclePattern[random], transform.position, Quaternion.identity);
            timeBetweenSpawn = startTimeBetweenSpawn;

            //limit the frequency of spawn so it doesn't become impossible to dodge
            if (startTimeBetweenSpawn > minimumTime)
            {
                //allow obstacles to speed up as game progresses 
                startTimeBetweenSpawn -= decreaseTime;
            }

        }
        else
        {
            timeBetweenSpawn -= Time.deltaTime;
        }
    }
}
