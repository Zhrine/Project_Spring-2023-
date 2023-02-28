using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepAboveMesh : MonoBehaviour
{
    public float distanceAbove = 1.0f; // The distance to keep the object above the mesh
    public LayerMask groundLayer; // The layer(s) containing the mesh objects
    public float noGroundTimeout = 10.0f; // The time to wait before enabling gravity
    public bool enableGravityOnTimeout = true; // Whether to enable gravity on timeout

    private RaycastHit hitInfo; // Stores the result of the raycast
    private Vector3 targetPosition; // Stores the desired position of the object
    private float noGroundTime = 0.0f; // Keeps track of the time with no ground underneath

    void Update()
    {
        // Cast a ray downwards to find the closest point on the mesh
        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, Mathf.Infinity, groundLayer))
        {
            // Set the target position of the object to be the point on the mesh plus the desired distance above
            targetPosition = hitInfo.point + Vector3.up * distanceAbove;

            // Move the object to the target position
            transform.position = targetPosition;

            // Reset the no-ground timer
            noGroundTime = 0.0f;

            // Disable gravity on the rigidbody
            GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            // Increment the no-ground timer
            noGroundTime += Time.deltaTime;

            // If the timer has exceeded the timeout, enable gravity on the rigidbody
            if (noGroundTime >= noGroundTimeout && enableGravityOnTimeout)
            {
                GetComponent<Rigidbody>().useGravity = true;
            }
        }
    }
}