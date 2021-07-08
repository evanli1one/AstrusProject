using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantifier: BindObject
{
    private new void Awake()
    {
        base.Awake();

        if (value < 0)
        {
            Debug.LogError("Quantifier cannot have negative value");
        }
    }
}