using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Control : MonoBehaviour
{
    [HideInInspector]
    public static Control instance;    
    [SerializeField] GameObject playerXtext;
    [SerializeField] GameObject playerOtext;
    [HideInInspector]
    //player playerx = t 
    public bool user;
    [SerializeField] SO last;

    private void Awake()
    {
        if (last.lastValue == SO.LastValue.o)
        {
            user = true;

        }
        else
        {
            user = false;
        }

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
            playerXtext.SetActive(true);
            playerOtext.SetActive(false);
        }
        else
        {
            playerOtext.SetActive(true);
            playerXtext.SetActive(false);
        }
    }
    
}
