using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarbleManager : MonoBehaviour
{
    public Rigidbody rb;
    public Slider GameSlider;

    private void Start()
    {

    }
    private void Update()
    {
        if (GameSlider.value == 1)
        {
            rb.mass = 1f;
            //rb.AddRelativeForce(Vector3.forward * 10f);
            this.gameObject.transform.localScale = new Vector3(1.5f, 1.5f, 1.5f);
            Physics.gravity = new Vector3(0, -1500.0F, 0);
        }

        if (GameSlider.value == 2)
        {
            rb.mass = 250f;
            //rb.AddRelativeForce(Vector3.forward * 8f);
            this.gameObject.transform.localScale = new Vector3(2f, 2f, 2f);
            Physics.gravity = new Vector3(0, -1250.0F, 0);
        }

        if (GameSlider.value == 3)
        {
            rb.mass = 500f;
            //rb.AddRelativeForce(Vector3.forward * 6f);
            this.gameObject.transform.localScale = new Vector3(3f, 3f, 3f);
            Physics.gravity = new Vector3(0, -1000.0F, 0);
        }

        if (GameSlider.value == 4)
        {
            rb.mass = 750f;
            //rb.AddRelativeForce(Vector3.forward * 4f);
            this.gameObject.transform.localScale = new Vector3(4f, 4f, 4f);
            Physics.gravity = new Vector3(0, -750.0F, 0);
        }

        if (GameSlider.value == 5)
        {
            rb.mass = 1000f;
            //rb.AddRelativeForce(Vector3.forward * 3f);
            this.gameObject.transform.localScale = new Vector3(5f, 5f, 5f);
            Physics.gravity = new Vector3(0, -500.0F, 0);
        }

        if (GameSlider.value == 6)
        {
            rb.mass = 1500f;
            //rb.AddRelativeForce(Vector3.forward * 2f);
            this.gameObject.transform.localScale = new Vector3(5.5f, 5.5f, 5.5f);
            Physics.gravity = new Vector3(0, -250.0F, 0);
        }

        if (GameSlider.value == 7)
        {
            rb.mass = 2000f;
            //rb.AddRelativeForce(Vector3.forward * 1f);
            this.gameObject.transform.localScale = new Vector3(6f, 6f, 6f);
            Physics.gravity = new Vector3(0, -0.25F, 0);
        }
    }

    //public void ChangeMass(float newMass)
    //{
    //    rb.mass = newMass;
    //}
    //public void ChangeSpeed(float newSpeed)
    //{
    //    powerForce = newSpeed * -1;
    //}

    //public void Change(float newMass, float newSpeed, Vector3 newSize)
    //{
    //    rb.mass = newMass;
    //    rb.AddRelativeForce(Vector3.forward * newSpeed);
    //}
}
