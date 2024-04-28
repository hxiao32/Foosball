using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickScript : MonoBehaviour

{
    public BallMoving ball;

    // Start is called before the first frame update
    void start ()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallMoving>();
    }
    void OnTriggerExit2D (Collider2D col)
    {
        Vector2 velocity = ball.myRigidBody.velocity;  
        if (col.gameObject.tag == "Player1")
        {
            ball.myRigidBody.velocity = Vector2.right * ball.ballspeed;
            
        }

        else if (col.gameObject.tag == "Player2")
        {
            
        }
    }

    
    
}
