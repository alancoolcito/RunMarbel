﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcontroller : MonoBehaviour
{
    public float thrust = 5f;
    public Rigidbody rb;
    private float scaleValue = 4f;
    private Vector3 scaleVector;

    public float newThrust;

    public Joystick joystick;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;
    //public Transform target;
    public float offset = 2f;

    void Start()
    {
        Physics.gravity = new Vector3(0, -12F, 0);
        //Sphere.transform.localScale = new Vector3(3f, 3f, 3f);
    }

    void Update()
    {
        //followCamera.transform.position = new Vector3(target.position.x-offset, target.position.y, target.position.z);
        // followCamera.transform.eulerAngles = new Vector3(target.transform.rotation.x, target.transform.rotation.y, 0);

        scaleVector = new Vector3(scaleValue, scaleValue, scaleValue);
        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        newThrust = thrust / scaleValue;
        rb.mass = scaleValue * 15;
        Physics.gravity = new Vector3(0, -scaleValue * 8, 0);
        rb.AddForce(followCamera.transform.forward * newThrust / 1.5f, ForceMode.VelocityChange);

        if (joystick.Vertical >= .1f && scaleValue <= 6f)
        {
            scaleValue += 0.08f;
        }

        if (joystick.Vertical <= -.1f && scaleValue >= 1f)
        {
            scaleValue -= 0.08f;
        }
    }
}
