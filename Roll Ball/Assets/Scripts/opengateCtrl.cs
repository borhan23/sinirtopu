using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opengateCtrl : MonoBehaviour {

    public GameObject Door;
    public bool doorIsOpening;

    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.left * Time.deltaTime * 5);
            //if the bool is true open the door

        }
        if (Door.transform.position.x < -12)
        {
            doorIsOpening = false;
            //if the y of the door is < than -12 we want to stop the door
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Arac"))
        {
            doorIsOpening = true;
        }
    }
}
