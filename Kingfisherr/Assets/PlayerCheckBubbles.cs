using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCheckBubbles : MonoBehaviour
{
    public bool isUnderwater = false; //check if player is underwater
    public GameObject player;

    public int bubbleLoss = 1; //one bubble lost each tick
    public float timeEachTick = 10f; //each bubble is 10 seconds, can change

    Coroutine losingAir;

    //used for respawning
    [SerializeField] private Transform playerRespawn;
    [SerializeField] private Transform respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isUnderwater)
        {
            if (UIMgr.inst.air <= 0)
            {
                Debug.Log("out of air!");
                if (losingAir != null)
                    StopCoroutine(losingAir);
                //here will be respawning code
                //set isUnderwater to false, air to max after respawn
                playerRespawn.transform.position = respawnPoint.transform.position;
                isUnderwater = false;
            }
        }
        else
        {
            if (losingAir != null)
                StopCoroutine(losingAir);

            UIMgr.inst.air = UIMgr.inst.bubbleCount;
        }
    }

    IEnumerator AirLoss()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(timeEachTick);
            UIMgr.inst.air -= 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.transform.tag == "Water" && !isUnderwater)
        {
            Debug.Log("underwater!");
            isUnderwater = true;
            losingAir = StartCoroutine(AirLoss());
        }
    }

    private void OnTriggerStay(Collider other)
    {
        //here could be dash code? dashing only avaliable underwater?
        //if we have time
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform.tag == "Water" && isUnderwater)
        {
            Debug.Log("no longer underwater...");
            isUnderwater = false;
            UIMgr.inst.air = UIMgr.inst.bubbleCount;
            if (losingAir != null)
            {
                StopCoroutine(losingAir);
            }
        }
    }
}
