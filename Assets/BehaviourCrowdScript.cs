using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviourCrowdScript : MonoBehaviour
{

    public float moveSpeed = 5; // 17:54 on  vid
    public Transform leftLimit; // Left limit of movement
    public Transform rightLimit; // Right limit of movement
    public Transform goalSensor; // Goal sensor aka ask whoever is doing this part
    public string otherSpriteTag = "Ball"; // i need the other sprite that triggers the goal

    private Rigidbody2D rb;
    private bool movingRight = true; // Initially moving to the right
    public Rigidbody2D myRigidBody; // from tut. video

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            if (transform.position.x >= rightLimit.position.x)
            {
                movingRight = false;
            }
        }
        else
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            if (transform.position.x <= leftLimit.position.x)
            {
                movingRight = true;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the other sprite is the ball
        if (other.tag == otherSpriteTag)
        {
            // Check if the goal sensor is triggered
            if (other.transform == goalSensor)
            {
                Debug.Log("Goal!");
                // Handle goal scored
            }
        }
    }
}
