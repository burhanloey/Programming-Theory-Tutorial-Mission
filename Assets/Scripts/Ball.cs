using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : InteractableItem
{
    private float _launchSpeed = 50f;

    protected override bool ResetBeforeInteract()
    {
        return false;
    }

    public override void DoInteraction()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(_launchSpeed * Vector3.up, ForceMode.Impulse);
    }
}
