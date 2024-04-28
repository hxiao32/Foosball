using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edge : MonoBehaviour
{

    public Rigidbody2D edgeRB;
    public  Rigidbody2D playerRB;
    private float speed = 5000f;
    

    // Flag to indicate if collision occurred
    public bool collisionOccurred = false;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        edgeRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)== true)
        {
            
            edgeRB.velocity = Vector2.up * speed * Time.deltaTime;
        }
        
        else if (Input.GetKey(KeyCode.S) == true)
        {
            
            edgeRB.velocity = Vector2.down * speed * Time.deltaTime;
        
        }
        else 
        {
            edgeRB.velocity = new Vector2(0,0);

        }
    }
    void OnCollisionEnter2D (Collision2D col)
    {
         // Set the flag to indicate collision
        collisionOccurred = true;

            // Stop the object by setting its velocity to zero
        playerRB.velocity = Vector2.zero;

        
    }
    void OnCollisionExit2D (Collision2D col)
    {
        collisionOccurred = false;
    }

}
