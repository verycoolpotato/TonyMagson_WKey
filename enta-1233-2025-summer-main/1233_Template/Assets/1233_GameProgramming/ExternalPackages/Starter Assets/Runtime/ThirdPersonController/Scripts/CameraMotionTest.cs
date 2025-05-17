using System;
using System.Collections;

using UnityEngine;

public class CameraMotionTest : MonoBehaviour
{
    
    [SerializeField] float moveSensitivity;
    [SerializeField] float rotationSensitivity;
    private float yRotate;
    private float yPosition;
    
    private void FixedUpdate()
    {
        MouseEdgeDetect();
    }

    //Checks the mouse position relative to the center of the screen and triggers CameraScroll function if the mouse goes near the edge of the screen
    void MouseEdgeDetect()
    {
        
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2);
        if ((Input.mousePosition - screenCenter).y < -120f)
        {
            yRotate += 1 * Time.deltaTime * rotationSensitivity;
           // yPosition -= 1 * Time.deltaTime * moveSensitivity;
            CameraScroll();
        }
        else if ((Input.mousePosition - screenCenter).y > 120f)
        {
            yRotate -= 1 * Time.deltaTime * rotationSensitivity;
            //yPosition += 1 * Time.deltaTime * moveSensitivity;
            CameraScroll();
        }
        
    }

    //Moves and rotates the camera towards the given coordinates
    void CameraScroll()
    { 
        yRotate = Mathf.Clamp(yRotate, 0, 20);
        yPosition = Mathf.Clamp(yPosition, -0.5f, 0.5f);

        transform.localEulerAngles = (new Vector3(yRotate, -24,0 ));
        //transform.localPosition = new Vector3(transform.position.x, yPosition, transform.position.z);
    }
}
