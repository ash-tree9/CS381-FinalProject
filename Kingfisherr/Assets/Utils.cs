using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utils
{
    public static float EPSILON = 0.01f;
    public static bool ApproximatelyEqual(float a, float b)
    {
        return (Mathf.Abs(a - b) < EPSILON);
    }

    public static float Clamp(float val, float min, float max)
    {
        if (val < min)
            val = min;
        if (val > max)
            val = max;
        return val;
    }

    

    
}
