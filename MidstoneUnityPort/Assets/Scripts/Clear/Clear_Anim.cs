using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear_Anim : MonoBehaviour
{
    public Animator clearAnim;
    public void ClearMoving()
    {
        clearAnim.SetTrigger("Clear_Move");
    }

}
