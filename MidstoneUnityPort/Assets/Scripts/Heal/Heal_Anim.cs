using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal_Anim : MonoBehaviour
{
    public Animator healAnim;
    public void HealMoving()
    {
        healAnim.SetTrigger("healMove");
    }

}
