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
    void Start()
    {
       // transform.position = new Vector3(0, 7, 0);

        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       // transform.position = new Vector3(0, 3, 0);

        if (Input.GetKey(KeyCode.UpArrow))
         {
            rb.AddForce(tr.forward);
           // tr.position += tr.forward * Time.deltaTime;
         }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("Working Explosion");
            rb.AddExplosionForce(100, tr.position - 2*Vector3.down, 10);
            // tr.position += tr.forward * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tr.position += Vector3.back * Time.deltaTime;


        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            tr.Rotate(Vector3.up, -90 * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            tr.Rotate(Vector3.up, 90 * Time.deltaTime);

        }

    }

    
}
