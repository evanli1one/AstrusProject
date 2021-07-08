using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Qualifier: BindObject
{
    private new void Awake()
    {
        base.Awake();

        if(name == null)
        {
            Debug.LogError("Qualifier cannot have null name");
        }
    }

    public override void SetBind(BindObject bindObject)
    {
        UpdateBindValue(bindObject);
    }

    public void UpdateBindValue(BindObject bindObject)
    {
        value = bindObject.value;
    }
}