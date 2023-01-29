using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        Vector3 tilt = Input.acceleration;
        Vector3 moveDirection = new Vector3(tilt.x, 0, tilt.y);
        transform.position += moveDirection * speed * Time.deltaTime;
    }
}