using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5.0f;
    private Vector3 moveDirection;


    private void Awake()
    {
        
    }

    private void Update()
    {
        moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }

        transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
    }
}
