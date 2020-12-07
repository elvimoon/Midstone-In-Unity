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
    public GameObject heal1;
    public GameObject heal2;


    public GameObject clearIcon;
    public GameObject clear1;
    public GameObject clear2;

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
        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A) && transform.position.x > -12.0f)
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x - 5.0f, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D) && transform.position.x < 9.0f)
        {
            shake.CamShake();
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x + 5.0f, transform.position.y);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        // need to collect 3 heal power ups to use power
        if (other.CompareTag("PowerHeal") && heal1.activeInHierarchy == false && heal2.activeInHierarchy == false && healIcon.activeInHierarchy == false)
        {
            heal1.SetActive(true);
        }
        else if (other.CompareTag("PowerHeal") && heal1.activeInHierarchy)
        {
            heal2.SetActive(true);
            heal1.SetActive(false);
        }
        else if (other.CompareTag("PowerHeal") && heal2.activeInHierarchy)
        {
            healIcon.SetActive(true);
            heal2.SetActive(false);
        }

        //need to collect 3 clear power ups to use power
        if (other.CompareTag("PowerClear") && clear1.activeInHierarchy == false && clear2.activeInHierarchy == false && clearIcon.activeInHierarchy == false)
        {
            clear1.SetActive(true);
        }
        else if (other.CompareTag("PowerClear") && clear1.activeInHierarchy)
        {
            clear2.SetActive(true);
            clear1.SetActive(false);
        }
        else if (other.CompareTag("PowerClear") && clear2.activeInHierarchy)
        {
            clearIcon.SetActive(true);
            clear2.SetActive(false);
        }
    }
}
