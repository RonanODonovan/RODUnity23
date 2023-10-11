using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    Transform tr;
    Rigidbody rb;
    internal int check = 1;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
   
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        OnHitScript thingHit = collision.gameObject.GetComponent<OnHitScript>();
        if (thingHit != null)
        {
            thingHit.OnHit();
        }
    }

    internal void Throwing(SDCharControl sDCharControl)
    {
        transform.position = sDCharControl.transform.position + 2* Vector3.up + sDCharControl.transform.forward;
        rb = GetComponent<Rigidbody>();
        rb.velocity = 1 * (1 * Vector3.up + sDCharControl.transform.forward);

    }
}
