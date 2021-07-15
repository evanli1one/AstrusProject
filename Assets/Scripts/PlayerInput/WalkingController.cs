using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WalkingController : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Player max velocity")]
    [SerializeField] private float maxSpeed;
    [Tooltip("Rate of acceleration in delta velocity per second")]
    [SerializeField] private float moveAccel;
    [Tooltip("Rate of decceleration in delta velocity per second")]
    [SerializeField] private float slowRate;

    // References
    [SerializeField] InputManager inputManager;
    private Rigidbody rigidbody;

    [SerializeField] private Text debugText0;
    [SerializeField] private Text debugText1;
    [SerializeField] private Text debugText2;

    private Vector2 moveVector2D;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        debugText2.text = "inputManager.newMoveInput: " + inputManager.newMoveInput;
        if (inputManager.newMoveInput)
        {
            Move(inputManager.moveInput);
            Rotate();
        }
        else
        {
            Slow();
        }

        Vector3 newVelocity = new Vector3(moveVector2D.x, 0, moveVector2D.y);

        rigidbody.velocity = newVelocity;

        debugText1.text = "newVelocity: " + newVelocity;
    }

    private void Move(Vector2 inputVector)
    {
        debugText0.text = "inputVector: " + inputVector;

        moveVector2D += inputVector * moveAccel * Time.deltaTime;
        moveVector2D = Vector2.ClampMagnitude(moveVector2D, maxSpeed);
    }

    private void Rotate()
    {
        Vector2 moveDirection = moveVector2D;
        moveDirection.Normalize();

        float angleRotation = VectorUtil.ConvertVectorToAngle(moveDirection);
        gameObject.transform.eulerAngles = new Vector3(0, angleRotation, 0);
    }

    private void Slow()
    {
        Vector2 direction = moveVector2D;
        direction.Normalize();
        moveVector2D -= direction * slowRate * Time.deltaTime;

        if(moveVector2D.magnitude < 0.1)
        {
            moveVector2D = Vector2.zero;
        }
    }
}
