using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f; // movement speed
    public float tiltFactor = 1.0f; // factor to adjust the tilt sensitivity
    private Rigidbody _rigidbody3d; // reference to the Rigidbody2D component

    void Start()
    {
        _rigidbody3d = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get the phone's tilt
        float phoneTilt = Input.acceleration.x * tiltFactor;

        // Calculate the movement based on the phone's tilt
        Vector2 movement = new Vector2(phoneTilt, 0) * speed;

        // Modify the speed based on the Z axis of the phone's acceleration
        float zSpeedModifier = Input.acceleration.z;
        if (zSpeedModifier > 0)
        {
            movement *= 1 + zSpeedModifier;
        }
        else
        {
            movement *= 1 / (1 - zSpeedModifier);
        }

        // Apply the movement to the Rigidbody2D component
        _rigidbody3d.velocity = movement;
    }
}