using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BindController : MonoBehaviour
{
    // References
    [Tooltip("Required reference to inputManager")]
    [SerializeField] private InputManager inputManager;

    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    //private void Awake()
    //{
    //    inputManager.onDoubleSelection.AddListener(UpdatedSelectedBinds);
    //    inputManager.onSelection.AddListener(Highlight);
    //    inputManager.onResetSelection.AddListener(ResetHighlight);
    //    inputManager.onNewPreviousSelection.AddListener(RemovePreviousHighlight);
    //}

    //private void UpdatedSelectedBinds()
    //{
    //    print("onDoubleSelection");
    //    BindObject current = inputManager.currentSelection;
    //    BindObject previous = inputManager.previousSelection;

    //    if (current != null & previous != null)
    //    {
    //        current.SetBind(previous);
    //        previous.SetBind(current);
    //    }
    //}

    //private void Highlight()
    //{
    //    print("onSelection");
    //    Renderer renderer = inputManager.thisSelection.renderer;
    //    renderer.material = highlightMaterial;
    //}

    //private void RemovePreviousHighlight()
    //{
    //    print("onNewPreviousSelection");
    //    inputManager.previousSelection.renderer.material = defaultMaterial;
    //}

    //private void ResetHighlight()
    //{
    //    print("onResetSelection");
    //    if(inputManager.currentSelection != null)
    //    {
    //        inputManager.currentSelection.renderer.material = defaultMaterial;
    //    }
    //    if (inputManager.previousSelection != null)
    //    {
    //        inputManager.previousSelection.renderer.material = defaultMaterial;
    //    }
    //}
}
