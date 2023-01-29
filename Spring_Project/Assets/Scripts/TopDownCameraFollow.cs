using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCameraFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float followSpeed = 5.0f;
    public float tiltSpeed = 5.0f;
    public float followDistance = 10.0f;
    public float maxTiltAngle = 15.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = playerTransform.position - (playerTransform.forward * followDistance);
        targetPosition.y = playerTransform.position.y + followDistance;
        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        float tiltX = Input.acceleration.x * tiltSpeed;
        tiltX = Mathf.Clamp(tiltX, -maxTiltAngle, maxTiltAngle);

        transform.rotation = Quaternion.Euler(0, 0, -tiltX);

        transform.LookAt(playerTransform);
    }
}