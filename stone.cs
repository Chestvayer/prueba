﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stone : MonoBehaviour
{
    private const float yDie = -30.0f;
    public GameObject explosion;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < yDie)
        {
            Destroy(gameObject);
            
        }
        
    }
    void OnMouseDown()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameManager.CurrentNumberDestroyStone++;

        
    }
}
