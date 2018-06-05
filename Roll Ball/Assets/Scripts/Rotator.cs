using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(Time.deltaTime*40,0,0));
	}

}

