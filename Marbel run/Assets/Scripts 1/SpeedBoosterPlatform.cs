using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpeedBoosterPlatform : MonoBehaviour
{
    [SerializeField]
    private float boost = 1000f;
    [SerializeField]
    private Camera mainCam;

    public void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") || (other.gameObject.tag == "AI"))
        {
            float mass = other.attachedRigidbody.mass;
            var tempRigid = other.attachedRigidbody;
            if (tempRigid != null)
            {
               // rb.AddForce(boost, 0, 0, ForceMode.Impulse);
               // rbAI.AddForce(boost, 0, 0, ForceMode.Impulse);
                 other.attachedRigidbody.AddForce(mainCam.transform.forward * boost, ForceMode.Acceleration);
            }
        }
    }    
}
