using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstSelection : MonoBehaviour
{

    [SerializeField] SO last;
    [SerializeField] SO First;
    public void Xselect()
    {
        last.lastValue = SO.LastValue.o;
        First.lastValue = SO.LastValue.x ;
        SceneManager.LoadScene(2);
    }
    public void Oselect()
    {
        last.lastValue = SO.LastValue.x;
        First.lastValue = SO.LastValue.o;
        SceneManager.LoadScene(2);
    }
    public void GoBack()
    {
        SceneManager.LoadScene(1);
    }
}
