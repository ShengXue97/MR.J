using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Cutscene : MonoBehaviour
{
    public GameObject videoPlayer;
    private IEnumerator coroutine;
    public void Start()
    {
        ///videoPlayer.SetActive(false);
        coroutine = ChottoMatte(28);
        StartCoroutine(coroutine);
        ///SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private IEnumerator ChottoMatte(int i)
    {
        yield return new WaitForSeconds(i);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            videoPlayer.SetActive(true);
            Destroy(videoPlayer, 28);
        }
    }
}
