using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animHoleController : MonoBehaviour
{
    public Animator animDelik;
    public int puan;

    private void Start()
    {
        puan = 0;
        animDelik = GetComponent<Animator>();
    }

    private void Update()
    {
        if (puan >= 5)
            animDelik.Play("DelikAc");
    }

    public void puanAl()
    {
        puan = puan + 1;
    }

}
