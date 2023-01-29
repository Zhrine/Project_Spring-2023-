using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltController : MonoBehaviour
{
    public float moveSpeedY = 15.0f;
    public float moveSpeedX = 15.0f;

    // Update is called once per frame
    void Update()
    {
        float tiltX = Input.acceleration.x;
        float tiltZ = Input.acceleration.y;

        transform.position += new Vector3(tiltX * moveSpeedX * Time.deltaTime, 0, tiltZ * moveSpeedY * Time.deltaTime);
    }
}
