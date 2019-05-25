using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Usually the player but you can focus on anything that moves.
    [SerializeField] private Transform target = null;
    // How quick to move towards the target. 
    [SerializeField] private float smoothTime = .3f;
    [SerializeField] private Vector3 offset = new Vector3(0,0,-10);
    [SerializeField] private Vector3 velocity = Vector3.zero;

    // How far to the left the camera should go.
    // You can find out by just moving the camera in edit mode then noting the x position on the Transform.
    [SerializeField] private float minLocationX = 0;
    // How far to the right the camera should go.
    // Find by doing the same as above but go right this time.
    [SerializeField] private float maxLocationX = 0;
    // How far down the camera should go.
    // Same as above but note the y position rather than x. 
    [SerializeField] private float minLocationY = 0;
    // How far up the camera should go.
    // Same as above but go down this time.
    [SerializeField] private float maxLocationY = 0;

    void FixedUpdate()
    {
        // Camera follow on the X axis, camera follow on the Y axis, no z movement.
        Vector3 targetPosition = new Vector3(Mathf.Clamp(target.position.x, minLocationX, maxLocationX), Mathf.Clamp(target.position.y, minLocationY, maxLocationY), 0) + offset;
        // Smoothly move the camera from current position to the targetPosition.
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}