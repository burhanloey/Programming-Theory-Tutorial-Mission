using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItem : MonoBehaviour
{
    // ENCAPSULATION
    private bool _shouldInteract;

    protected Vector3 initialPosition;
    protected Quaternion initialRotation;

    private void Awake()
    {
        _shouldInteract = false;

        initialPosition = gameObject.transform.localPosition;
        initialRotation = gameObject.transform.localRotation;
    }

    private void FixedUpdate()
    {
        if (!_shouldInteract)
        {
            return;
        }

        // ABSTRACTION
        if (ResetBeforeInteract())
        {
            ResetToInitial();
        }

        // ABSTRACTION
        DoInteraction();
        _shouldInteract = false;
    }

    // ABSTRACTION
    private void ResetToInitial()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.MovePosition(initialPosition);
        rb.MoveRotation(initialRotation);
    }

    public void Interact()
    {
        _shouldInteract = true;
    }

    protected virtual bool ResetBeforeInteract()
    {
        return true;
    }

    // ABSTRACTION
    public abstract void DoInteraction();
}
