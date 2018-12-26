using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject deathDrop;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Instantiate(deathDrop, new Vector2(other.transform.position.x - 0.35f, other.transform.position.y - 0.35f), Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
