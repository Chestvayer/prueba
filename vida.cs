﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vida : MonoBehaviour
{ 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "enemigo")
        {
            GameManager.CurrentVida--;
            
        }
        
    }

}
