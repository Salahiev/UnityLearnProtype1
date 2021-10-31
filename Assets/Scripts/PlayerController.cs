using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Camera1;
    [SerializeField] GameObject Camera2;// public Camera hoodCamera
    [SerializeField] KeyCode switchKey;
    
    private float speed = 20f;
    private float turnSpeed=45f;

    private float horizontalInput;
    private float forwardInput;



    void Update()
    {
        NextCamera();
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwardInput); 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

    private void NextCamera()
    {
        
        if (Input.GetKeyDown(switchKey))
        { 
            Camera1.SetActive(!Camera1.activeSelf); 
            Camera2.SetActive(!Camera2.activeSelf);// hoodCamera.enabled=!hoodCamera.enabled
        }
        
    }
}
