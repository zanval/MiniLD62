﻿using UnityEngine;
using System.Collections;

public class MoveWithEnvironment : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
	
    }
	
    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(0.0f, 0.0f, Time.deltaTime * -PlayerSpeed.currentSpeed);
    }

}
