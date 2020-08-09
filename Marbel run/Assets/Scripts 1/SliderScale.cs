﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScale : MonoBehaviour
{
    public float thrust = 5f;
    public Rigidbody rb;
    private float scaleValue = 3f;
    private Vector3 scaleVector;

    public float newThrust;

    public Joystick joystick;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;

    void Start()
    {
        Sphere.transform.localScale = new Vector3(3f, 3f, 3f);
    }

    void Update()
    {
        scaleVector = new Vector3(scaleValue, scaleValue, scaleValue);

        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

        newThrust = thrust / scaleValue/2f;
        rb.mass = scaleValue * 12;

        rb.AddForce(followCamera.transform.forward * newThrust/4, ForceMode.VelocityChange);

        if (joystick.Vertical >= .3f && scaleValue <= 6f)
        {
            scaleValue += 0.05f;
        }

        if (joystick.Vertical <= -.3f && scaleValue >= 1f)
        {
            scaleValue -= 0.05f;
        }

        if(joystick.Horizontal >= .1)
        {
            rb.AddForce(followCamera.transform.right * 1.5f, ForceMode.Acceleration);
        }

        if (joystick.Horizontal <= -.1)
        {
            rb.AddForce(followCamera.transform.right * -1.5f, ForceMode.Acceleration);
        }
    }

    //public void setScale(float scale)
    //{
    //    scaleValue = scale;
    //    rb.mass = scale*10; 
    //}
}
