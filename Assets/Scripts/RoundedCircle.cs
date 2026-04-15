using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundedCircle : MonoBehaviour
{
    private float roundSpeed;

    public void StartRotate(float speed)
    {
        roundSpeed = speed;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * (roundSpeed * Time.deltaTime));
    }

    public void ReverseRotation()
    {
        roundSpeed *= -1;
    }
}
