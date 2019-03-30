using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public string nextSceneName = "SurrealScene";
    public CharacterController player;
    public float beatLevelWaitTime = 4;

    private bool beaten;

    void Start()
    {
    }

    public void BeatLevel()
    {
        this.player.controlled = !this.player.controlled;
        TrailRenderer renderer = this.player.GetComponent<TrailRenderer>();
        if (renderer != null)
        {
            renderer.enabled = !renderer.enabled;
        }
        this.beaten = !this.beaten;

        this.StartCoroutine(this.NextLevelCoroutine());
    }

    void Update()
    {
        if (beaten)
        {
            this.player.MoveLocally(new Vector3(0, 20 * Time.deltaTime));
        }
    }
    private IEnumerator NextLevelCoroutine()
    {
        yield return new WaitForSeconds(this.beatLevelWaitTime);
        SceneManager.LoadScene(this.nextSceneName);
        
    }
}
