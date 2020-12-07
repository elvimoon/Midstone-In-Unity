using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    public GameObject healbutton;
    private Player_Anim p_power;
    public GameObject healEffect;
    //public Transform player;
    public Vector3 player;

    private void Start()
    {
        p_power = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
    }

    public void HealPlayer()
    {
        p_power.PlayerPower();
        Instantiate(healEffect, player, Quaternion.identity);
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health += 1;
        healbutton.SetActive(false);
    }
}
