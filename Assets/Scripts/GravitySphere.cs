using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitySphere : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (!rb) return;
        rb.AddTorque(Vector3.right * 50);
        rb.AddTorque(Vector3.forward * 50);
        rb.useGravity = false;
        rb.velocity = new Vector3(0,-1,0);
    }

    private void OnTriggerExit(Collider other)
    {
        Rigidbody rb = other.GetComponent<Rigidbody>();

        if (!rb) return;
        rb.useGravity = true;
    }
}
