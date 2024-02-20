using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Control : MonoBehaviour
{
    [HideInInspector]
    public static Control instance;    
    [SerializeField] GameObject player1text;
    [SerializeField] GameObject player2text;
    [HideInInspector]//player player1 = t 
    public bool user;

    private void Awake()
    {
        
        user = true;
        
        instance = this;

        
    }
    private void Start()
    {
        SO.LastValue na = SO.LastValue.na;
        MainMan.instance.CurrentValue = new SO.LastValue[3, 3] { { na, na, na }, { na, na, na }, { na, na, na } };
    }
    void Update()
    {
        playertext();
        
        

    }
    
    void playertext()
    {
        if (user==true)
        {
            player1text.SetActive(true);
            player2text.SetActive(false);
        }
        else
        {
            player2text.SetActive(true);
            player1text.SetActive(false);
        }
    }
    
}
