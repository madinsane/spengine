﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OVR;

public class GamepadMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Camera c;
    private Vector3 movementVector;
    private float movementSpeed = 15.0f;

    void Start()
    {
        //player = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();
        movementVector = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        // movementVector = player.transform.InverseTransformVector(movementVector);
        movementVector.x = movementVector.x * movementSpeed;
        movementVector.z = movementVector.y * movementSpeed;
        movementVector.y = 0;



        //player.transform.position += (player.transform.forward * Time.deltaTime);
        player.transform.rotation = c.transform.localRotation;
        player.transform.Translate(movementVector * Time.deltaTime);


        /*
        if (movementVector.x > 0) {
            player.transform.localPosition += player.transform.forward * movementSpeed * Time.deltaTime;
        }
        if (movementVector.x < 0)
        {
            player.transform.localPosition += player.transform.forward * -movementSpeed * Time.deltaTime;
        }
        if (movementVector.y > 0) {
            player.transform.localPosition += player.transform.right * movementSpeed * Time.deltaTime;
        }
        if (movementVector.y < 0)
        {
            player.transform.localPosition += player.transform.right * -movementSpeed * Time.deltaTime;
        }

       
        */


        //player.transform.Translate(Vector3.right * movementVector.x * Time.deltaTime);

        /*
        if (Input.GetKey(KeyCode.UpArrow)) {
            player.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
            Debug.Log("Going forward");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.Translate(Vector3.forward * -2 * Time.deltaTime);
            Debug.Log("Going backward");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Translate(Vector3.right * 2 * Time.deltaTime);
            Debug.Log("Going right");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.Translate(Vector3.right * -2 * Time.deltaTime);
           Debug.Log("Going left");
        }
        */


    }
}
