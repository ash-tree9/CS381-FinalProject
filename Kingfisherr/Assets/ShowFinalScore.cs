using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowFinalScore : MonoBehaviour
{
    public Text score;
    public int finalScoreValue;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        finalScoreValue = pickupFish.inst.bubbleScoreValue;
        score.text = "Final Score: " + finalScoreValue;
    }
}
