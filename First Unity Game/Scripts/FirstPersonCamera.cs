using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public Transform Player; 
    public float MouseSensitivity = 0f;
    float CameraVerticalRotation = 0f;

    bool LockedCursor = true; 
    // Start is called before the first frame update
    void Start()
    {
        //Lock and Hide cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // Collect Mouse Input

        float InputX = Input.GetAxis("Mouse X") * MouseSensitivity;
        float InputY = Input.GetAxis("Mouse Y") * MouseSensitivity;

        //Rotate the camera along it's local X-Axis

        CameraVerticalRotation -= InputY;

        CameraVerticalRotation = Mathf.Clamp(CameraVerticalRotation, -90f, 90f);

        transform.localEulerAngles = Vector3.right * CameraVerticalRotation;

        //Rotate the Player object and the camera around it's Y axis

        Player.Rotate(Vector3.up * InputX); 
    }
}
