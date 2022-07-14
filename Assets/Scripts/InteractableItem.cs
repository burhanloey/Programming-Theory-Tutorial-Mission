using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItem : MonoBehaviour
{
    private bool _shouldInteract;

    private Vector3 _initialPosition;
    private Quaternion _initialRotation;

    private void Awake()
    {
        _shouldInteract = false;

        _initialPosition = gameObject.transform.localPosition;
        _initialRotation = gameObject.transform.localRotation;
    }

    private void FixedUpdate()
    {
        if (!_shouldInteract)
        {
            return;
        }

        if (ResetBeforeInteract())
        {
            ResetToInitial();
        }

        DoInteraction();
        _shouldInteract = false;
    }

    private void ResetToInitial()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.MovePosition(_initialPosition);
        rb.MoveRotation(_initialRotation);
    }

    public void Interact()
    {
        _shouldInteract = true;
    }

    protected virtual bool ResetBeforeInteract()
    {
        return true;
    }

    public abstract void DoInteraction();
}
