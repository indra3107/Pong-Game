﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
    	if(other.collider.name == "wall kanan" || other.collider.name == "wall kiri"){
    		GetComponent<Transform>().position = new Vector2(0,0);
    	} 
    }
}
