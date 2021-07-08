using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BindObject : MonoBehaviour
{
    public float value;
    public string name;
    public BindObject bindObject;

    [SerializeField] protected TextMesh nameText;
    [SerializeField] protected TextMesh debugText;

    protected TextMesh textDisplay;
    protected TextMesh debugDisplay;
    public Renderer renderer;

    protected void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        nameText.text = name;
        debugText.text = value.ToString();
    }

    public virtual void SetBind(BindObject bindObject)
    {
        this.bindObject = bindObject;
    }

    public void UpdateMaterial(Material newMaterial)
    {
        renderer.material = newMaterial;
    }
}