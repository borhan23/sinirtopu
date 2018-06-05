using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainmenuButtons : MonoBehaviour {

    public GameObject btnStart, btnLevels, btnQuit;


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameToStart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Levels()
    {
        SceneManager.LoadScene(4);
    }

    public void Quit()
    {
       Application.Quit();
    }
}
