using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballScript : MonoBehaviour
{
    Transform tr;
    Rigidbody rb;
    internal int check = 5;
    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 2, -8);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void Throwing(SDCharControl sDCharControl)
    {
        transform.position = sDCharControl.transform.position + 2* Vector3.up + sDCharControl.transform.forward;
        rb.velocity = 10 * (2 * Vector3.up + sDCharControl.transform.forward);
    }
}
