using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 10;

    /// <summary>
    /// If this character is being controlled by an external script, 
    /// and not the player with inputs.
    /// </summary>
    public bool controlled = false;

    private Rigidbody2D body;

    void Start()
    {
        this.body = this.GetComponent<Rigidbody2D>();
    }


    void LateUpdate()
    {
        if (!this.controlled)
        {
            this.HandleMovement();
        }
    }

    public void MoveLocally(Vector3 moveDelta)
    {
        moveDelta = transform.TransformDirection(moveDelta);
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
