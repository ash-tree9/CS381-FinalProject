using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 initialPosition = Vector3.zero;
    void Start()
    {
        initialPosition = transform.localPosition;
    }
    public FisherPhysics entity;
    public Vector3 range = Vector3.zero;
    public bool facingLeft = false;

    public GameObject player;           //so the fish always know where the player is
    public float detectionRange = 4.0F; //how far the fish can detect the player
    // Update is called once per frame
    void Update()
    {
        range.z = 0;// to make sure fish doesn't go in the z direction

        float distance = Vector3.Distance(transform.position, player.transform.position);

       // Debug.Log("Distance: " + distance);
        if (distance < detectionRange)
        {
            Vector3 dirToPlayer = transform.position - player.transform.position;
            dirToPlayer.z = 0;
            Vector3 newPos = transform.position + dirToPlayer;

        }

        else if (facingLeft)
            moveLeft();
        else
            moveRight();
    }

    public void moveLeft()
    {

        entity.desiredSpeed = -1;
        if (entity.position.x < (initialPosition.x - range.x))
            facingLeft = !facingLeft;

    }
    public void moveRight()
    {
        entity.desiredSpeed = 1;

        if (entity.position.x > (initialPosition.x + range.x))
            facingLeft = !facingLeft;

    }
}
