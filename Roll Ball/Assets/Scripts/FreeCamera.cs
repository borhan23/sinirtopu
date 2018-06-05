using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCamera : MonoBehaviour {

    public VirtualJoystick cameraJoystick;
    public Transform lookAt;

    private float distance = 4.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensivityX = 2.0f;
    private float sensivityY = 1.0f;

    private void Update()
    {
        currentX += cameraJoystick.InputDirection.x * sensivityX;
        currentY += cameraJoystick.InputDirection.z * sensivityY;
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = lookAt.position + rotation * dir;
        transform.LookAt(lookAt);
    }

}
