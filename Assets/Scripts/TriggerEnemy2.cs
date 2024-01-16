using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Animations;
using UnityEngine;

public class TriggerEnemy2 : MonoBehaviour
{

    public Animator animatorEnemy2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        animatorEnemy2.SetBool("Enable", true);
        Debug.Log("Triggered Enemy 2");
    }
}