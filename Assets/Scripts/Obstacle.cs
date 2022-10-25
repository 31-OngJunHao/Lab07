﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;
    public static int Score;

    void Update()
    {
        if (transform.position.x <= -8)
        {
            Destroy(gameObject);
            Score++;
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
        }
    }
}
