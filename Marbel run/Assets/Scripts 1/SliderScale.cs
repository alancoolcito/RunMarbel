using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScale : MonoBehaviour
{
    public float thrust = 5f;
    public Rigidbody rb;
    private float scaleValue = 4f;
    private Vector3 scaleVector;

    public float newThrust;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;

    void Start()
    {
        Sphere.transform.localScale = new Vector3(4f, 4f, 4f);
    }

    void Update()
    {
        scaleVector = new Vector3(scaleValue, scaleValue, scaleValue);

        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);

        newThrust = thrust / scaleValue;

        //rb.AddForce(followCamera.transform.forward * newThrust * 300);

        rb.AddForce(followCamera.transform.forward * newThrust/2, ForceMode.VelocityChange);

    }

    public void setScale(float scale)
    {
        //thrust /= scale;
        scaleValue = scale;
        rb.mass = scale*10; 
    }
}
