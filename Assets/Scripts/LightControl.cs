using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour
{
    private GameObject[] sidelights;

    // Start is called before the first frame update
    void Start()
    {
        // Find all the sidelight objects in the scene
        sidelights = GameObject.FindGameObjectsWithTag("sidelight");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PurpleLights()
    {
        // Set the color of the sidelights to magenta
        SetColor(Color.magenta);
    }

    public void RedLights()
    {
        // Set the color of the sidelights to red
        SetColor(Color.red);
    }

    public void SetColor(Color color)
    {
        // Set the color of the sidelights to the specified color
        foreach (GameObject go in sidelights)
        {
            go.GetComponentInChildren<Light>().color = color;
        }
    }
}
