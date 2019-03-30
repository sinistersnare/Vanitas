using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMover : MonoBehaviour
{
    public Vector3 moveVector = new Vector3(-5, 0, 0);
    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        this.body = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.body.MovePosition(this.transform.position + this.moveVector * Time.deltaTime);
    }
}
