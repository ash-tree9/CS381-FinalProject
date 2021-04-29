using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPhysics : MonoBehaviour
{
    public GameObject PlayerPos;
    Rigidbody rb;
    public float speed = 0.1f;


    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 force = transform.position - PlayerPos.transform.position;
        //   rb.AddForce(force.normalized * speed, ForceMode.Impulse);
        rb.velocity = force.normalized * speed;
    }
}
