using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : InteractableItem
{
    private float _launchSpeed = 50f;
    private float _torque = 10000f;
    private float _maxSpinSpeed = 50f;

    private Vector3 _initialPosition;
    private Quaternion _initialRotation;

    private void Awake()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = _maxSpinSpeed;

        _initialPosition = gameObject.transform.localPosition;
        _initialRotation = gameObject.transform.localRotation;
    }

    public override void DoInteraction()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.MovePosition(_initialPosition);
        rb.MoveRotation(_initialRotation);
        rb.AddForce(_launchSpeed * Vector3.up, ForceMode.Impulse);
        rb.AddTorque(_torque * GenerateRandomDirection(), ForceMode.Impulse);
    }

    private Vector3 GenerateRandomDirection()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);

        return new Vector3(x, y, z);
    }
}
