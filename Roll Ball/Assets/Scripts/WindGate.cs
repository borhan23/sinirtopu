using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindGate : MonoBehaviour {

    public GameObject Door;
    public bool doorIsOpening;
    public int puan;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.left * Time.deltaTime * 5);
            //if the bool is true open the door

        }
        
        if (puan == 3)
        {
            doorIsOpening = true;
            if (Door.transform.position.x < -13)
            {
                doorIsOpening = false;
                //if the y of the door is < than -13 we want to stop the door
            }
        }
           
    }

    public void puanAl()
    {
        puan = puan + 1;
    }
}
