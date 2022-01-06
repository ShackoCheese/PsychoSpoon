using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParalaxBackground : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 lastCameraPosition;
    public float offset = .5f;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }
    
    void LateUpdate()
    {
         Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
         transform.position += deltaMovement * offset;
         lastCameraPosition = cameraTransform.position;
    }
}
