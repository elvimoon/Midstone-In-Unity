using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //required for restarting game if player dies, needs access to the scene
using UnityEngine.UI; //required for adding any ui

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public float Yincrement;
    //values set public to allow changing values in inspector window
 
    public float speed;
    public float MaxHeight;
    public float MinHeight;

    public int health = 3;

    public GameObject effect;

    public Text healthDisplay;
    public GameObject gameOver;
    public GameObject healIcon;
    public GameObject clearIcon;

    private CameraShake shake;
    private Player_Anim p_up;
    private Player_Anim p_down;
    private Player_Anim p_power;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CameraShake>();
        p_up = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
        p_down = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
        p_power = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
    }


    private void Update()
    {
        healthDisplay.text = health.ToString();

        //Brings up game over screen when player dies
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }

        //to enable player movement up/down to look better rather than instant teleportation
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        //Player Movement Inputs Using Up/Down Arrow or W/S Key
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) && transform.position.y < MaxHeight)
        {
            //play camera shake effect when player moves
            p_up.PlayerUp();
            shake.CamShake();

            //spawn player effect when player moves
            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S) && transform.position.y > MinHeight)
        {
            //play camera shake effect when player moves
            p_down.PlayerDown();
            shake.CamShake();

            //spawn player effect when player moves
            Instantiate(effect, transform.position, Quaternion.identity);

            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            //transform.position = targetPos;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PowerHeal"))
        {
            //p_power.PlayerPower();
            healIcon.SetActive(true);
        }
        else if (other.CompareTag("PowerClear"))
        {
           // p_power.PlayerPower();
            clearIcon.SetActive(true);
        }

    }
}
