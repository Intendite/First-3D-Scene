using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    public LightControl lc;

    // An array of colors that the lights will cycle through
    public Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow, Color.magenta };

    // A counter variable to keep track of the current color index
    private int colorIndex = 0;

    // Update is called once per frame
    void Update()
    {
        // Check if the player has pressed the space key
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Increment the color index
            colorIndex++;

            // If the color index is greater than or equal to the number of colors in the array, set it back to 0
            if (colorIndex >= colors.Length)
            {
                colorIndex = 0;
            }

            // Call the SetColor method on the LightControl component, passing in the current color from the array
            lc.SetColor(colors[colorIndex]);
        }
    }
}
