using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScale : MonoBehaviour
{
    public float thrust = 10f;
    public Rigidbody rb;
    private float scaleValue = 1f;
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
        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
    }

    public void setScale(float scale)
    {
        thrust /= scale;
        scaleValue = scale;
        rb.mass = scale*10;
        rb.AddForce(followCamera.transform.forward * thrust*10);

    }
}
