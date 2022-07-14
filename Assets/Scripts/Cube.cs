using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _launchSpeed = 50f;
    private float _torque = 10000f;
    private float _maxSpinSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = _maxSpinSpeed;
        rb.AddForce(_launchSpeed * Vector3.up, ForceMode.Impulse);
        rb.AddTorque(_torque * (Vector3.up + Vector3.forward), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
