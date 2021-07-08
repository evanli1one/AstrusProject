using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsoPlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 4f;
    [SerializeField] GameObject cameraTarget;

    Vector3 forward;
    Vector3 right;

    // Start is called before the first frame update
    void Start()
    {
        forward = cameraTarget.transform.forward;
        forward = Vector3.Normalize(forward);
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward;

        print(forward);
        print(right);

        Debug.DrawRay(gameObject.transform.position, forward);
        Debug.DrawRay(gameObject.transform.position, right);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey)
        {
            Move();
        }
    }

    private void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),
            0, Input.GetAxis("Vertical"));

        Vector3 rightMovement = right * moveSpeed * Time.deltaTime
            * Input.GetAxis("Horizontal");

        Vector3 upMovement = forward * moveSpeed * Time.deltaTime
            * Input.GetAxis("Vertical");

        Vector3 heading = Vector3.Normalize(rightMovement + upMovement);

        //transform.forward = heading;
        transform.position += rightMovement;
        transform.position += upMovement;
    }
}
