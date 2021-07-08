using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public Vector2 rawVector;
    public float magnitude;
    public Vector2 direction;

    public BindObject thisSelection;
    public BindObject currentSelection;
    public BindObject previousSelection;

    public bool newMovementData;
    public bool newSelectionData;

    [SerializeField] private float zeroThreshold = 0.01f;
    [SerializeField] private LayerMask selectMask;
    [SerializeField] private GameObject cameraTarget;

    public UnityEvent onResetSelection = new UnityEvent();
    public UnityEvent onSelection = new UnityEvent();
    public UnityEvent onDoubleSelection = new UnityEvent();
    public UnityEvent onNewPreviousSelection = new UnityEvent();

    private void Awake()
    {
        
    }

    private void Update()
    {
        MovementInput();
        SelectionInput();

        UpdateMouseData();
        UpdateMovementData();
    }

    private void MovementInput()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 tempHorizontal = new Vector3(horizontal, 0, 0);
        Vector3 tempVertical = new Vector3(0, 0, vertical);

        Vector3 forward = Vector3.Normalize(cameraTarget.transform.forward);
        Vector3 right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        tempVertical = Vector3.Project(tempVertical, forward);
        tempHorizontal = Vector3.Project(tempHorizontal, right);

        rawVector = new Vector2(tempHorizontal.x + tempVertical.x,
            tempHorizontal.z + tempVertical.z);
    }

    private void SelectionInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            bool raycast = Physics.Raycast(ray, out hit, Mathf.Infinity, selectMask);
            if (raycast)
            {
                thisSelection = hit.transform.gameObject.GetComponent<BindObject>();
            }
            else
            {
                thisSelection = null;
                ResetSelections();
            }
        }
    }

    private void UpdateMouseData()
    {
        newSelectionData = false;

        if (thisSelection == null)
        {
            
        }
        else if(thisSelection != currentSelection &&
                thisSelection != currentSelection)
        {
            newSelectionData = true;
            onSelection.Invoke();
            UpdateSelections();
        }
    }

    private void UpdateMovementData()
    {
        if (rawVector != Vector2.zero)
        {
            newMovementData = true;

            magnitude = rawVector.magnitude;
            magnitude = Mathf.InverseLerp(0, 1, magnitude);

            if (magnitude < zeroThreshold)
            {
                magnitude = 0f;
            }

            direction = rawVector;
            direction.Normalize();
        }
        else
        {
            newMovementData = false;
        }
    }

    public void ResetSelections()
    {
        onResetSelection.Invoke();
        currentSelection = null;
        previousSelection = null;
    }

    public void UpdateSelections()
    {
        if(previousSelection != null)
        {
            onNewPreviousSelection.Invoke();
        }

        previousSelection = currentSelection;
        currentSelection = thisSelection;

        if(previousSelection != null && currentSelection != null)
        {
            onDoubleSelection.Invoke();
        }
    }
}