using System;
using System.Collections;
using System.Collections.Generic;
using Codice.CM.Common.Tree;
using UnityEngine;

public class CameraMotionTest : MonoBehaviour
{
    float yRotate;
    float yPosition;
    [SerializeField] float sensitivity;
    private void Update()
    {
        Vector3 screenCenter = new Vector3(Screen.width / 2, Screen.height / 2);

        if ((Input.mousePosition - screenCenter).y < -120f)
        {
            yRotate -= 8 * Time.deltaTime * sensitivity;
            yPosition -= 4 * Time.deltaTime * sensitivity;
        }
        else if((Input.mousePosition - screenCenter).y > 120f)
        { 
            yRotate += 8 * Time.deltaTime * sensitivity;
            yPosition += 4 * Time.deltaTime * sensitivity;
        }
       
        yRotate = Mathf.Clamp(yRotate, -1.5f, 1);
        yPosition = Mathf.Clamp(yPosition, 0.4f, 0.7f);

        transform.LookAt(new Vector3(6, yRotate, 0.4f));

        transform.position = new Vector3(transform.position.x, yPosition, transform.position.z);

       
        
    }
    
}
