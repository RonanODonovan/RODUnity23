using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class FollowScript : MonoBehaviour
{
    public Transform player;
    public float range;
    public float speed;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float disttoplayer = Vector3.Distance(player.position, transform.position);
        if (disttoplayer <= range)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed);
        }
    }

}
