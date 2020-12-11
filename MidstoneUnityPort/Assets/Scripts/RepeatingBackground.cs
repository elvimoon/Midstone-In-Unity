using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    public float speed;
    public float endX;
    private float length;


    void Start()
    {
        length = GetComponent<SpriteRenderer>().bounds.size.x * 2;

    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (transform.position.x < endX)
        {
            transform.position = new Vector2(transform.position.x + length, transform.position.y);

            /*
            //move the background image slowly left at a set speed
            transform.Translate(Vector2.left * speed * Time.deltaTime);

            //once the x position of image reaches a certain point, move the picture back to the right for infinite loop
            if (transform.position.x <= endX)
            {
                Vector2 pos = new Vector2(startX, transform.position.y);
                transform.position = pos;
            }
            */
        }
    }
}
