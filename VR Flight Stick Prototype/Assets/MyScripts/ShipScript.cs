using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    [Header("Flight Stick")]
    public GameObject FlightStick;
    public FlightStickTracker FlightStickScript;

    public float speed = 90.0f;

    // Reference the flightstick script on play
    void Start()
    {
        FlightStickScript = FlightStick.GetComponent<FlightStickTracker>(); 
    }

    void Update()
    {
        // Get the inputs from the tracker script and use it to angle the plane
        transform.Rotate(FlightStickScript.inputX, 0.0f, FlightStickScript.inputZ);

        // Make the plane fly forward at a speed
        transform.position += transform.forward * Time.deltaTime * speed;

        // Decrease the speed of the plane when flying upwards
        speed -= transform.forward.y * Time.deltaTime * 50.0f;

        if (speed < 35.0f)
        {
            speed = 35.0f;
        }

        // If our position is lower than the terrain then update the plane position
        // to be at the terrain height
        float terrainHeightPlaneLocation = Terrain.activeTerrain.SampleHeight(transform.position);

        if (terrainHeightPlaneLocation > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, terrainHeightPlaneLocation, transform.position.z);
        }



        
    }
}
