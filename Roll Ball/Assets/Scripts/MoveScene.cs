using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveScene : MonoBehaviour {

    public Text txtEndLevel;
    public GameObject btnNext,btnMenu,btnDurdur;

    private void Start()
    {
        btnNext.SetActive(false);
        btnMenu.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            txtEndLevel.text = "Tebrikler, bölümü tamamladınız.";
            btnNext.SetActive(true);
            btnMenu.SetActive(true);
            btnDurdur.SetActive(false);
        }
    }
}
