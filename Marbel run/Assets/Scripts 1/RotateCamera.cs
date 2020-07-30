using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    [SerializeField] Animator mainCam;
    [SerializeField] Transform player;

    private Vector3 offset;
    public float turnSpeed = 4.0f;

    void Start()
    {
        //offset = new Vector3(player.position.x, player.position.y + 8.0f, player.position.z + 7.0f);
    }

    public void OnTriggerEnter (Collider other)
    {
            //mainCam.transform.RotateAround(player.transform.position, Vector3.up, 90 * Time.deltaTime);
            //offset = Quaternion.AngleAxis (turnSpeed, Vector3.up) * offset;
            //mainCam.transform.position = player.position + offset;
            mainCam.SetBool("TurnRight", true);
            Debug.Log("GOT");
    }
}
