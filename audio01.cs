using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio01 : MonoBehaviour
{
    public AudioSource au;
    public AudioClip eat;

    void Start()
    {
        au= GetComponent<AudioSource>();

    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "A")
        {
            other.gameObject.SetActive(false);
            au.PlayOneShot(eat);
        }
    }
   
       
            
            
       
}
