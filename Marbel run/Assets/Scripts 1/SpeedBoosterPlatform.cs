using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoosterPlatform : MonoBehaviour
{
    public float boost = 1000f;
    public Rigidbody rb;
    public Rigidbody rbAI;



        public void OnTriggerEnter(Collider other)
        {
            if ((other.gameObject.tag == "Player") || (other.gameObject.tag == "AI"))
            {
            rb.AddForce(boost,0,0,ForceMode.Impulse);
            rbAI.AddForce(boost, 0, 0, ForceMode.Impulse);
           // other.attachedRigidbody.AddForce(boost, 0, 0, ForceMode.Impulse);
        }
    }    
}
