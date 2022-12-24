using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Superman : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private float _speed;
    void Start()
    {
             
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.rigidbody) return;
        Vector3 direction = new Vector3(transform.position.x - collision.gameObject.transform.position.x,
            transform.position.y - collision.gameObject.transform.position.y,
            transform.position.z - collision.gameObject.transform.position.z);

        direction = direction.normalized;

        collision.rigidbody.AddForce(-direction * _force, ForceMode.Impulse);

        if (collision.gameObject.layer == 6)
        {
            
        }
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.up * _speed;
    }

    private void Move()
    {
        
    }
    
}
