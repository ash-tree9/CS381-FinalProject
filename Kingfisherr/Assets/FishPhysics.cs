using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishPhysics : MonoBehaviour
{
    public GameObject PlayerPos;
    Rigidbody rb;
    public float speed = 0.3f;
    public float detectionRange=5;
    public float playerDetectionRange;
    private float distance;
    public float leashRange;
    private Vector3 startP;
    public bool faceRight = true;


    private void Awake()
    {
        rb = transform.GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        startP = rb.transform.position;
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        distance = Vector3.Distance(transform.position, PlayerPos.transform.position);
        if (distance < (playerDetectionRange))
        {
            Vector3 force = transform.position - PlayerPos.transform.position;
            force.z = 0;
            rb.velocity = force.normalized * (speed+3);
        }

        else if (distance >= detectionRange && Vector3.Distance(transform.position, startP) >= leashRange)
        {
            rb.MovePosition(startP);
            rb.velocity = Vector3.zero;
            faceRight = true;
            
        }
        else if (distance >= playerDetectionRange && Vector3.Distance(transform.position, startP) < leashRange)
        {
            //
            if(!faceRight)
            {
                rb.AddForce(Vector3.left * speed );
                if (transform.position.x < startP.x - leashRange + 1)
                    faceRight = !faceRight;
            }
            //
            if(faceRight)
            {
                rb.AddForce(Vector3.right * speed);
                if (transform.position.x > startP.x + leashRange - 1)
                    faceRight = !faceRight;
            }
        }


    }
}
