using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotionTest : MonoBehaviour
{
    enum height
    {
        down,
        middle,
        up
    }
    Vector3 screenCenter;
    public Transform mousePoint;

    private void Update()
    {
        Debug.Log(Input.mousePosition - screenCenter);
        screenCenter = new Vector3 (Screen.width/2, Screen.height/2);

        if (Input.GetKeyDown(KeyCode.U))
        {
            transform.position += new Vector3(0,2,0);
        }
        else if(Input.GetKeyUp(KeyCode.U))
        {
            transform.position -= new Vector3(0, 2, 0);
        }
    }
}
