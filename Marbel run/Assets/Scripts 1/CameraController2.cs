using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController2 : MonoBehaviour
{
    public Transform target;
    public float offset = 8f;
void Update()
    {

        transform.position = new Vector3(target.position.x, target.position.y, target.position.z - offset);
        Camera.main.transform.eulerAngles = new Vector3(target.transform.rotation.x, target.transform.rotation.y, 0);
    }
}
