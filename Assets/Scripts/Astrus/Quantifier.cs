using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantifier: LinkObject
{
    public new void Construct(Material highlightMaterial)
    {
        base.Construct(highlightMaterial);

        if (value < 0)
        {
            Debug.LogError("Quantifier cannot have negative value");
        }
    }
}