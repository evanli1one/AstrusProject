using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class LinkObject : MonoBehaviour
{
    public float value;
    public string name;
    public LinkObject linked;

    [SerializeField] protected TextMeshPro nameText;
    [SerializeField] protected TextMeshPro debugText;
    [SerializeField] protected Renderer highlightRenderer;
    [SerializeField] protected LinkParticles linkParticles;

    protected TextMesh textDisplay;
    protected TextMesh debugDisplay;

    protected Material highlightMaterial;
    protected Material originalMaterial;

    public virtual void Construct(Material highlightMaterial)
    {
        this.highlightMaterial = highlightMaterial;

        if (highlightRenderer == null)
        {
            Debug.LogError(this + " highlightRenderer is null");
        }

        originalMaterial = highlightRenderer.material;

        if (linkParticles == null)
        {
            Debug.LogError(this + " linkParticles is null");
        }
    }

    private void Update()
    {
        nameText.text = name;
        debugText.text = value.ToString();
    }

    public virtual void SetLink(LinkObject linkObject)
    {
        this.linked = linkObject;
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

    public void UpdateLinkParticles()
    {
        linkParticles.ChangeLink(linked.transform.position);
    }
}