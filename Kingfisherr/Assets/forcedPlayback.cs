using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcedPlayback : MonoBehaviour
{
    void Awake()
    {
        int numOfSessions = FindObjectsOfType<forcedPlayback>().Length;

        if (numOfSessions > 1)

        {

            Destroy(gameObject);

        }

        else

        {

            DontDestroyOnLoad(gameObject);

        }
    }

}
