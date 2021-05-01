using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupFish : MonoBehaviour
{
    //so UI can check on score
    public static pickupFish inst;
    private void Awake()
    {
        inst = this;
    }

    public static int scoreValue;
    public int bubbleScoreValue; //to get scoreValue in UIMgr
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Fish: " + scoreValue;
        bubbleScoreValue = scoreValue;
    }
}
