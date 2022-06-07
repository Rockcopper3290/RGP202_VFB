using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public float velocity = 1.0f;
    private bool isMovingRight = true;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //If User clicks on the screen = flap
        if (Input.GetMouseButtonDown(0))
        {
            //Flappy bird - Jump
            if (isMovingRight == true)
            {
                //rb.velocity = Vector2.right * 0;
                rb.velocity = Vector2.left * velocity;
                isMovingRight = false;

            }
            else if (isMovingRight == false)
            {
                //rb.velocity = Vector2.left * 0;
                rb.velocity = Vector2.right * velocity;
                isMovingRight = true;

            }

            //RGP Game - Switch direction.
        }
    }
}
