using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection;

    private void Awake()
    {
        moveDirection = Vector3.zero;
    }

    private void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveDirection += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDirection += Vector3.down;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveDirection += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            moveDirection += Vector3.right;
        }

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
