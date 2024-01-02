using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Get the player's input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // Calculate the movement vector
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // Apply the movement to the player's Rigidbody component
        GetComponent<Rigidbody>().AddForce(movement * speed * Time.deltaTime);
    }
}
