using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonGate : MonoBehaviour {

    public Animator animbtn;
    public GameObject DoorSol;
    public GameObject DoorSag;
    public bool doorIsOpening;

    // Use this for initialization
    void Start () {
        animbtn = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        if (doorIsOpening == true)
        {
            DoorSol.transform.Translate(Vector3.left * Time.deltaTime * 5);
            DoorSag.transform.Translate(Vector3.right * Time.deltaTime * 5);
            //if the bool is true open the door

        }
        if (DoorSol.transform.position.x < 7)
        {
            doorIsOpening = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            animbtn.Play("dugmekapi");
            doorIsOpening = true;
        }

    }
}
