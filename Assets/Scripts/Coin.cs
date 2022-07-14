using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : InteractableItem
{
    private float _torque = 10000f;
    private float _maxSpinSpeed = 100f;

    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = _maxSpinSpeed;
    }

    public override void DoInteraction()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddTorque(_torque * Vector3.up, ForceMode.Impulse);
    }
}
