using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeze : MonoBehaviour
{

    public int duration;
    public GameObject deathDrop;
    float xPosition;

    void OnTriggerEnter2D(Collider2D collision)
    {
        xPosition = collision.transform.position.x;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.transform.position = new Vector2(xPosition, transform.GetChild(0).gameObject.transform.position.y);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (duration > 0)
        {
            collision.transform.position = new Vector2(xPosition, collision.transform.position.y);
            duration--;
        }
        else if (duration == 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            Instantiate(deathDrop, new Vector2(transform.position.x, transform.position.y + 0.5f), Quaternion.identity);
            duration--;
        }
    }


}
