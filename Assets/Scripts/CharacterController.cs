﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 10;
    public bool beaten;

    private Rigidbody2D body;

    void Start()
    {
        this.body = this.GetComponent<Rigidbody2D>();
    }
    void Update()
    {

    }


    void LateUpdate()
    {
        if (!this.beaten)
        {
            this.HandleMovement();
        }
    }

    public void MoveLocally(Vector3 moveDelta)
    {
        moveDelta = transform.TransformDirection(moveDelta);
        if (this.beaten) print("MOVEDELTA::: " + moveDelta.ToString());
        body.MovePosition(this.transform.position + moveDelta);
    }

    void HandleMovement()
    {
        float horizontalMovement = 0, verticalMovement = 0;
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            verticalMovement -= speed;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            verticalMovement += speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            horizontalMovement -= speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            horizontalMovement += speed;
        }

        Vector2 moveDirection = new Vector3(horizontalMovement, verticalMovement, 0);
        this.MoveLocally(moveDirection);
    }
}
