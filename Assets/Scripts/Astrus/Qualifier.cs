using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Qualifier: LinkObject
{
    public UnityEvent OnChangeLink = new UnityEvent();

    public override void Construct(Material highlightMaterial)
    {
        base.Construct(highlightMaterial);

        if (name == null)
        {
            Debug.LogError("Qualifier cannot have null name");
        }

        if (linked != null)
        {
            SetLink(linked);
        }

        OnChangeLink.AddListener(OnChangeLinkCallback);
    }

    public override void SetLink(LinkObject linkObject)
    {
        base.SetLink(linkObject);
        value = linkObject.value;
        OnChangeLink.Invoke();
    }

    private void OnChangeLinkCallback()
    {
        print("OnChangeLinkCallback");

        if (linked != null)
        {
            
        }
    }
}