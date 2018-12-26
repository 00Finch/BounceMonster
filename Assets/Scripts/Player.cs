using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class Player : MonoBehaviour
{

    Animator playerAnimator;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerAnimator.SetInteger("MoveState", 2);
            transform.position = new Vector2(transform.position.x - .05f, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            playerAnimator.SetInteger("MoveState", 1);
            transform.position = new Vector2(transform.position.x + .05f, transform.position.y);
        }
        else
        {
            playerAnimator.SetInteger("MoveState", 0);
        }
        transform.rotation = Quaternion.identity;
    }
}
