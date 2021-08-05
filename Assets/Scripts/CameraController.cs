using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;
    public float speed = 0.5f;
    public Vector3 offset;

    void LateUpdate() {
        transform.position = FollowPlayerPosition();    
    }

    private Vector3 FollowPlayerPosition() {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        
        smoothPosition.y = 0f;

        return smoothPosition;
    }
}
