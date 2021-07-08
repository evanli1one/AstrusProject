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
    [Tooltip("Required reference to inputManager")]
    [SerializeField] private InputManager inputManager;
    [SerializeField] GameObject cameraTarget;
    private Rigidbody rigidbody;

    [SerializeField] private Text debugText0;
    [SerializeField] private Text debugText1;
    [SerializeField] private Text debugText3;

    private Vector2 slowVector2D;
    private Vector2 moveVector2D;
    private bool isSlowing = false;

    private Vector3 camForward;
    private Vector3 camRight;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();

        camForward = cameraTarget.transform.forward;
        camForward.Normalize();
        camRight = Quaternion.Euler(new Vector3(0, 90, 0)) * camForward;
    }

    private void Update()
    {
        if (inputManager.newMovementData)
        {
            isSlowing = false;
            Move();
            Rotate();

            debugText1.text = "Move";
        }
        else
        {
            Slow();
            debugText1.text = "Slow";
        }

        debugText0.text = moveVector2D.ToString();

        rigidbody.velocity = new Vector3(moveVector2D.x, 0, moveVector2D.y);
    }

    private void Move()
    {
        moveVector2D += inputManager.direction * inputManager.magnitude * moveAccel * Time.deltaTime;
        moveVector2D = Vector2.ClampMagnitude(moveVector2D, maxSpeed);

        rigidbody.velocity = new Vector3(moveVector2D.x, 0, moveVector2D.y);
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
        if (isSlowing)
        {
            Vector2 direction = moveVector2D;
            direction.Normalize();
            moveVector2D -= camForward * direction * slowRate * Time.deltaTime;

            if(moveVector2D.magnitude < 0.1)
            {
                moveVector2D = Vector2.zero;
                isSlowing = false;
            }
        }
        else
        {
            isSlowing = true;
            slowVector2D = moveVector2D;
        }
    }
}
