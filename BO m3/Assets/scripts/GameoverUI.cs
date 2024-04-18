using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameoverUI : MonoBehaviour
{
    private HP hpScript;
    // Start is called before the first frame update
    public void Start(){
        hpScript = FindObjectOfType<HP>();
        
    }
    public void Update(){
        if (hpScript.getHp() == 0)
        {
            
            this.gameObject.SetActive(true);
        }
    }
    public void Replaygame()
    {
        SceneManager.LoadScene(0);
    }

    public void Quitgame()
    {
        Application.Quit();
    }

}
