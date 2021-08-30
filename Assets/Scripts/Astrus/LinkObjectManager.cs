using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkObjectManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;

    private List<LinkObject> linkObjectList =
        new List<LinkObject>();

    private Dictionary<Qualifier, Quantifier> linksDict =
        new Dictionary<Qualifier, Quantifier>();

    public void Construct()
    {
        var foundLinkObjects = FindObjectsOfType<LinkObject>();

        foreach(LinkObject linkObject in foundLinkObjects)
        {
            linkObjectList.Add(linkObject);
            linkObject.Construct(highlightMaterial);

            LinkObject linked = linkObject.linked;

            if (linkObject.GetType() == typeof(Qualifier) &&
                linked != null)
            {
                linksDict.Add((Qualifier)linkObject,
                    (Quantifier)linked);
            }
        }
    }

    public void AddObject(LinkObject linkObject)
    {
        linkObjectList.Add(linkObject);
    }

    public void RemoveObject(LinkObject linkObject)
    {
        linkObjectList.Remove(linkObject);
    }

    public void AddLink(Qualifier key, Quantifier value)
    {
        linksDict.Add(key, value);
    }
}
