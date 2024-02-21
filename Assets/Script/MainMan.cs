using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;

public class MainMan : MonoBehaviour
{
    public SO.LastValue[,] CurrentValue;
    public static MainMan instance;
    [SerializeField] TMP_Text Score1;
    [SerializeField] TMP_Text Score2;
    [SerializeField] Score ScoreStore;
    [SerializeField] SO last;
    // Start is called before the first frame update
    public bool allow = true;
    public int ScoreP1;
    public int ScoreP2;
    [SerializeField]
    GameObject WinTextX;
    [SerializeField] GameObject WinTextO;
    [SerializeField]
    GameObject TieText;
    [SerializeField] SO firstP;

    private void Start()
    {
        ScoreP1=ScoreStore.ScoreP1;
        ScoreP2=ScoreStore.ScoreP2;
        allow = true;
    }
    private void Awake()
    {
        instance = this;
    }
    
    private void Update()
    {
        SetScore();
    }
    public void WinCheck()
    {
        if (((CurrentValue[0, 0] == CurrentValue[0, 1]) && (CurrentValue[0, 0] == CurrentValue[0, 2]) && (CurrentValue[0, 2] != SO.LastValue.na)) ||
            ((CurrentValue[1, 0] == CurrentValue[1, 1]) && (CurrentValue[1, 0] == CurrentValue[1, 2]) && (CurrentValue[1, 2] != SO.LastValue.na)) ||
            ((CurrentValue[2, 0] == CurrentValue[2, 1]) && (CurrentValue[2, 0] == CurrentValue[2, 2]) && (CurrentValue[2, 2] != SO.LastValue.na)) ||
            ((CurrentValue[0, 0] == CurrentValue[1, 0]) && (CurrentValue[0, 0] == CurrentValue[2, 0]) && (CurrentValue[2, 0] != SO.LastValue.na)) ||
            ((CurrentValue[0, 1] == CurrentValue[1, 1]) && (CurrentValue[0, 1] == CurrentValue[2, 1]) && (CurrentValue[2, 1] != SO.LastValue.na)) ||
            ((CurrentValue[0, 2] == CurrentValue[1, 2]) && (CurrentValue[1, 2] == CurrentValue[2, 2]) && (CurrentValue[2, 2] != SO.LastValue.na)) ||
            ((CurrentValue[0, 0] == CurrentValue[1, 1]) && (CurrentValue[1, 1] == CurrentValue[2, 2]) && (CurrentValue[2, 2] != SO.LastValue.na)) ||
            ((CurrentValue[2, 0] == CurrentValue[1, 1]) && (CurrentValue[1, 1] == CurrentValue[0, 2]) && (CurrentValue[0, 2] != SO.LastValue.na)))
        {
            allow = false;
            
            
            StartCoroutine("Reset");
            if (last.lastValue==SO.LastValue.x)
            {
                WinTextX.SetActive(true);
                if (firstP.lastValue == last.lastValue)
                {
                    MainMan.instance.ScoreP1 += 1;
                }
                else
                {
                    MainMan.instance.ScoreP2 += 1;
                }
                
            }
            else
            {
                WinTextO.SetActive(true);
                if (firstP.lastValue == last.lastValue)
                {
                    MainMan.instance.ScoreP1 += 1;
                }
                else
                {
                    MainMan.instance.ScoreP2 += 1;
                }
            }
        }
        else
        {
            TieCheck();
        }
    }
    public void TieCheck()
    {
        if ((CurrentValue[0,0]!= SO.LastValue.na) && 
            (CurrentValue[0,1]!= SO.LastValue.na) && 
            (CurrentValue[0,2]!= SO.LastValue.na) && 
            (CurrentValue[1,0]!= SO.LastValue.na) && 
            (CurrentValue[1,1]!= SO.LastValue.na) && 
            (CurrentValue[1,2]!= SO.LastValue.na) && 
            (CurrentValue[2,0]!= SO.LastValue.na) && 
            (CurrentValue[2,1]!= SO.LastValue.na) && 
            (CurrentValue[2,2]!= SO.LastValue.na))
        {
            TieText.SetActive(true);
            StartCoroutine("Reset");
        }  

            
    }
    void SetScore()
    {
        Score1.SetText("Player 1: " + MainMan.instance.ScoreP1.ToString());
        Score2.SetText("Player 2: " + MainMan.instance.ScoreP2.ToString());
    }
    IEnumerator Reset()
    {
        yield return new WaitForSeconds(2);
        WinTextX.SetActive(false);
        WinTextO.SetActive(false);
        TieText.SetActive(false);
        ScoreStore.ScoreP1 = ScoreP1;
        ScoreStore.ScoreP2 = ScoreP2;
        SceneManager.LoadScene(2);
    }
}
