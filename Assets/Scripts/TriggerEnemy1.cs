using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Animations;
using UnityEngine;

public class TriggerEnemy1 : MonoBehaviour
{

    public Animator animatorEnemy1;
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
        animatorEnemy1.SetBool("Enable", true);
        Debug.Log("Triggered Enemy 1");
    }
}
