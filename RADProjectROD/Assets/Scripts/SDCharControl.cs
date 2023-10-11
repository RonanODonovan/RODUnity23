using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SDCharControl : MonoBehaviour
{
    public GameObject snowballCloneTemplate;
    Transform tr;
    Rigidbody rb;
    float currentSpeed, walkingSpeed = 2, runningSpeed = 4;
    float turningSpeed = 180;
    Animator myanimator;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        myanimator = GetComponent<Animator>();
        currentSpeed = walkingSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        myanimator.SetBool("isRun", false);

        if (Input.GetKey(KeyCode.W))
        {
           // rb.AddForce(tr.forward);
             tr.position += currentSpeed * tr.forward * Time.deltaTime;
            myanimator.SetBool("isRun", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            myanimator.SetBool("isRun", true);
            tr.position -= currentSpeed * transform.forward * Time.deltaTime;

        }

        if (Input.GetKey(KeyCode.A))
        {
            tr.Rotate(Vector3.up, -turningSpeed * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.D))
        {
            tr.Rotate(Vector3.up, turningSpeed * Time.deltaTime);

        }

        if (Input.GetMouseButtonDown(0))
        {
           GameObject newGO = Instantiate(snowballCloneTemplate);

           SnowballScript mySnowball = newGO.GetComponent<SnowballScript>();

            mySnowball.Throwing(this);
        }
    }
}
