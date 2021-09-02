using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class LinkParticles : MonoBehaviour
{
    private ParticleSystem linkParticleSystem;

    private ParticleSystem.EmissionModule emission;
    private ParticleSystem.ShapeModule shape;

    private Vector3 startPosition;

    private void Awake()
    {
        linkParticleSystem = gameObject.GetComponent<ParticleSystem>();

        emission = linkParticleSystem.emission;
        shape = linkParticleSystem.shape;

        startPosition = gameObject.transform.position;
    }

    public void ChangeLink(Vector3 endpoint)
    {
        Vector3 currentPosition = gameObject.transform.position;

        float distance = Vector3.Distance(endpoint, currentPosition) / 2;
        Vector3 relativePos = endpoint - currentPosition;
        Vector3 offset = relativePos/2;

        float yRotation = VectorUtil.AngleBetweenPoints(currentPosition, endpoint);
        Vector3 rotationOffset = new Vector3(0, yRotation + 90, 0);

        shape.radius = distance;
        shape.rotation = rotationOffset;
        shape.position = offset;

        emission.enabled = true;
    }
}
