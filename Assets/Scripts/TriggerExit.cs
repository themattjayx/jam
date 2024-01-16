using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExit : MonoBehaviour
{

    public GameObject helper2;
    public GameObject comic2;

    public GameObject helper1;
    public GameObject comic1;
    
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
        helper2.SetActive(true);
        comic2.SetActive(true);
        
        helper1.SetActive(false);
        comic1.SetActive(false);
        Debug.Log("Trigger exit");
    }
}
