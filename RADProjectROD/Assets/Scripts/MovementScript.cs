using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update

    Transform tr;
    Rigidbody rb;
    Animator ani;
    void Start()
    {
       // transform.position = new Vector3(0, 7, 0);

        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(0, 3, 0);

        if (Input.GetKey(KeyCode.W))
         {
            rb.AddForce(tr.forward);
           // tr.position += tr.forward * Time.deltaTime;
         }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Working Explosion");
            rb.AddExplosionForce(100, tr.position - 2*Vector3.down, 5);
            // tr.position += tr.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            tr.position += Vector3.back * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.A))
        {
            tr.Rotate(Vector3.up, -90 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            tr.Rotate(Vector3.up, 90 * Time.deltaTime);

        }


    }

    
}
