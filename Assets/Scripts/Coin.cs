using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : InteractableItem
{
    private float _torque = 10000f;
    private float _maxSpinSpeed = 100f;

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
        rb.AddTorque(_torque * Vector3.up, ForceMode.Impulse);
    }
}
