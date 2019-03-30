using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public CharacterController player;
    public float beatLevelWaitTime = 4;

    private bool beaten;

    void Start()
    {
    }

    public void BeatLevel()
    {
        this.player.beaten = !this.player.beaten;
        this.player.GetComponentInChildren<TrailRenderer>().enabled = !this.player.GetComponentInChildren<TrailRenderer>().enabled;
        this.beaten = !this.beaten;

        this.StartCoroutine(this.NextLevelCoroutine());
    }

    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    this.BeatLevel();
        //}
        if (beaten)
        {
            this.player.MoveLocally(new Vector3(0, 20 * Time.deltaTime));
        }
    }

    private IEnumerator NextLevelCoroutine()
    {
        yield return new WaitForSeconds(this.beatLevelWaitTime);
        SceneManager.LoadScene("SurrealScene");
        
    }
}
