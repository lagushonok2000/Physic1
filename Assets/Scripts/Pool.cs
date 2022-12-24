using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] private Rigidbody _mainball;
    [SerializeField] private float _force;

    void Start()
    {
        Impulse();        
    }

    private void Impulse()
    {
        _mainball.AddForce(Vector3.forward * _force);
        _mainball.useGravity = true;
    }
}
