using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float ballspeed;
    public LogicScript logic;
    public bool birdIsAlive = true;
    
    public GameObject soccer_ball;
    
    public float X_velocity;
    public float Y_velocity;
    public Vector2 velocity;
    

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        Vector2 start_velocity = new Vector2 (Random.Range(0.8f,-0.8f), Random.Range(-0.7f,-0.7f));
        myRigidBody.AddForce(start_velocity * 50,ForceMode2D.Force);
        

    }

    // Update is called once per frame
    void Update()
    {

        velocity = myRigidBody.velocity;
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        float speed = velocity.magnitude;
        Vector2 surfaceNormal = col.contacts[0].normal;
        Vector2 direction = Vector2.Reflect(velocity.normalized,surfaceNormal);
        myRigidBody.velocity = direction * speed;
    }

    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Goal"){
    
        transform.position = new Vector2(0,Random.Range(0.7f,-1.7f));
        X_velocity = Random.Range(0.8f,-0.8f);
        Y_velocity = Random.Range(-0.7f,-0.7f);
        myRigidBody.velocity = new Vector2(X_velocity,Y_velocity) * 2;
        } 

    
            
    }
   private void OnTriggerExit2D(Collider2D collision)
   {
    if (collision.tag == "Player1")
        {
            myRigidBody.velocity = new Vector2(1,Random.Range(0.2f,-0.2f)) * ballspeed;
            
        }
    else if (collision.tag=="Player2")
    {
        myRigidBody.velocity = new Vector2(-1,Random.Range(0.2f,-0.2f)) * ballspeed;
    }
   }


}
