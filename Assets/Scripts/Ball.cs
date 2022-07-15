using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Ball : InteractableItem
{
    // ENCAPSULATION
    private float _launchSpeed = 25f;

    // POLYMORPHISM
    protected override bool ResetBeforeInteract()
    {
        return false;
    }

    // POLYMORPHISM
    public override void DoInteraction()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(_launchSpeed * Vector3.up, ForceMode.Impulse);
    }
}
