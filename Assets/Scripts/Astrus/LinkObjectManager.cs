using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkObjectManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;

    private List<LinkObject> linkObjectList =
        new List<LinkObject>();

    public void Construct()
    {
        var foundLinkObjects = FindObjectsOfType<LinkObject>(true);

        foreach(LinkObject linkObject in foundLinkObjects)
        {
            linkObjectList.Add(linkObject);

            linkObject.Construct(highlightMaterial);
        }
    }

    public void Remove(LinkObject linkObject)
    {
        linkObjectList.Remove(linkObject);
    }

    public void Add(LinkObject linkObject)
    {
        linkObjectList.Add(linkObject);
    }
}
