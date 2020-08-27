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

    public Joystick joystick;

    [SerializeField]
    private GameObject Sphere;
    public GameObject Marble;
    public Camera followCamera;
    //public Transform target;
    public float offset = 2f;

    public Renderer renderer;

    void Start()
    {
        Physics.gravity = new Vector3(0, -8F, 0);
        //Sphere.transform.localScale = new Vector3(3f, 3f, 3f);
        renderer.material = ChangeBall.PlayerMat;
    }

    void Update()
    {
        //followCamera.transform.position = new Vector3(target.position.x-offset, target.position.y, target.position.z);
       // followCamera.transform.eulerAngles = new Vector3(target.transform.rotation.x, target.transform.rotation.y, 0);

        scaleVector = new Vector3(scaleValue, scaleValue, scaleValue);
        Sphere.transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
        if (scaleValue >= 3)
        {
            thrust = 1;
        }
        else
        {
            thrust = 0.6f;
        }
        newThrust = thrust / scaleValue;
        rb.mass = scaleValue * 20;
        Physics.gravity = new Vector3(0, -scaleValue * 8, 0);
        rb.AddForce(followCamera.transform.forward * newThrust/1.8f, ForceMode.VelocityChange);

        if (joystick.Vertical >= .25f && scaleValue <= 6f)
        {
            scaleValue += 0.04f;
        }

        if (joystick.Vertical <= -.25f && scaleValue >= 2f)
        {
            scaleValue -= 0.03f;
        }

        if(joystick.Horizontal >= .8)
        {
            rb.AddForce(followCamera.transform.right * 6f, ForceMode.Acceleration);
        }

        if (joystick.Horizontal <= -.8)
        {
            rb.AddForce(followCamera.transform.right * -6f, ForceMode.Acceleration);
        }
    }

    //public void setScale(float scale)
    //{
    //    scaleValue = scale;
    //    rb.mass = scale*10; 
    //}
}
