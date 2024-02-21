using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//using UnityEngine.UIElements;
using UnityEngine.UI;

public class TTT : MonoBehaviour
{
 
    
    [SerializeField] SO ValueCheck;
    [SerializeField] GameObject x;
    [SerializeField] GameObject o;
    

    public void Click()
    {
        if (MainMan.instance.allow == true)
        {
            Control.instance.user = !Control.instance.user;
            gameObject.GetComponent<Button>().enabled = false;
            if (ValueCheck.lastValue == SO.LastValue.x)
            {
                o.SetActive(true);
                ValueCheck.lastValue = SO.LastValue.o;
                AddValue(ValueCheck.lastValue);
                MainMan.instance.WinCheck();
                return;
            }
            if (ValueCheck.lastValue == SO.LastValue.o)
            {
                x.SetActive(true);
                ValueCheck.lastValue = SO.LastValue.x;
                AddValue(ValueCheck.lastValue);
                MainMan.instance.WinCheck();
                return;
            }
            if (ValueCheck.lastValue == SO.LastValue.na)
            {
                o.SetActive(true);
                ValueCheck.lastValue = SO.LastValue.o;
                AddValue(ValueCheck.lastValue);
                MainMan.instance.WinCheck();
                return;
            }
        }

    }
    private void AddValue(SO.LastValue v)
    {
        if (gameObject.name == "1")
        {
            MainMan.instance.CurrentValue[0,0]=v;
        }if (gameObject.name == "2")
        {
            MainMan.instance.CurrentValue[0,1]=v;
        }if (gameObject.name == "3")
        {
            MainMan.instance.CurrentValue[0,2]=v;
        }if (gameObject.name == "4")
        {
            MainMan.instance.CurrentValue[1,0]=v;
        }if (gameObject.name == "5")
        {
            MainMan.instance.CurrentValue[1,1]=v;
        }if (gameObject.name == "6")
        {
            MainMan.instance.CurrentValue[1,2]=v;
        }if (gameObject.name == "7")
        {
            MainMan.instance.CurrentValue[2,0]=v;
        }if (gameObject.name == "8")
        {
            MainMan.instance.CurrentValue[2,1]=v;
        }if (gameObject.name == "9")
        {
           MainMan.instance.CurrentValue[2,2]=v;
        }

    }
    
}
