using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetuteletSwing : MonoBehaviour
{
    [SerializeField]
    Quaternion targetAngle_left = Quaternion.Euler(-120, 0, 0);
    Quaternion targetAngle_right = Quaternion.Euler(-60, 0, 0);
    public Quaternion currAngle;

    void Start()
    {
        currAngle = targetAngle_right;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeCurrentAngle();
        }

        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, currAngle, 0.2f);
    }

    void ChangeCurrentAngle()
    {
        if (currAngle.eulerAngles.x == targetAngle_right.eulerAngles.x)
        {
            currAngle = targetAngle_left;
        }
        else
        {
            currAngle = targetAngle_right;
        }
    }
}
