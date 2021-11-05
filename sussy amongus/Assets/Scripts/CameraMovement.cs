using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [Header("This Updates Camera Position Every Frame")]
    [Space]
    [SerializeField] private Transform CameraObject;

    private Transform camPos;

    private void Start()
    {
        camPos = transform.Find("CameraPos").transform;
    }

    void Update()
    {
        CameraObject.SetPositionAndRotation(camPos.position, camPos.rotation);
        
    }
}
