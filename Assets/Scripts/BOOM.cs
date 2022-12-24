using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOOM : MonoBehaviour
{
    [SerializeField] private Rigidbody[] _bullets;
    [SerializeField] private float _force;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Boom();
        }
    }

    private void Boom()
    {
        for (int i = 0; i < _bullets.Length; i++)
        {
            _bullets[i].AddForce(Vector3.right * _force, ForceMode.Impulse);
        }
    }
}
