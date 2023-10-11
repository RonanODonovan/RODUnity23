using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.EventSystems.EventTrigger;

public class OnHitScript : MonoBehaviour
{
    int Health = 100;
    private Transform PlayerTr;
    Transform tr;
    internal void OnHit()
    {
        Health -= 50;
        if(Health < 50)
        {
            print("Low health");
        }
        if(Health < 0)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        PlayerTr = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.LookAt(PlayerTr.position);
    }
}
