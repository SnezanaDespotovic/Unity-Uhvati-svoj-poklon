using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kretati : MonoBehaviour
{
    
    void Start()
    {
        transform.Translate(Input.GetAxis("Horizontal")*15f*Time.deltaTime,0f,0f); 
    }
     void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal")*15f*Time.deltaTime,0f,0f); 
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Pokloni"))
        {
           Destroy(other.gameObject);
        }
        
      
    }
    

    
   
}
