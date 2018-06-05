using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelsButton : MonoBehaviour {

    public GameObject btnLevel1, btnLevel2, btnLevel3, btnGeri;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
