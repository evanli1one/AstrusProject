using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quantifier: LinkObject
{
    public override void Construct(Material highlightMaterial)
    {
        base.Construct(highlightMaterial);

        if (value < 0)
        {
            Debug.LogError("Quantifier cannot have negative value");
        }
    }

    public override void SetLink(LinkObject linkObject)
    {
        base.SetLink(linkObject);
        UpdateLinkParticles();
    }
}