using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    int count = 0;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

      
            
        
        float moveHorizonal = Input.GetAxis("Horizontal");
        float moveVertial = Input.GetAxis("Vertical");
        

        Vector3 move = new Vector3(moveHorizonal,0.0f, moveVertial);
        rb.AddForce(move * speed);
        Score.text = "分數:"+count.ToString();
    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "A")
        {
            other.gameObject.SetActive(false);
            count+=1;
        }



    }
    
}
