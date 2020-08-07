using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIcontroller : MonoBehaviour
{
    public float thrust = 3f;
    public float newThrust;
    public Rigidbody rb;
    private Vector3 scaleVector;
    private float scaleValue = 3f;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;


    void Start()
    {
        
    }

    void Update()
    {
        newThrust = thrust / scaleValue;
        rb.AddForce(followCamera.transform.forward * newThrust / 10, ForceMode.VelocityChange);

    }
}
