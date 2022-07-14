using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : MonoBehaviour
{
    private float _torque = 10000f;
    private float _maxSpinSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = _maxSpinSpeed;
        rb.AddTorque(_torque * Vector3.up, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
