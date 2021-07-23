using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qualifier: LinkObject
{
    public new void Construct(Material highlightMaterial)
    {
        base.Construct(highlightMaterial);

        if (name == null)
        {
            Debug.LogError("Qualifier cannot have null name");
        }

        if (linkObject != null)
        {
            SetBind(linkObject);
        }
    }

    public override void SetBind(LinkObject bindObject)
    {
        UpdateBindValue(bindObject);
    }

    public void UpdateBindValue(LinkObject bindObject)
    {
        value = bindObject.value;
    }
}