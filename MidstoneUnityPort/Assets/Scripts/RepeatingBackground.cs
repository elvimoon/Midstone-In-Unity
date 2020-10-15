using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    public float speed;

    public float endX;
    public float startX;

    private void Update()
    {
        //move the background image slowly left at a set speed
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //once the x position of image reaches a certain point, move the picture back to the right for infinite loop
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }



}
