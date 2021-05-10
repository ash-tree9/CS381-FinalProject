using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private AudioSource chompSoundEffect;
    private void Start()
    {
        chompSoundEffect = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "fish") {
            pickupFish.scoreValue += 1;
            
            chompSoundEffect.Play();
            Destroy(other.gameObject);
        }
    }
}
