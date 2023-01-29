using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltObject : MonoBehaviour
{
    void Update()
    {
        // Get the default orientation
        float defaultTiltX = PlayerPrefs.GetFloat("DefaultTiltX");
        float defaultTiltY = PlayerPrefs.GetFloat("DefaultTiltY");
        float defaultTiltZ = PlayerPrefs.GetFloat("DefaultTiltZ");

        // Calculate the difference between the current orientation and the default orientation
        float tiltX = Input.acceleration.x - defaultTiltX;
        float tiltY = Input.acceleration.y - defaultTiltY;
        float tiltZ = Input.acceleration.z - defaultTiltZ;

        // Rotate the object based on the difference
        transform.rotation = Quaternion.Euler(tiltX, tiltY, tiltZ);
    }
}