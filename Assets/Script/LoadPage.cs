using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPage : MonoBehaviour
{
    [SerializeField] GameObject ui;
    [SerializeField] Score Score;
    [SerializeField] SO lastinp;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Enable());
        lastinp.lastValue = SO.LastValue.na;
        
    }
    public void ResetScore()
    {
        Score.ScoreP1 = 0;
        Score.ScoreP2 = 0;
    }

    // Update is called once per frame
    IEnumerator Enable()
    {
        yield return new WaitForSeconds(2);
        ui.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void start()
    {
        StartCoroutine(LoadNew());
    }
    IEnumerator LoadNew()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
}
