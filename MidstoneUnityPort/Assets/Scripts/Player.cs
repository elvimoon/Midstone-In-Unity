using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //required for restarting game if player dies, needs access to the scene

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    //values set public to allow changing values in inspector window
 
    public float speed;
    public float MaxHeight;
    public float MinHeight;

    public int health = 3;

    private void Update()
    {
        //Restart game if player dies by reloading the active scene
        if (health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //SceneManager.LoadScene("GameOver"); to load gameover scene instead
        }


        //to enable player movement up/down to look better rather than instant teleportation
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //Player Movement Inputs Using Up/Down Arrow or W/S Key
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) && transform.position.y < MaxHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            //transform.position = targetPos;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && transform.position.y > MinHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }

    }
}
