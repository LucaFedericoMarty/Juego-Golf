﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PelotaMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles += new Vector3(0, 2.5f, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.eulerAngles -= new Vector3(0, 2.5f, 0);

        }

        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.Translate(0.1f, 0, 0);
        }
    }
}
