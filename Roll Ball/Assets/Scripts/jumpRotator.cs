using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpRotator : MonoBehaviour {

	void Update () {
        transform.Rotate(new Vector3(Time.deltaTime*200,0,0));
	}

}

