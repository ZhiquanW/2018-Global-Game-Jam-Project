﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMapController : MonoBehaviour {

    public float rotateSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(new Vector3(0,0,1), rotateSpeed);
	}
}
