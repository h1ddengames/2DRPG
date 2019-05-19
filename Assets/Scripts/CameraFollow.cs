using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target = null;
    [SerializeField] private float smoothTime = .3f;
    [SerializeField] private Vector3 offset = new Vector3(0,0,-10);
    [SerializeField] private Vector3 velocity = new Vector3(0, 0, 0);

    [SerializeField] private float minLocationX = 0;
    [SerializeField] private float maxLocationX = 0;
    [SerializeField] private float minLocationY = 0;
    [SerializeField] private float maxLocationY = 0;

    void FixedUpdate()
    {
        // Camera follow on the X axis, camera follow on the Y axis, no z movement.
        Vector3 targetPosition = new Vector3(Mathf.Clamp(target.position.x, minLocationX, maxLocationX), Mathf.Clamp(target.position.y, minLocationY, maxLocationY), 0) + offset;
        transform.position = Vector3.SmoothDamp(transform.position * Time.deltaTime, targetPosition, ref velocity, smoothTime);
    }
}
