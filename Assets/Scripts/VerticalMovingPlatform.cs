using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    private bool isMovingUp = false;
    public int speed;

    void Update()
    {

        if (isMovingUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);

            if (transform.position.y <= -40)
            {
                isMovingUp = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);

            if (transform.position.y >= 40)
            {
                isMovingUp = true;
            }
        }
    }
}
