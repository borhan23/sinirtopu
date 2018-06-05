using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallController : MonoBehaviour {

    public float moveSpeed = 5.0f;
    public float drag = 0.5f;
    public float terminalRotationSpeed = 25.0f;
    public VirtualJoystick joystick;
    private Rigidbody rigid;
    public int count;
    public Text countText,endText;
    public animHoleController animctrl;
    public WindGate wgate;
    public GameObject tryButton,btnDurdur;
    public bool inWindZone = false;
    public GameObject windZone;

    private Rigidbody controller;
    private Transform camTransform;

    private void Start()
    {
        controller = GetComponent<Rigidbody>();
        controller.maxAngularVelocity = terminalRotationSpeed;
        controller.drag = drag;
        tryButton.SetActive(false);
        btnDurdur.SetActive(true);
        camTransform = Camera.main.transform;
        rigid = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        
    }

    private void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxis("Horizontal");
        dir.z = Input.GetAxis("Vertical");

        if (dir.magnitude > 1)
            dir.Normalize();

        if(joystick.InputDirection != Vector3.zero)
        {
            dir = joystick.InputDirection;
        }

        // Rotate our direction vector with camera
        Vector3 rotatedDir = camTransform.TransformDirection(dir);
        rotatedDir = new Vector3(rotatedDir.x, 0, rotatedDir.z);
        rotatedDir = rotatedDir.normalized * dir.magnitude;

        controller.AddForce(rotatedDir * moveSpeed);
    }

    private void FixedUpdate()
    {
       if(inWindZone) {
            rigid.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);
       }
    }

    void OnTriggerExit(Collider coll) {
        if(coll.gameObject.tag == "windArea") {
            inWindZone = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            animctrl.puanAl();
            if(SceneManager.GetActiveScene().buildIndex == 3)
            {
                wgate.puanAl();
            }
            
        }

        if (other.gameObject.tag == "windArea")
        {
            windZone = other.gameObject;
            inWindZone = true;
        }
        
        if(other.gameObject.CompareTag("water"))
        {
            endText.text = "Kaybettiniz.";
            Time.timeScale = 0;
            tryButton.SetActive(true);
            btnDurdur.SetActive(false);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Dusman"))
        {
            endText.text = "Kaybettiniz.";
            Time.timeScale = 0;
            tryButton.SetActive(true);
            btnDurdur.SetActive(false);
        }

    }
    void SetCountText()
    {
        countText.text = "Puan:" + count.ToString();
    }

}
