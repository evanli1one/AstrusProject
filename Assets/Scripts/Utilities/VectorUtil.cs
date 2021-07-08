using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VectorUtil
{
    public static float ConvertVectorToAngle(Vector2 vector)
    {
        vector.Normalize();
        var ang = Mathf.Asin(vector.x) * Mathf.Rad2Deg;
        // fix the angle for 2nd and 3rd quadrants:
        if (vector.y < 0)
        {
            ang = 180 - ang;
        }
        else // fix the angle for 4th quadrant:
        if (vector.x < 0)
        {
            ang = 360 + ang;
        }
        return ang;
    }
}
