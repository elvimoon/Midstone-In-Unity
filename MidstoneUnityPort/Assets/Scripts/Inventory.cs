using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int heldPower = 0;
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            switch (heldPower)
            {
                default:
                    break;
            }
            //reset the held power to "None"
            heldPower = 0;
        }
    }


}
