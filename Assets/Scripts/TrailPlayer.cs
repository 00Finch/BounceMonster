using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailPlayer : MonoBehaviour
{

    public GameObject Player;
    public float xOffset;
    public float yOffset;

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Player.transform.position;
        transform.position = new Vector2(pos.x + xOffset, pos.y + yOffset);
    }
}
