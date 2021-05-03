using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    

    //public CharacterController controller;
    private Vector3 direction;
    Rigidbody rb;
    public float speed = 1;

    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    public Vector3 rotationOfPlayer = Vector3.zero;
    public GameObject playerModel; // this gets the player model for making character look left and right on a/d keypress
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        /*float hInput = Input.GetAxis("Horizontal");
        float vInput = Input.GetAxis("Vertical");
        direction.x = hInput * speed;
        direction.y = vInput * speed;*/
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

        if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left * speed);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right * speed);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up * speed);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down * speed);

        
    }
}
