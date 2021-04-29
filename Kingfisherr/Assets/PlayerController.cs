using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //TEMPORARY, just to get the player moving
    //probably should replace with the movement learned in class

    public CharacterController controller;
    private Vector3 direction;
    public float speed = 8;

    public Vector3 rotationOfPlayer = Vector3.zero;
    public GameObject playerModel; // this gets the player model for making character look left and right on a/d keypress
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        direction.x = hInput * speed;
        direction.y = vInput * speed;
        // the below code causes the 
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotationOfPlayer.y = 270;
            playerModel.transform.localEulerAngles = rotationOfPlayer;
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotationOfPlayer.y = 90;
            playerModel.transform.localEulerAngles = rotationOfPlayer;
        }

        direction.z = 0;

        controller.Move(direction * Time.deltaTime);
    }
}
