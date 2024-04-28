using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody2D playerRB;
    private float speed = 5000f;
    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.W)== true)
        {
            
            playerRB.velocity = Vector2.up * speed * Time.deltaTime;
        }
        
        else if (Input.GetKey(KeyCode.S) == true)
        {
            
            playerRB.velocity = Vector2.down * speed * Time.deltaTime;
        
        }
        else 
        {
            playerRB.velocity = new Vector2(0,0);

        }
    }

}
