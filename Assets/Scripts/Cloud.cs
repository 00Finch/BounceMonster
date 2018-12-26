using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{

    public int health = 100;
    public GameObject deathDrop;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            health--;
            if (health < 0)
            {
                Instantiate(deathDrop, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
