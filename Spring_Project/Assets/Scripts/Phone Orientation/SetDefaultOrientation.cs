using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefaultOrientation : MonoBehaviour
{
    public void SetDefault()
    {
        // Store the current device orientation as the default orientation
        PlayerPrefs.SetFloat("DefaultTiltX", Input.acceleration.x);
        PlayerPrefs.SetFloat("DefaultTiltY", Input.acceleration.y);
        PlayerPrefs.SetFloat("DefaultTiltZ", Input.acceleration.z);
    }
}