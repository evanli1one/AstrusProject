using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class LinkObject : MonoBehaviour
{
    public float value;
    public string name;
    public LinkObject linkObject;

    [SerializeField] protected TextMeshPro nameText;
    [SerializeField] protected TextMeshPro debugText;
    [SerializeField] protected string bindRendererTag;

    protected TextMesh textDisplay;
    protected TextMesh debugDisplay;
    protected Renderer highlightRenderer;
    protected Material highlightMaterial;
    protected Material originalMaterial;

    public void Construct(Material highlightMaterial)
    {
        this.highlightMaterial = highlightMaterial;

        Transform foundRenderer = HelperFunctions.RecursiveFindChild(
            gameObject.transform, bindRendererTag);

        highlightRenderer = foundRenderer.GetComponent<Renderer>();

        if (highlightRenderer == null)
        {
            Debug.LogError(this + " Couldn't find bindRenderer" +
                " with tag " + bindRendererTag);
        }

        originalMaterial = highlightRenderer.material;
    }

    private void Update()
    {
        nameText.text = name;
        debugText.text = value.ToString();

        if(linkObject != null)
        {
            Debug.DrawLine(gameObject.transform.position,
                linkObject.gameObject.transform.position,
                Color.red);
        }
    }

    public virtual void SetBind(LinkObject bindObject)
    {
        this.linkObject = bindObject;
    }

    public void UpdateMaterial(Material newMaterial)
    {
        highlightRenderer.material = newMaterial;
    }

    public void Highlight()
    {
        highlightRenderer.material = highlightMaterial;
    }

    public void RemoveHighlight()
    {
        highlightRenderer.material = originalMaterial;
    }
}