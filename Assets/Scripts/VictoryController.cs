using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryController : MonoBehaviour
{
    // This script is a joke. YOU CANT CONTROL VICTORY!

    // hullo noodles

    public float circleSpeed = 0.01f;
    public float circleSize = 0.05f;
    public float circleGrowSpeed = 0.01f;

    private Camera cam;
    private Rigidbody2D body;

    void Start()
    {
        this.body = this.GetComponent<Rigidbody2D>();
        this.cam = Camera.main;
    }

    void Update()
    {
        float xPos = Mathf.Sin(Time.time * circleSpeed) * circleSize;
        float yPos = Mathf.Cos(Time.time * circleSpeed) * circleSize;
        circleSize += circleGrowSpeed* Time.deltaTime;

        this.transform.position = new Vector3(xPos, yPos, this.transform.position.z);
    }
}
