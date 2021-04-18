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

        controller.Move(direction * Time.deltaTime);
    }
}
