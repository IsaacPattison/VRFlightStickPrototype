using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlightStickTracker : MonoBehaviour
{
    // floats for the flightsticks x and z position
    public float angleX;
    public float inputX;
    public float angleZ;
    public float inputZ;


    void Update()
    {
        // Use for debugging
        print(angleX);
        print(inputX);

        // X Rotation Inputs
        if (transform.localRotation.eulerAngles.x > 10 && transform.localRotation.eulerAngles.x < 45)
        {
            // Creates a value between 0 and 1 to use as an input
            angleX = transform.localRotation.eulerAngles.x;
            inputX = angleX / 45;
        }

        if (transform.localRotation.eulerAngles.x > 315 && transform.localRotation.eulerAngles.x < 350)
        {
            // Creates a value between 0 and -1 to use as an input
            angleX = transform.localRotation.eulerAngles.x;
            inputX = (angleX -= 360) / 45;
        }

        if (transform.localRotation.eulerAngles.x < 10 && transform.localRotation.eulerAngles.x > 350)
        {
            // sets any angle less than 20 to be set to zero so the flight stick isnt too sensitive
            angleX = transform.localRotation.eulerAngles.x;
            inputX = angleX / 0;
        }


        // Z Rotation Inputs
        if (transform.localRotation.eulerAngles.z > 10 && transform.localRotation.eulerAngles.z < 45)
        {
            // Creates a value between 0 and 1 to use as an input
            angleZ = transform.localRotation.eulerAngles.z;
            inputZ = angleZ / 45;

        }

        if (transform.localRotation.eulerAngles.z > 315 && transform.localRotation.eulerAngles.z < 350)
        {
            // Creates a value between 0 and -1 to use as an input
            angleZ = transform.localRotation.eulerAngles.z;
            inputZ = (angleZ -= 360) / 45;
        }

        if (transform.localRotation.eulerAngles.z < 10 && transform.localRotation.eulerAngles.z > 350)
        {
            angleZ = transform.localRotation.eulerAngles.z;
            inputZ = angleZ / 0;
        }

    }
}
