using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPage : MonoBehaviour
{

    [SerializeField] Score Score;
    public void ResetScore()
    {
        Score.ScoreP1 = 0;
        Score.ScoreP2 = 0;
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void GmStart()
    {
        StartCoroutine(LoadNew());
    }
    IEnumerator LoadNew()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}


