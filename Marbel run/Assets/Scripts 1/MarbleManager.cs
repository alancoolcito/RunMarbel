using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MarbleManager : MonoBehaviour
{
    public Rigidbody rb;
    private float scaleValue = 1f;
    [SerializeField]
    void Start()
    {

    }
   
    public void setScale(float scale)
    {
        scaleValue = scale;
        rb.mass = scale;
    }
}
