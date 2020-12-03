using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealButton : MonoBehaviour
{
    public GameObject healbutton;
    private Player_Anim p_power;

    private void Start()
    {
        p_power = GameObject.FindGameObjectWithTag("PlayerSprite").GetComponent<Player_Anim>();
    }

    public void HealPlayer()
    {
        p_power.PlayerPower();
        GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health += 1;
        healbutton.SetActive(false);
    }
}
