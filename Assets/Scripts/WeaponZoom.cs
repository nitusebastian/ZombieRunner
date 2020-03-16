using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private float zoomedOutFOV = 60f;
    [SerializeField] private float zoomedInFOV = 20f;
    private float zoomedInSensitivity = 2f;
    private float zoomedOutSensitivity = 0.5f;
    
    
    private bool zoomedInToogle = false;

    private RigidbodyFirstPersonController fpsController;
    
    // Start is called before the first frame update
    void Awake()
    {
        fpsController = GetComponentInParent<RigidbodyFirstPersonController>();
        
    }

    private void OnDisable()
    {
        ZoomOut();
    }

    public void ZoomIn()
    {
        if (fpsCamera)
        {
            fpsCamera.fieldOfView = zoomedInFOV;
            zoomedInToogle = true;
            fpsController.mouseLook.XSensitivity = zoomedInSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedInSensitivity;
        }
    }

    public void ZoomOut()
    {
        if (fpsCamera)
        {
            fpsCamera.fieldOfView = zoomedOutFOV;
            zoomedInToogle = false;
            fpsController.mouseLook.XSensitivity = zoomedOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomedOutSensitivity;
        }
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToogle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }
        }
    }
}
