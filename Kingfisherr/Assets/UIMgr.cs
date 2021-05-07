using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMgr : MonoBehaviour
{
    public static UIMgr inst;
    private void Awake()
    {
        inst = this;
    }

    public int air; //how much air the player has
    public int bubbleCount; //max amount of air the player can have
    //public static int fishCount = 0;

    public Image[] bubbles; //stores the bubbles in an array

    //might not need these
    public Sprite fullBubble;
    public Sprite emptyBubble;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /* TEST THIS WHEN PICK UP FISH WORKS */
        if (bubbleCount < 10) //if max bubbles have not been hit
        {
            switch (pickupFish.inst.bubbleScoreValue) //there has to be a better way
            {
                case 5:
                    bubbleCount = 4;
                    break;
                case 10:
                    bubbleCount = 5;
                    break;
                case 15:
                    bubbleCount = 6;
                    break;
                case 20:
                    bubbleCount = 7;
                    break;
                case 25:
                    bubbleCount = 8;
                    break;
                case 30:
                    bubbleCount = 9;
                    break;
                case 35:
                    bubbleCount = 10;
                    break;
                default:
                    break;
            }
        }

        if (air > bubbleCount) //make sure amount of air doesn't exceed amount of bubbles
            air = bubbleCount;

        for (int i = 0; i < bubbles.Length; i++)
        {
            if (i < air)
                bubbles[i].sprite = fullBubble;
            else
                bubbles[i].sprite = emptyBubble;

            if (i < bubbleCount)
                bubbles[i].enabled = true;
            else
                bubbles[i].enabled = false;
        }
    }
}
