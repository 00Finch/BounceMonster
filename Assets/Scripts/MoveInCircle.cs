using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInCircle : MonoBehaviour
{


    public float rotationRadius, angularSpeed;

    float posX, posY, angle;

    // Update is called once per frame
    void Update()
    {
        posX = transform.parent.transform.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = transform.parent.transform.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector2(posX, posY);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360.0f)
        {
            angle = 0.0f;
        }
    }
}
