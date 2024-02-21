using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadPage : MonoBehaviour
{
    
    
    void Start()
    {
        StartCoroutine(Enable());       
    }
    
    IEnumerator Enable()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }
    
}
