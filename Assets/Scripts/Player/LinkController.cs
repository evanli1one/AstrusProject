using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class LinkController : MonoBehaviour
{
    // References
    [SerializeField] private InputManager inputManager;

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private LayerMask layerMask;

    [SerializeField] private Camera playerCamera;

    private Collider sphereCollider;

    private LinkObject highlightedObject;
    private LinkObject currentSelection;
    private LinkObject previousSelection;

    private Dictionary<LinkObject, Material> materialsDict =
        new Dictionary<LinkObject, Material>();

    private void Awake()
    {
        sphereCollider = gameObject.GetComponent<Collider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        print("Enter");
        if (layerMask.Contains(other.gameObject.layer))
        {
            print("Layer mask contains");
            LinkObject nearObject = other.gameObject
                .GetComponent<LinkObject>();
            if (nearObject != null)
            {
                print("Found nearObject");
                PrepareSelection(nearObject);
                MakeSelection(nearObject);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit");
        if (layerMask.Contains(other.gameObject.layer))
        {
            LinkObject nearObject = other.gameObject
                .GetComponent<LinkObject>();
            if (nearObject != null)
            {
                nearObject.RemoveHighlight();
            }
        }
    }

    private void PrepareSelection(LinkObject bindObject)
    {
        bindObject.Highlight();
    }

    private void MakeSelection(LinkObject bindObject)
    {
        if (bindObject == null)
        {
            ResetSelections();
            return;
        }

        if(bindObject != currentSelection)
        {
            previousSelection = currentSelection;
            currentSelection = bindObject;

            BindSelections();
        }
    }

    private void BindSelections()
    {
        if(currentSelection != null
            && previousSelection != null)
        {
            currentSelection.SetBind(previousSelection);
            previousSelection.SetBind(currentSelection);

            ResetSelections();
        }
    }

    private void ResetSelections()
    {
        if(currentSelection != null)
        {
            currentSelection.RemoveHighlight();
        }
        if (previousSelection != null)
        {
            currentSelection.RemoveHighlight();
        }
        currentSelection = null;
        previousSelection = null;
    }
}
