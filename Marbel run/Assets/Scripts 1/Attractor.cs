using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    public float attractorSpeed;
    public GameObject attractPoint;

    private void OnTriggerStay(Collider other)
    {
        if ((other.gameObject.tag == "Player") || (other.gameObject.tag == "AI"))
        {
            other.transform.position = Vector3.MoveTowards(other.transform.position, attractPoint.transform.position, attractorSpeed * Time.deltaTime);
        }
    }
}
