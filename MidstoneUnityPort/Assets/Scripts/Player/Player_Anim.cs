using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Anim : MonoBehaviour
{
    public Animator playerAnim;

    public void PlayerUp()
    {
        playerAnim.SetTrigger("Player_Up");
    }

    public void PlayerDown()
    {
        playerAnim.SetTrigger("Player_Down");
    }

    public void PlayerPower()
    {
        playerAnim.SetTrigger("Player_Power");
    }
}

