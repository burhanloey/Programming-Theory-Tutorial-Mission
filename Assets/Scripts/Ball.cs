using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private float _launchSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(_launchSpeed * Vector3.up, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
