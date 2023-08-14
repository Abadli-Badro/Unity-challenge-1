using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float rotationSpeed = 5f;

    private void Update()
    {
        // Calculate the desired rotation based on player's x position
        float targetRotationY = player.position.x / 5f;

        // Clamp the rotation between -10 and 10 degrees
        targetRotationY = Mathf.Clamp(targetRotationY, -10f, 10f);

        // Smoothly interpolate the camera's rotation towards the target rotation
        Quaternion targetRotation = Quaternion.Euler(45f, -targetRotationY, 0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
    }
}


