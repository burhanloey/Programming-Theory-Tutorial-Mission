using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractableItem : MonoBehaviour
{
    private bool _shouldInteract;

    private void Awake()
    {
        _shouldInteract = false;
    }

    private void FixedUpdate()
    {
        if (_shouldInteract)
        {
            DoInteraction();
            _shouldInteract = false;
        }
    }

    public void Interact()
    {
        _shouldInteract = true;
    }

    public abstract void DoInteraction();
}
