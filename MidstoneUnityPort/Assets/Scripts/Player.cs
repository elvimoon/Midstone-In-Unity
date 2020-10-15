using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    //set public so we can change Y values of player movement in inspector window
    public float Yincrement;
    public float speed;

    private void Update()
    {
        //to enable player movement up/down to look better rather than instant teleportation
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //Player Movement Inputs Using Up/Down Arrow or W/S Key
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }

    }
}
