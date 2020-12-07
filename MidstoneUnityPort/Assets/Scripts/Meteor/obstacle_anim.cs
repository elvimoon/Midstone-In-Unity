using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_anim : MonoBehaviour
{
    public Animator obsAnim;

    public void ObstacleMoving()
    {
        obsAnim.SetTrigger("obstacle_move");
    }

}
