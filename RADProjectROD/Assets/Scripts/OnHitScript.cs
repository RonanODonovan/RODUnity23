using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHitScript : MonoBehaviour
{
    int Health = 100;
    internal void OnHit()
    {
        Health -= 20;
        if(Health < 50)
        {

        }
        if(Health < 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
