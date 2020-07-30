using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    [Range(0.01f, 1.0f)]
    public float smoothCamera = 0.5f;

    public Vector3 _cameraOffset;


    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 newPos = playerTransform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothCamera);
    }


}
