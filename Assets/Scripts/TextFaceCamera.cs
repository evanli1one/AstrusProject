using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFaceCamera : MonoBehaviour
{
    public GameObject cameraTarget;
    public Camera playerCamera;

    private void Awake()
    {
        gameObject.transform.rotation = cameraTarget.transform.rotation;

        gameObject.transform.eulerAngles = new Vector3(
            playerCamera.transform.eulerAngles.x,
            cameraTarget.transform.eulerAngles.y, 0);
    }
}
