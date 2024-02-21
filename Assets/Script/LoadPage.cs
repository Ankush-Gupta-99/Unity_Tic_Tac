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
        yield return new WaitForSeconds(4.3f);
        SceneManager.LoadScene(1);
    }
    
}
