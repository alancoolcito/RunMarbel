using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderScale : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;
    private float scaleValue = 4f;
    private Vector3 scaleVector;

    public float newThrust;

    public Joystick joystick;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;
    public float offset = 2f;

    public Renderer renderer;

    void Start()
    {
        Physics.gravity = new Vector3(0, -8F, 0);
        renderer.material = ChangeBall.PlayerMat;
    }

    void Update()
    {
        

        scaleVector = new Vector3(scaleValue, scaleValue, scaleValue);
        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        //if (scaleValue >= 3)
        //{
        //    thrust = 0.6f;
        //}
        //else if(scaleValue < 3 )
        //{
        //    thrust = 1f;
        //}
        newThrust = thrust / scaleValue;
        rb.mass = scaleValue * 20;
        Physics.gravity = new Vector3(0, -scaleValue * 8, 0);
        rb.AddForce(followCamera.transform.forward * newThrust/1.8f, ForceMode.VelocityChange);

        if (joystick.Vertical >= .25f && scaleValue <= 6f)
        {
            scaleValue += 0.1f;
        }

        if (joystick.Vertical <= -.25f && scaleValue >= 2f)
        {
            scaleValue -= 0.1f;
        }

        if(joystick.Horizontal >= .8)
        {
            rb.AddForce(followCamera.transform.right * 8f, ForceMode.Acceleration);
        }

        if (joystick.Horizontal <= -.8)
        {
            rb.AddForce(followCamera.transform.right * -8f, ForceMode.Acceleration);
        }
    }
}
