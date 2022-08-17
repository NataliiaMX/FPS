using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WearponZoom : MonoBehaviour
{
    [SerializeField] Camera camera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField ]float zoomIn = 25f;
    [SerializeField] float zoomOut = 67f;

    bool zoomedInToggle = false;

    private void Update() 
    {
        ProseccRifleSettings(); 
    }

    private void OnDisable() 
    {
        camera.fieldOfView = zoomOut;
        fpsController.movementSettings.ForwardSpeed = 8f;
        fpsController.movementSettings.BackwardSpeed = 8f;
    }
    private void ProseccRifleSettings()
    {
        fpsController.movementSettings.ForwardSpeed = 5f;
        fpsController.movementSettings.BackwardSpeed = 5f;
        // Debug.Log(fpsController.movementSettings.ForwardSpeed + ", " + fpsController.movementSettings.BackwardSpeed);
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                fpsController.mouseLook.XSensitivity = 0.5f;
                fpsController.mouseLook.YSensitivity = 0.5f;
                camera.fieldOfView = zoomIn; //zoomed in
                zoomedInToggle = true;
            }
            else
            {
                fpsController.mouseLook.XSensitivity = 2f;
                fpsController.mouseLook.YSensitivity = 2f;
                camera.fieldOfView = zoomOut; //zoomed out
                zoomedInToggle = false;
            }
        }
    }
}
