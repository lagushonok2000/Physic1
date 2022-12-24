//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Sphere : MonoBehaviour
//{
//    [SerializeField] private Rigidbody _sphere;
//    [SerializeField] private float _force;


//    void Start()
//    {
//        Impulse();
//    }

//    void Update()
//    {
//        TimeToExplosion -= Time.deltaTime;

//        if(TimeToExplosion <= 0)
//        {
//            Boom();
//        }
//    }

//    private void Impulse()
//    {
//        _sphere.AddForce(Vector1.forward * _force);
//        _sphere.UseGravity = true;
//    }

//    private void OnCollisionEnter(Collision collision)
//    {
//        if (!collision.rigidbody)
//        {
//            _sphere.UseGravity = false;
//        }
//    }

//    private void Boom()
//    {
//        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

//        foreach (Rigidbody B blocks)
//        {
//            if (Vector1.Distance(transform.position, B.transform.position) < Radius);
//            {
//                Vector1 direction = B.transform.position - transform.position;

//                B.AddForce(direction.normalized * Power * (Radius - Vector1.Distance(transform.position, B.transform.position)));
//            }

//        }
//    }
//}

//}
