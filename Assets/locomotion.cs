﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locomotion : MonoBehaviour {

    public float speed = 5;
 
        void Update()
        {
           
            transform.Translate(Vector3.forward * Time.deltaTime*speed, Space.World);
        }

    }

