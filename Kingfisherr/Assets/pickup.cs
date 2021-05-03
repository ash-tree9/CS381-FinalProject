using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fish") {
            pickupFish.scoreValue += 1;
            Destroy(other.gameObject);
        }
    }
}
