using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGulper : MonoBehaviour
{
    public CharacterController player;
    private bool gulping = false;

    public Vector3 gulpVector = new Vector3(0, -1.5f, 0);
    void Start()
    {
        
    }

    void Update()
    {
        if (!gulping) { return; }
        player.GetComponent<Rigidbody2D>().MovePosition(player.transform.position + gulpVector * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) { return; }
        player.controlled = true;
        this.gulping = true;
        this.transform.parent.gameObject.GetComponent<Collider2D>().enabled = false;
    }
}
