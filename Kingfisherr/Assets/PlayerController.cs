using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //allows player to bring up winscreen
    public GameObject winScreen;

    //public CharacterController controller;
    private Vector3 direction;
    Rigidbody rb;
    public float speed = 1;
    //below is for dash mechanics
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int directionX;
    private Vector3 v3;
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
        // the below code causes the character model to look left or right depending on which key is pressed down.
        if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rotationOfPlayer.y = 270;
            playerModel.transform.localEulerAngles = rotationOfPlayer;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rotationOfPlayer.y = 90;
            playerModel.transform.localEulerAngles = rotationOfPlayer;
        }
        //allows player to skip to level 2/winscreen
        if(Input.GetKeyDown(KeyCode.F9))
            SceneManager.LoadScene("LevelTwoScene");
        if (Input.GetKeyDown(KeyCode.F10))
            winScreen.SetActive(true);


        direction.z = 0; // attempts to make sure that the z value doesn't change

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
