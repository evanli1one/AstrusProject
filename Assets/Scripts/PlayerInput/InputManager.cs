using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public GameplayControls gameplayControls;
    [SerializeField] private GameObject cameraTarget;
    
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public UnityEvent onStopMoveInput;
    [HideInInspector] public bool newMoveInput;

    public void Construct()
    {
        gameplayControls = new GameplayControls();
        gameplayControls.PlayerActionMap.MoveHCell.performed
            += context => MoveHorizontal(context.ReadValue<float>());

        gameplayControls.Enable();
    }

    private void MoveHorizontal(float testNum)
    {
        //print("testNum: " + testNum);
    }

    private void Update()
    {
        moveInput = gameplayControls.PlayerActionMap
            .MovePlayer.ReadValue<Vector2>();

        UpdateMoveInput();
    }

    private void OnEnable()
    {
        if(gameplayControls != null)
        {
            gameplayControls.Enable();
        }
    }

    private void OnDisable()
    {
        gameplayControls.Disable();
    }

    private void UpdateMoveInput()
    {
        if (moveInput.Equals(Vector2.zero))
        {
            newMoveInput = false;

            onStopMoveInput.Invoke();
        }
        else
        {
            newMoveInput = true;

            Quaternion rotation = cameraTarget.transform.rotation;
            Vector3 moveInput3D = new Vector3(moveInput.x, 0, moveInput.y);

            moveInput3D = rotation * moveInput3D;

            moveInput = new Vector2(moveInput3D.x, moveInput3D.z);
        }
    }
}
