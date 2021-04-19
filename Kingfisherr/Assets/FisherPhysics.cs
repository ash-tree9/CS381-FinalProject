using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisherPhysics : MonoBehaviour
{
    //----------------------------
    //Change
    //----------------------------
    public bool isSelected = false;
    public Vector3 position = Vector3.zero;
    public Vector3 velocity = Vector3.zero;

    public float speed;
    public float desiredSpeed;


    //----------------------------
    //No change
    //----------------------------
    public float acceleration;
    public float maxSpeed;
    public float minSpeed;

    public GameObject cameraRig;

    public GameObject selectionCircle;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        selectionCircle.SetActive(isSelected);
    }
}
