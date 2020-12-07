using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButton : MonoBehaviour
{
    public GameObject clearButton;
    private Player_Anim p_power;

    private void Start()
    {
        p_power = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
    }

    public void ClearScreen()
    {
        p_power.PlayerPower();
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        foreach (GameObject obstacle in obstacles)
            GameObject.Destroy(obstacle);

        clearButton.SetActive(false);
    }

}
