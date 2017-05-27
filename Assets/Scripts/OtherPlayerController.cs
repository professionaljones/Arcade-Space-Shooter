﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherPlayerController : MonoBehaviour {

    public float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-speed, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
		{
            transform.position += new Vector3(speed, 0, 0);
		}
	}
}