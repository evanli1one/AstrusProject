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
        emission.enabled = true;

        float distance = Vector3.Distance(endpoint, startPosition) / 2;
        Vector3 relativePos = endpoint - startPosition;
        Quaternion rotation = Quaternion.LookRotation(relativePos);
        Vector3 offset = startPosition + relativePos / 2;

        print("distance: " + distance);
        print("rotation: " + rotation);
        print("offset: " + offset);

        shape.radius = distance / 2;
        shape.rotation = rotation.eulerAngles;
        shape.position = offset;
    }
}
