using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReflectOnCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // check if obj is player object
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000000), ForceMode2D.Force);
        }
    }
}
