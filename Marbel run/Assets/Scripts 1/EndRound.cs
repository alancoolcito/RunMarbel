using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class EndRound : MonoBehaviour
{
    public CinemachineFreeLook Cam;
    public AudioSource Audio;
    public Timer timer;
    public void OnTriggerEnter(Collider other)
    {
        if ((other.gameObject.tag == "Player") || (other.gameObject.tag == "AI"))
        {
            other.attachedRigidbody.drag = 1000;
            Cam.m_Lens.FieldOfView = 125;
            Audio.Play();
            timer.stoper = 0;
        }
    }
}
