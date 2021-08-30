using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class HelperFunctions
{
    public static Transform RecursiveFindChild(Transform parent, string tagToFind)
    {
        foreach (Transform child in parent)
        {
            if (child.tag == tagToFind)
            {
                return child;
            }
            else
            {
                Transform found = RecursiveFindChild(child, tagToFind);
                if (found != null)
                {
                    return found;
                }
            }
        }
        return null;
    }
}

