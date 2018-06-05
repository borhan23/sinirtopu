using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour {

    public GameObject btnAgain, btnDevam, btnNext, btnMenu, btndurdurmenu;


    // Use this for initialization
    void Start () {
        btnDevam.SetActive(false);
        btndurdurmenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Durdur()
    {
        Time.timeScale = 0;
        btnDevam.SetActive(true);
        btndurdurmenu.SetActive(true);
    }

    public void Devam()
    {
        Time.timeScale = 1;
        btnDevam.SetActive(false);
        btndurdurmenu.SetActive(false);

    }

    public void YenidenYukle()
    {
        btnAgain.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextToLevel()
    {
        btnNext.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OpenMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
