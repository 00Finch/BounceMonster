using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{

    public GameObject itemToSpawn;
    public int columns;
    public int rows;


    void Start()
    {
        float width = itemToSpawn.GetComponent<SpriteRenderer>().bounds.size.x;
        float height = itemToSpawn.GetComponent<SpriteRenderer>().bounds.size.y;

        for (float y = -rows; y < rows; y += 0.5f)
        {
            float x = .75f * -columns;
            for (int col = -columns; col < columns; col++)
            {
                x += .75f;
                Instantiate(itemToSpawn, new Vector3(x, y, 0), Quaternion.identity);
            }
        }
    }

    void Update()
    {

    }
}
