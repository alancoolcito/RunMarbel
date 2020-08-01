using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject playerTransform;
    public GameObject Marble;
    [Range(0.01f, 1.0f)]
    public float smoothCamera = 0.5f;

    public Vector3 _cameraOffset;


    // Start is called before the first frame update
    void Start()
    {
        _cameraOffset = transform.position - Marble.transform.position;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 newPos = Marble.transform.position + _cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, smoothCamera);
    }
    private void Update()
    {

       // transform.rotation = new Quaternion(Marble.transform.rotation.x, playerTransform.transform.rotation.y, playerTransform.transform.rotation.z, playerTransform.transform.rotation.w);

        

    }

}
