using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public CharacterController player;

    private bool beaten;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void BeatLevel()
    {
        this.player.beaten = !this.player.beaten;
        this.beaten = !this.beaten;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.BeatLevel();
        }
        if (beaten)
        {
            this.player.MoveLocally(new Vector3(0, 20 * Time.deltaTime));
        }
    }
}
