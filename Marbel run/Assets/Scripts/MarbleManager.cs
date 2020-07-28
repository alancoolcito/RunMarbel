using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarbleManager : MonoBehaviour
{
    public Rigidbody rb;
    private float startForce = 10f;

    private void Start()
    {
        rb.AddRelativeForce(Vector3.forward * startForce);

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.mass = 5000f;
            rb.AddRelativeForce(Vector3.forward * 1f);
            this.gameObject.transform.localScale = new Vector3(4f, 4f, 4f);

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.mass = 1f;
            rb.AddRelativeForce(Vector3.forward * startForce);
            this.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);

        }
    }
}
